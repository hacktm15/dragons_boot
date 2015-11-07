Public Module DriveDetection

    ' Lists of all Drive Info
    Public DriveIndex(30) As String
    Public DriveCaption(30) As String
    Public DriveSize(30) As String
    Public DriveInterfaceType(30) As String
    Public DriveMediaType(30) As String

    ' Selected Drive Info
    Public SelectedDriveIndex As String
    Public SelectedDriveCaption As String
    Public SelectedDriveSize As String
    Public SelectedDriveInterfaceType As String
    Public SelectedDriveMediaType As String

    ' Detects all removable storage devices and lists them in the selection window.
    Public Sub Detect()
        ' Empty the list
        DBUSBMaker.cob_RemovableDrives.Items.Clear()
        ReDim DriveIndex(30)
        ReDim DriveCaption(30)
        ReDim DriveSize(30)
        ReDim DriveInterfaceType(30)
        ReDim DriveMediaType(30)

        ' Detect Drives
        Dim NrDrives As Integer = 0
        Dim objWMIService As Object
        objWMIService = GetObject("winmgmts:" & "{impersonationLevel=impersonate}!\\" & My.Computer.Name & "\root\cimv2")

        Dim colDrives
        colDrives = objWMIService.ExecQuery("Select * from Win32_DiskDrive")

        For Each Drive In colDrives
            If DBUSBMaker.AllowDiskDrivesToolStripMenuItem.Checked = False And Drive.InterfaceType.ToString <> "USB" Then
                'Ignore current drive
                Continue For
            End If

            ' Get and set variables for all index drives found
            DriveIndex(Drive.Index) = Drive.Index
            DriveCaption(Drive.Index) = Drive.Caption
            DriveInterfaceType(Drive.Index) = Drive.Interfacetype.ToString
            DriveMediaType(Drive.Index) = Drive.MediaType.ToString

            If Drive.Size.ToString = Nothing Then
                DriveSize(Drive.Index) = 0
            Else
                DriveSize(Drive.Index) = Drive.Size
                DriveSize(Drive.Index) = Format(DriveSize(Drive.Index) / 1024 / 1024 / 1024, "0.00 GB")


            End If

            ' Add them to the list
            DBUSBMaker.cob_RemovableDrives.Items.Add("(#" & DriveIndex(Drive.Index) & ")  " & (Drive.Caption(Drive.Index) & "           ").ToString.Substring(0, 10) & " - " & DriveSize(Drive.Index).PadLeft(10, " "))
            NrDrives += 1
        Next
        colDrives = Nothing
        objWMIService = Nothing

        If NrDrives > 0 Then
            DBUSBMaker.cob_RemovableDrives.Enabled = True
            DBUSBMaker.cob_RemovableDrives.Sorted = True
            DBUSBMaker.cob_RemovableDrives.SelectedIndex = 0
            DBUSBMaker.b_FormatDrive.Enabled = True
            DBUSBMaker.b_Qemu.Enabled = True
        Else
            DBUSBMaker.cob_RemovableDrives.Enabled = False
            DBUSBMaker.pb_CurrentDevice.Image = My.Resources.Ico_NotFound
            DBUSBMaker.b_FormatDrive.Enabled = False
            DBUSBMaker.b_Qemu.Enabled = False
            DBUSBMaker.L_DriveLabel.Text = "<N/A>"
            DBUSBMaker.L_DriveSize.Text = "<N/A>"
            DBUSBMaker.L_DriveIndex.Text = "<N/A>"
            DBUSBMaker.L_DriveInterfaceType.Text = "<N/A>"
            DBUSBMaker.L_DriveMediaType.Text = "<N/A>"
        End If

    End Sub
End Module
