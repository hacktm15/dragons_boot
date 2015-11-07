Public Class DBUSBMaker
    ' ----------------------------------- ON LOAD -------------------------------------------------
    Private Sub DBSUBMaker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Format Settings Initializations
        rb_EZFormat.Checked = True
        ' Detect Drives
        DriveDetection.Detect()

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

    ' Update Selected Drive Proprieties
    Private Sub cob_RemovableDrives_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_RemovableDrives.SelectedIndexChanged
        Dim DriveListIndex As Integer = CInt(cob_RemovableDrives.SelectedItem.ToString.Substring(2, 1)) 'Only used here, reprezents the selected item lists' drive number
        SelectedDriveIndex = DriveIndex(DriveListIndex)
        SelectedDriveCaption = DriveCaption(DriveListIndex)
        SelectedDriveSize = DriveSize(DriveListIndex)
        SelectedDriveInterfaceType = DriveInterfaceType(DriveListIndex)
        SelectedDriveMediaType = DriveMediaType(DriveListIndex)

        If SelectedDriveCaption.Length() > 19 Then
            L_DriveLabel.Text = SelectedDriveCaption.Substring(0, 19)
        Else
            L_DriveLabel.Text = SelectedDriveCaption
        End If

        L_DriveSize.Text = SelectedDriveSize
        L_DriveIndex.Text = SelectedDriveIndex
        L_DriveMediaType.Text = SelectedDriveMediaType
        L_DriveInterfaceType.Text = SelectedDriveInterfaceType

        If L_DriveInterfaceType.Text.Contains("USB") Then
            pb_CurrentDevice.Image = My.Resources.Ico_USB
        ElseIf SelectedDriveInterfaceType Like "IDE" Then
            pb_CurrentDevice.Image = My.Resources.Ico_HDD
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

    ' Toggles Internal Drive Detection
    Private Sub AllowDiskDrivesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllowDiskDrivesToolStripMenuItem.Click
        DriveDetection.Detect()
    End Sub
    ' Quits the Application
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    ' Rescand Drives
    Private Sub RescanDrivesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RescanDrivesToolStripMenuItem.Click
        DriveDetection.Detect()
    End Sub

    '--------------------------------------- FORMATTING AND QEMU -----------------------------------------------------------------
    Private Sub b_FormatDrive_Click(sender As Object, e As EventArgs) Handles b_FormatDrive.Click
        QEMU_Fbinst.Run_Fbinst(SelectedDriveIndex)
    End Sub

    Private Sub b_Qemu_Click(sender As Object, e As EventArgs) Handles b_Qemu.Click
        QEMU_Fbinst.Run_Qemu(SelectedDriveIndex)
    End Sub

    Private Sub pb_CurrentDevice_BackgroundImageChanged(sender As Object, e As EventArgs) Handles pb_CurrentDevice.BackgroundImageChanged
        MsgBox("Yo")
    End Sub

    ' If no device is selcted, block the QEMU and Format Buttons

End Class