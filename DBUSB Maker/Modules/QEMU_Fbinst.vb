Public Module QEMU_Fbinst

    ' File Streams for copying
    Dim TempPath As String = IO.Path.GetTempPath()
    Dim FileToWrite As String
    Dim BytesToWrite() As Byte
    Dim FileStream As IO.FileStream
    Dim BinaryWriter As IO.BinaryWriter

    Public Sub Run_Qemu(ByVal SelectedDriveIndex)
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
        Shell("cmd.exe /c " & TempPath.Substring(0, 2) & " & cd %temp%\DBUSB\Maker\QEMU & " & "qemu.exe -L . -m " & Qemu_Memory & " -hda \\.\PhysicalDrive" & SelectedDriveIndex & " -boot c -usb -std-vga -localtime -M pc -no-kqemu -snapshot", AppWinStyle.Hide, True)

    End Sub

    Public Sub Run_Fbinst(ByRef SelectedDriveIndex)
        Dim response As Integer = MsgBox("WARNING!!!" & vbCrLf & "Formatting will cause all data on the device to be lost. Are you sure you want to format drive " & SelectedDriveIndex & "?", MsgBoxStyle.YesNo, "Formatting Propmpt")
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
            Dim FormatCommand = "fbinst(hd" & SelectedDriveIndex & ") format "

            ' MBR Filesystem
            If DBUSBMaker.cb_Format_MBR.Checked = True Then
                Select Case DBUSBMaker.cob_Format_type.SelectedIndex
                    Case 0
                        FormatCommand = FormatCommand & "--fat32"
                    Case 1
                        FormatCommand = FormatCommand & "--fat16"
                    Case 2
                        FormatCommand = FormatCommand & "--raw"
                End Select
            End If

            ' Force CHS
            If DBUSBMaker.cb_Format_CHS.Checked = True Then
                FormatCommand = FormatCommand & " --chs"
            End If

            ' USB ZIP
            If DBUSBMaker.cb_Format_USBZip.Checked = True Then
                FormatCommand = FormatCommand & " -z"
            End If

            ' Align
            If DBUSBMaker.cb_Format_Align.Checked = True Then
                FormatCommand = FormatCommand & " -a"
            End If

            ' Force MBR Repartition
            If DBUSBMaker.cb_Format_Repartition.Checked = True Then
                FormatCommand = FormatCommand & " -f"
            End If

            ' Adding the grldrs
            Dim GrldrCommand As String = "fbinst (hd" & SelectedDriveIndex & ") add grldr grldr"
            Dim MenuCommand As String = "fbinst (hd" & SelectedDriveIndex & ") add-menu fb.cfg fb.txt"

            ' Format the Device
            Shell("cmd.exe /c " & TempPath.Substring(0, 2) & " & cd %temp%\DBUSB\Maker\Fbinst & " & FormatCommand & " & " & GrldrCommand & " & " & MenuCommand, AppWinStyle.Hide, True)

            ' Create Default Folders
            'My.Computer.FileSystem.CreateDirectory(DriveLetter + "DBUSB\IMAGES\Menus")
            MsgBox("Done!")

        End If
    End Sub
End Module
