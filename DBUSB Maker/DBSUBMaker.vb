Imports System.Diagnostics
Imports System.Security

Public Class DBSUBMaker

    ' VARIABLES
    Dim SelectedDrive As Integer = 1 'TODO Generate it
    Dim SelectedDriveLetter As String
    Dim TempPath As String = IO.Path.GetTempPath()
    Dim FileToWrite As String
    Dim BytesToWrite() As Byte
    Dim FileStream As IO.FileStream
    Dim BinaryWriter As IO.BinaryWriter

    ' ----------------------------------- ON LOAD -------------------------------------------------
    Private Sub DBSUBMaker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Format Settings Initializations
        rb_EZFormat.Checked = True

        ' Detect Drives
        For Each d As System.IO.DriveInfo In My.Computer.FileSystem.Drives
            If d.DriveType = IO.DriveType.Removable Then
                cob_RemovableDrives.Items.Add(d.Name & d.DriveFormat & d.VolumeLabel)
            End If
        Next
    End Sub

    ' -------------------------------- FORM RULES --------------------------------------------------
    ' Prevent checkboxes when 'RAW' is selected as a filesystem
    Private Sub cob_Format_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_Format_type.SelectedIndexChanged
        If cob_Format_type.SelectedIndex = 2 Then
            cb_Format_Repartition.Checked = False
            cb_Format_Align.Checked = False
            cb_Format_CHS.Checked = False
            cb_Format_USBZip.Checked = False
            cb_Format_Repartition.Enabled = False
            cb_Format_Align.Enabled = False
            cb_Format_CHS.Enabled = False
            cb_Format_USBZip.Enabled = False
        Else
            cb_Format_Repartition.Enabled = True
            cb_Format_Align.Enabled = True
            cb_Format_CHS.Enabled = True
            cb_Format_USBZip.Enabled = True
        End If
    End Sub

    ' Allow to select a filesystem only when MBR Formatting is wanted
    Private Sub cb_Format_MBR_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Format_MBR.CheckedChanged
        If cb_Format_MBR.Checked Then
            cob_Format_type.Enabled = True
        Else
            cob_Format_type.Enabled = False
        End If
    End Sub

    ' Resets FBInst Options to the default configuration
    Private Sub rb_EZFormat_CheckedChanged(sender As Object, e As EventArgs) Handles rb_EZFormat.CheckedChanged
        If rb_EZFormat.Checked = True Then
            ' Select Default Options
            cb_Format_MBR.Checked = True
            cb_Format_Repartition.Checked = True
            cb_Format_Align.Checked = True
            cb_Format_CHS.Checked = True
            cb_Format_USBZip.Checked = False
            cob_Format_type.SelectedItem = "Fat 32"

            ' Lock them into place.
            cb_Format_MBR.Enabled = False
            cb_Format_Repartition.Enabled = False
            cb_Format_Align.Enabled = False
            cb_Format_CHS.Enabled = False
            cb_Format_USBZip.Enabled = False
            cob_Format_type.Enabled = False
        Else
            ' Unlock options for custom setup
            cb_Format_MBR.Enabled = True
            cb_Format_Repartition.Enabled = True
            cb_Format_Align.Enabled = True
            cb_Format_CHS.Enabled = True
            cb_Format_USBZip.Enabled = True
            cob_Format_type.Enabled = True
        End If
    End Sub
    '--------------------------------------- FORMATTING AND QEMU -----------------------------------------------------------------
    Private Sub b_FormatDrive_Click(sender As Object, e As EventArgs) Handles b_FormatDrive.Click
        Dim response As Integer = MsgBox("WARNING!!!" & vbCrLf & "Formatting will cause all data on the device to be lost. Are you sure you want to format?", MsgBoxStyle.YesNo, "Formatting Propmpt")
        If response = MsgBoxResult.Yes Then
            ' Copy necessary files to temp
            My.Computer.FileSystem.CreateDirectory(TempPath + "DBUSB\Maker\Fbinst\")

            FileToWrite = "fbinst.exe"
            BytesToWrite = My.Resources.fbinstExe()
            FileStream = New IO.FileStream(TempPath & "DBUSB\Maker\Fbinst\" & FileToWrite, System.IO.FileMode.OpenOrCreate)
            BinaryWriter = New System.IO.BinaryWriter(FileStream)
            BinaryWriter.Write(BytesToWrite)
            FileStream.Close()
            BinaryWriter.Close()

            FileToWrite = "grldr"
            BytesToWrite = My.Resources.grldr()
            FileStream = New IO.FileStream(TempPath & "DBUSB\Maker\Fbinst\" & FileToWrite, System.IO.FileMode.OpenOrCreate)
            BinaryWriter = New System.IO.BinaryWriter(FileStream)
            BinaryWriter.Write(BytesToWrite)
            FileStream.Close()
            BinaryWriter.Close()

            FileStream = IO.File.Create(TempPath & "DBUSB\Maker\Fbinst\" & "fb.txt")
            Dim FileContent As Byte() = New System.Text.UTF8Encoding(True).GetBytes("default 0" & vbCrLf &
                                                                                    "timeout 0" & vbCrLf &
                                                                                    "text " & Chr(34) & "Menu:" & Chr(34) & vbCrLf &
                                                                                    "text " & Chr(34) & "F1. grldr" & Chr(34) & vbCrLf &
                                                                                    "menu F1 grldr grldr")
            FileStream.Write(FileContent, 0, FileContent.Length)
            FileStream.Close()

            ' Build Format Command
            Dim FormatCommand = "fbinst(hd" & SelectedDrive & ") format "

            ' MBR Filesystem
            If cb_Format_MBR.Checked = True Then
                Select Case cob_Format_type.SelectedIndex
                    Case 0
                        FormatCommand = FormatCommand & "--fat32"
                    Case 1
                        FormatCommand = FormatCommand & "--fat16"
                    Case 2
                        FormatCommand = FormatCommand & "--raw"
                End Select
            End If

            ' Force CHS
            If cb_Format_CHS.Checked = True Then
                FormatCommand = FormatCommand & " --chs"
            End If

            ' USB ZIP
            If cb_Format_USBZip.Checked = True Then
                FormatCommand = FormatCommand & " -z"
            End If

            ' Align
            If cb_Format_Align.Checked = True Then
                FormatCommand = FormatCommand & " -a"
            End If

            ' Force MBR Repartition
            If cb_Format_Repartition.Checked = True Then
                FormatCommand = FormatCommand & " -f"
            End If

            ' Adding the grldrs
            Dim GrldrCommand As String = "fbinst (hd" & SelectedDrive & ") add grldr grldr"
            Dim MenuCommand As String = "fbinst (hd" & SelectedDrive & ") add-menu fb.cfg fb.txt"

            ' Format the Device
            Shell("cmd.exe /c " & TempPath.Substring(0, 2) & " & cd %temp%\DBUSB\Maker\Fbinst & " & FormatCommand & " & " & GrldrCommand & " & " & MenuCommand, AppWinStyle.Hide, True)

            ' Create Default Folders
            'My.Computer.FileSystem.CreateDirectory(DriveLetter + "DBUSB\IMAGES\Menus")
            MsgBox("Done!")

        End If
    End Sub

    Private Sub b_Qemu_Click(sender As Object, e As EventArgs) Handles b_Qemu.Click

        ' Allocate memory for QEMU
        Dim Qemu_Memory As Integer = My.Computer.Info.AvailablePhysicalMemory / 1024 / 1024 / 2
        If Qemu_Memory > 1024 Then
            Qemu_Memory = 1024
        End If

        ' If there isn't enough, exit
        If Qemu_Memory < 64 Then
            MsgBox("You need at least 128 MB of available memory to run QEMU!")
            Exit Sub
        End If

        ' Copy necessary files to temp folder
        My.Computer.FileSystem.CreateDirectory(TempPath + "DBUSB\Maker\QEMU")

        FileToWrite = "bios.bin"
        BytesToWrite = My.Resources.qemuBiosBin()
        FileStream = New IO.FileStream(TempPath & "DBUSB\Maker\QEMU\" & FileToWrite, System.IO.FileMode.OpenOrCreate)
        BinaryWriter = New System.IO.BinaryWriter(FileStream)
        BinaryWriter.Write(BytesToWrite)
        FileStream.Close()
        BinaryWriter.Close()

        FileToWrite = "qemu.exe"
        BytesToWrite = My.Resources.qemuQemuExe()
        FileStream = New IO.FileStream(TempPath & "DBUSB\Maker\QEMU\" & FileToWrite, System.IO.FileMode.OpenOrCreate)
        BinaryWriter = New System.IO.BinaryWriter(FileStream)
        BinaryWriter.Write(BytesToWrite)
        FileStream.Close()
        BinaryWriter.Close()

        FileToWrite = "vgabios.bin"
        BytesToWrite = My.Resources.qemuVgabiosBin()
        FileStream = New IO.FileStream(TempPath & "DBUSB\Maker\QEMU\" & FileToWrite, System.IO.FileMode.OpenOrCreate)
        BinaryWriter = New System.IO.BinaryWriter(FileStream)
        BinaryWriter.Write(BytesToWrite)
        FileStream.Close()
        BinaryWriter.Close()

        ' Run qemu
        Shell("cmd.exe /c " & TempPath.Substring(0, 2) & " & cd %temp%\DBUSB\Maker\QEMU & " & "qemu.exe -L . -m " & Qemu_Memory & " -hda \\.\PhysicalDrive" & SelectedDrive & " -boot c -usb -std-vga -localtime -M pc -no-kqemu -snapshot", AppWinStyle.Hide, True)

    End Sub

    Private Sub cob_RemovableDrives_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_RemovableDrives.SelectedIndexChanged
        ' Refreshes Selected Drive Variables
        For Each d As System.IO.DriveInfo In My.Computer.FileSystem.Drives
            If d.DriveType = IO.DriveType.Removable And d.Name = cob_RemovableDrives.SelectedItem.Substring(0, 3) Then
                MsgBox("Yeah!")
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Refreshes Selected Drive Variables
        For Each d As System.IO.DriveInfo In My.Computer.FileSystem.Drives
            If d.DriveType = IO.DriveType.Removable And d.Name = cob_RemovableDrives.SelectedItem.Substring(0, 3) Then
                MsgBox("Yeah!")
            End If
        Next
    End Sub
End Class