﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DBUSBMaker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DBUSBMaker))
        Me.b_Qemu = New System.Windows.Forms.Button()
        Me.gb_Format = New System.Windows.Forms.GroupBox()
        Me.cob_Format_type = New System.Windows.Forms.ComboBox()
        Me.cb_Format_USBZip = New System.Windows.Forms.CheckBox()
        Me.cb_Format_CHS = New System.Windows.Forms.CheckBox()
        Me.cb_Format_Align = New System.Windows.Forms.CheckBox()
        Me.cb_Format_Repartition = New System.Windows.Forms.CheckBox()
        Me.cb_Format_MBR = New System.Windows.Forms.CheckBox()
        Me.b_FormatDrive = New System.Windows.Forms.Button()
        Me.rb_ADFormat = New System.Windows.Forms.RadioButton()
        Me.rb_EZFormat = New System.Windows.Forms.RadioButton()
        Me.gb_Qemu = New System.Windows.Forms.GroupBox()
        Me.gb_Devices = New System.Windows.Forms.GroupBox()
        Me.L_DrivePartitions = New System.Windows.Forms.Label()
        Me.L_Partitions = New System.Windows.Forms.Label()
        Me.L_DriveInterfaceType = New System.Windows.Forms.Label()
        Me.L_DriveMediaType = New System.Windows.Forms.Label()
        Me.L_DriveIndex = New System.Windows.Forms.Label()
        Me.L_DriveSize = New System.Windows.Forms.Label()
        Me.L_DriveLabel = New System.Windows.Forms.Label()
        Me.L_Capacity = New System.Windows.Forms.Label()
        Me.L_MediaType = New System.Windows.Forms.Label()
        Me.L_InterfaceType = New System.Windows.Forms.Label()
        Me.L_Caption = New System.Windows.Forms.Label()
        Me.L_Index = New System.Windows.Forms.Label()
        Me.pb_CurrentDevice = New System.Windows.Forms.PictureBox()
        Me.cob_RemovableDrives = New System.Windows.Forms.ComboBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RescanDrivesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllowDiskDrivesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cb_Format_AddFiles = New System.Windows.Forms.CheckBox()
        Me.gb_Format.SuspendLayout()
        Me.gb_Qemu.SuspendLayout()
        Me.gb_Devices.SuspendLayout()
        CType(Me.pb_CurrentDevice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'b_Qemu
        '
        Me.b_Qemu.Enabled = False
        Me.b_Qemu.Image = Global.DBUSB_Maker.My.Resources.Resources.Ico_VM
        Me.b_Qemu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_Qemu.Location = New System.Drawing.Point(6, 19)
        Me.b_Qemu.Name = "b_Qemu"
        Me.b_Qemu.Size = New System.Drawing.Size(202, 23)
        Me.b_Qemu.TabIndex = 0
        Me.b_Qemu.Text = "Run on Virtual Machine"
        Me.b_Qemu.UseVisualStyleBackColor = True
        '
        'gb_Format
        '
        Me.gb_Format.Controls.Add(Me.cb_Format_AddFiles)
        Me.gb_Format.Controls.Add(Me.cob_Format_type)
        Me.gb_Format.Controls.Add(Me.cb_Format_USBZip)
        Me.gb_Format.Controls.Add(Me.cb_Format_CHS)
        Me.gb_Format.Controls.Add(Me.cb_Format_Align)
        Me.gb_Format.Controls.Add(Me.cb_Format_Repartition)
        Me.gb_Format.Controls.Add(Me.cb_Format_MBR)
        Me.gb_Format.Controls.Add(Me.b_FormatDrive)
        Me.gb_Format.Controls.Add(Me.rb_ADFormat)
        Me.gb_Format.Controls.Add(Me.rb_EZFormat)
        Me.gb_Format.Location = New System.Drawing.Point(12, 350)
        Me.gb_Format.Name = "gb_Format"
        Me.gb_Format.Size = New System.Drawing.Size(214, 165)
        Me.gb_Format.TabIndex = 1
        Me.gb_Format.TabStop = False
        Me.gb_Format.Text = "Format USB"
        '
        'cob_Format_type
        '
        Me.cob_Format_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cob_Format_type.FormattingEnabled = True
        Me.cob_Format_type.Items.AddRange(New Object() {"Fat 32", "Fat 16", "RAW"})
        Me.cob_Format_type.Location = New System.Drawing.Point(113, 39)
        Me.cob_Format_type.Name = "cob_Format_type"
        Me.cob_Format_type.Size = New System.Drawing.Size(95, 21)
        Me.cob_Format_type.TabIndex = 2
        '
        'cb_Format_USBZip
        '
        Me.cb_Format_USBZip.AutoSize = True
        Me.cb_Format_USBZip.Location = New System.Drawing.Point(113, 89)
        Me.cb_Format_USBZip.Name = "cb_Format_USBZip"
        Me.cb_Format_USBZip.Size = New System.Drawing.Size(66, 17)
        Me.cb_Format_USBZip.TabIndex = 7
        Me.cb_Format_USBZip.Text = "USB-Zip"
        Me.cb_Format_USBZip.UseVisualStyleBackColor = True
        '
        'cb_Format_CHS
        '
        Me.cb_Format_CHS.AutoSize = True
        Me.cb_Format_CHS.Location = New System.Drawing.Point(113, 66)
        Me.cb_Format_CHS.Name = "cb_Format_CHS"
        Me.cb_Format_CHS.Size = New System.Drawing.Size(78, 17)
        Me.cb_Format_CHS.TabIndex = 6
        Me.cb_Format_CHS.Text = "Force CHS"
        Me.cb_Format_CHS.UseVisualStyleBackColor = True
        '
        'cb_Format_Align
        '
        Me.cb_Format_Align.AutoSize = True
        Me.cb_Format_Align.Location = New System.Drawing.Point(7, 89)
        Me.cb_Format_Align.Name = "cb_Format_Align"
        Me.cb_Format_Align.Size = New System.Drawing.Size(49, 17)
        Me.cb_Format_Align.TabIndex = 5
        Me.cb_Format_Align.Text = "Align"
        Me.cb_Format_Align.UseVisualStyleBackColor = True
        '
        'cb_Format_Repartition
        '
        Me.cb_Format_Repartition.AutoSize = True
        Me.cb_Format_Repartition.Location = New System.Drawing.Point(7, 66)
        Me.cb_Format_Repartition.Name = "cb_Format_Repartition"
        Me.cb_Format_Repartition.Size = New System.Drawing.Size(77, 17)
        Me.cb_Format_Repartition.TabIndex = 4
        Me.cb_Format_Repartition.Text = "Repartition"
        Me.cb_Format_Repartition.UseVisualStyleBackColor = True
        '
        'cb_Format_MBR
        '
        Me.cb_Format_MBR.AutoSize = True
        Me.cb_Format_MBR.Location = New System.Drawing.Point(7, 43)
        Me.cb_Format_MBR.Name = "cb_Format_MBR"
        Me.cb_Format_MBR.Size = New System.Drawing.Size(85, 17)
        Me.cb_Format_MBR.TabIndex = 3
        Me.cb_Format_MBR.Text = "MBR Format"
        Me.cb_Format_MBR.UseVisualStyleBackColor = True
        '
        'b_FormatDrive
        '
        Me.b_FormatDrive.Enabled = False
        Me.b_FormatDrive.Image = Global.DBUSB_Maker.My.Resources.Resources.Ico_Format
        Me.b_FormatDrive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_FormatDrive.Location = New System.Drawing.Point(6, 136)
        Me.b_FormatDrive.Name = "b_FormatDrive"
        Me.b_FormatDrive.Size = New System.Drawing.Size(202, 23)
        Me.b_FormatDrive.TabIndex = 2
        Me.b_FormatDrive.Text = "Format Drive"
        Me.b_FormatDrive.UseVisualStyleBackColor = True
        '
        'rb_ADFormat
        '
        Me.rb_ADFormat.AutoSize = True
        Me.rb_ADFormat.Location = New System.Drawing.Point(113, 19)
        Me.rb_ADFormat.Name = "rb_ADFormat"
        Me.rb_ADFormat.Size = New System.Drawing.Size(95, 17)
        Me.rb_ADFormat.TabIndex = 1
        Me.rb_ADFormat.TabStop = True
        Me.rb_ADFormat.Text = "Custom Format"
        Me.rb_ADFormat.UseVisualStyleBackColor = True
        '
        'rb_EZFormat
        '
        Me.rb_EZFormat.AutoSize = True
        Me.rb_EZFormat.Location = New System.Drawing.Point(6, 20)
        Me.rb_EZFormat.Name = "rb_EZFormat"
        Me.rb_EZFormat.Size = New System.Drawing.Size(74, 17)
        Me.rb_EZFormat.TabIndex = 0
        Me.rb_EZFormat.TabStop = True
        Me.rb_EZFormat.Text = "EZ Format"
        Me.rb_EZFormat.UseVisualStyleBackColor = True
        '
        'gb_Qemu
        '
        Me.gb_Qemu.Controls.Add(Me.b_Qemu)
        Me.gb_Qemu.Location = New System.Drawing.Point(12, 294)
        Me.gb_Qemu.Name = "gb_Qemu"
        Me.gb_Qemu.Size = New System.Drawing.Size(214, 50)
        Me.gb_Qemu.TabIndex = 2
        Me.gb_Qemu.TabStop = False
        Me.gb_Qemu.Text = "QEMU"
        '
        'gb_Devices
        '
        Me.gb_Devices.Controls.Add(Me.L_DrivePartitions)
        Me.gb_Devices.Controls.Add(Me.L_Partitions)
        Me.gb_Devices.Controls.Add(Me.L_DriveInterfaceType)
        Me.gb_Devices.Controls.Add(Me.L_DriveMediaType)
        Me.gb_Devices.Controls.Add(Me.L_DriveIndex)
        Me.gb_Devices.Controls.Add(Me.L_DriveSize)
        Me.gb_Devices.Controls.Add(Me.L_DriveLabel)
        Me.gb_Devices.Controls.Add(Me.L_Capacity)
        Me.gb_Devices.Controls.Add(Me.L_MediaType)
        Me.gb_Devices.Controls.Add(Me.L_InterfaceType)
        Me.gb_Devices.Controls.Add(Me.L_Caption)
        Me.gb_Devices.Controls.Add(Me.L_Index)
        Me.gb_Devices.Controls.Add(Me.pb_CurrentDevice)
        Me.gb_Devices.Controls.Add(Me.cob_RemovableDrives)
        Me.gb_Devices.Location = New System.Drawing.Point(12, 27)
        Me.gb_Devices.Name = "gb_Devices"
        Me.gb_Devices.Size = New System.Drawing.Size(214, 261)
        Me.gb_Devices.TabIndex = 3
        Me.gb_Devices.TabStop = False
        Me.gb_Devices.Text = "Device Selector"
        '
        'L_DrivePartitions
        '
        Me.L_DrivePartitions.AutoSize = True
        Me.L_DrivePartitions.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_DrivePartitions.Location = New System.Drawing.Point(89, 227)
        Me.L_DrivePartitions.Name = "L_DrivePartitions"
        Me.L_DrivePartitions.Size = New System.Drawing.Size(37, 13)
        Me.L_DrivePartitions.TabIndex = 13
        Me.L_DrivePartitions.Text = "<N/A>"
        '
        'L_Partitions
        '
        Me.L_Partitions.AutoSize = True
        Me.L_Partitions.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Partitions.Location = New System.Drawing.Point(3, 227)
        Me.L_Partitions.Name = "L_Partitions"
        Me.L_Partitions.Size = New System.Drawing.Size(84, 15)
        Me.L_Partitions.TabIndex = 12
        Me.L_Partitions.Text = "Partitions:"
        '
        'L_DriveInterfaceType
        '
        Me.L_DriveInterfaceType.AutoSize = True
        Me.L_DriveInterfaceType.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_DriveInterfaceType.Location = New System.Drawing.Point(89, 187)
        Me.L_DriveInterfaceType.Name = "L_DriveInterfaceType"
        Me.L_DriveInterfaceType.Size = New System.Drawing.Size(37, 13)
        Me.L_DriveInterfaceType.TabIndex = 11
        Me.L_DriveInterfaceType.Text = "<N/A>"
        '
        'L_DriveMediaType
        '
        Me.L_DriveMediaType.AutoSize = True
        Me.L_DriveMediaType.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_DriveMediaType.Location = New System.Drawing.Point(89, 207)
        Me.L_DriveMediaType.Name = "L_DriveMediaType"
        Me.L_DriveMediaType.Size = New System.Drawing.Size(37, 13)
        Me.L_DriveMediaType.TabIndex = 10
        Me.L_DriveMediaType.Text = "<N/A>"
        '
        'L_DriveIndex
        '
        Me.L_DriveIndex.AutoSize = True
        Me.L_DriveIndex.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_DriveIndex.Location = New System.Drawing.Point(89, 166)
        Me.L_DriveIndex.Name = "L_DriveIndex"
        Me.L_DriveIndex.Size = New System.Drawing.Size(37, 13)
        Me.L_DriveIndex.TabIndex = 9
        Me.L_DriveIndex.Text = "<N/A>"
        '
        'L_DriveSize
        '
        Me.L_DriveSize.AutoSize = True
        Me.L_DriveSize.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_DriveSize.Location = New System.Drawing.Point(89, 145)
        Me.L_DriveSize.Name = "L_DriveSize"
        Me.L_DriveSize.Size = New System.Drawing.Size(37, 13)
        Me.L_DriveSize.TabIndex = 8
        Me.L_DriveSize.Text = "<N/A>"
        '
        'L_DriveLabel
        '
        Me.L_DriveLabel.AutoSize = True
        Me.L_DriveLabel.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_DriveLabel.Location = New System.Drawing.Point(89, 127)
        Me.L_DriveLabel.Name = "L_DriveLabel"
        Me.L_DriveLabel.Size = New System.Drawing.Size(121, 13)
        Me.L_DriveLabel.TabIndex = 7
        Me.L_DriveLabel.Text = "<NO DRIVE DETECTED>"
        '
        'L_Capacity
        '
        Me.L_Capacity.AutoSize = True
        Me.L_Capacity.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Capacity.Location = New System.Drawing.Point(45, 145)
        Me.L_Capacity.Name = "L_Capacity"
        Me.L_Capacity.Size = New System.Drawing.Size(42, 15)
        Me.L_Capacity.TabIndex = 6
        Me.L_Capacity.Text = "Size:"
        '
        'L_MediaType
        '
        Me.L_MediaType.AutoSize = True
        Me.L_MediaType.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_MediaType.Location = New System.Drawing.Point(3, 205)
        Me.L_MediaType.Name = "L_MediaType"
        Me.L_MediaType.Size = New System.Drawing.Size(84, 15)
        Me.L_MediaType.TabIndex = 5
        Me.L_MediaType.Text = "Media Type:"
        '
        'L_InterfaceType
        '
        Me.L_InterfaceType.AutoSize = True
        Me.L_InterfaceType.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_InterfaceType.Location = New System.Drawing.Point(10, 185)
        Me.L_InterfaceType.Name = "L_InterfaceType"
        Me.L_InterfaceType.Size = New System.Drawing.Size(77, 15)
        Me.L_InterfaceType.TabIndex = 4
        Me.L_InterfaceType.Text = "Interface:"
        '
        'L_Caption
        '
        Me.L_Caption.AutoSize = True
        Me.L_Caption.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Caption.Location = New System.Drawing.Point(38, 127)
        Me.L_Caption.Name = "L_Caption"
        Me.L_Caption.Size = New System.Drawing.Size(49, 15)
        Me.L_Caption.TabIndex = 3
        Me.L_Caption.Text = "Label:"
        '
        'L_Index
        '
        Me.L_Index.AutoSize = True
        Me.L_Index.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Index.Location = New System.Drawing.Point(38, 166)
        Me.L_Index.Name = "L_Index"
        Me.L_Index.Size = New System.Drawing.Size(49, 15)
        Me.L_Index.TabIndex = 2
        Me.L_Index.Text = "Index:"
        '
        'pb_CurrentDevice
        '
        Me.pb_CurrentDevice.Image = Global.DBUSB_Maker.My.Resources.Resources.Ico_NotFound
        Me.pb_CurrentDevice.Location = New System.Drawing.Point(77, 46)
        Me.pb_CurrentDevice.Name = "pb_CurrentDevice"
        Me.pb_CurrentDevice.Size = New System.Drawing.Size(64, 64)
        Me.pb_CurrentDevice.TabIndex = 1
        Me.pb_CurrentDevice.TabStop = False
        '
        'cob_RemovableDrives
        '
        Me.cob_RemovableDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cob_RemovableDrives.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cob_RemovableDrives.FormattingEnabled = True
        Me.cob_RemovableDrives.Location = New System.Drawing.Point(6, 19)
        Me.cob_RemovableDrives.Name = "cob_RemovableDrives"
        Me.cob_RemovableDrives.Size = New System.Drawing.Size(201, 21)
        Me.cob_RemovableDrives.TabIndex = 0
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MaximumSize = New System.Drawing.Size(233, 24)
        Me.MenuStrip.MinimumSize = New System.Drawing.Size(233, 24)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(233, 24)
        Me.MenuStrip.TabIndex = 4
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RescanDrivesToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'RescanDrivesToolStripMenuItem
        '
        Me.RescanDrivesToolStripMenuItem.Image = Global.DBUSB_Maker.My.Resources.Resources.Ico_Refresh
        Me.RescanDrivesToolStripMenuItem.Name = "RescanDrivesToolStripMenuItem"
        Me.RescanDrivesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RescanDrivesToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.RescanDrivesToolStripMenuItem.Text = "Rescan Drives"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.DBUSB_Maker.My.Resources.Resources.Ico_Exit
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.CheckOnClick = True
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllowDiskDrivesToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'AllowDiskDrivesToolStripMenuItem
        '
        Me.AllowDiskDrivesToolStripMenuItem.CheckOnClick = True
        Me.AllowDiskDrivesToolStripMenuItem.Name = "AllowDiskDrivesToolStripMenuItem"
        Me.AllowDiskDrivesToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AllowDiskDrivesToolStripMenuItem.Text = "Allow Disk Drives"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ManualToolStripMenuItem
        '
        Me.ManualToolStripMenuItem.Image = Global.DBUSB_Maker.My.Resources.Resources.Ico_Help
        Me.ManualToolStripMenuItem.Name = "ManualToolStripMenuItem"
        Me.ManualToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.ManualToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ManualToolStripMenuItem.Text = "Manual"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 521)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(209, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'cb_Format_AddFiles
        '
        Me.cb_Format_AddFiles.AutoSize = True
        Me.cb_Format_AddFiles.Location = New System.Drawing.Point(7, 113)
        Me.cb_Format_AddFiles.Name = "cb_Format_AddFiles"
        Me.cb_Format_AddFiles.Size = New System.Drawing.Size(177, 17)
        Me.cb_Format_AddFiles.TabIndex = 8
        Me.cb_Format_AddFiles.Text = "Add Basic Menus and Programs"
        Me.cb_Format_AddFiles.UseVisualStyleBackColor = True
        '
        'DBUSBMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(233, 583)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.gb_Devices)
        Me.Controls.Add(Me.gb_Qemu)
        Me.Controls.Add(Me.gb_Format)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(249, 622)
        Me.MinimumSize = New System.Drawing.Size(249, 622)
        Me.Name = "DBUSBMaker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USB Maker"
        Me.gb_Format.ResumeLayout(False)
        Me.gb_Format.PerformLayout()
        Me.gb_Qemu.ResumeLayout(False)
        Me.gb_Devices.ResumeLayout(False)
        Me.gb_Devices.PerformLayout()
        CType(Me.pb_CurrentDevice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents b_Qemu As Button
    Friend WithEvents gb_Format As GroupBox
    Friend WithEvents cob_Format_type As ComboBox
    Friend WithEvents cb_Format_USBZip As CheckBox
    Friend WithEvents cb_Format_CHS As CheckBox
    Friend WithEvents cb_Format_Align As CheckBox
    Friend WithEvents cb_Format_Repartition As CheckBox
    Friend WithEvents cb_Format_MBR As CheckBox
    Friend WithEvents b_FormatDrive As Button
    Friend WithEvents rb_ADFormat As RadioButton
    Friend WithEvents rb_EZFormat As RadioButton
    Friend WithEvents gb_Qemu As GroupBox
    Friend WithEvents gb_Devices As GroupBox
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RescanDrivesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllowDiskDrivesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pb_CurrentDevice As PictureBox
    Friend WithEvents cob_RemovableDrives As ComboBox
    Friend WithEvents L_Index As Label
    Friend WithEvents L_Capacity As Label
    Friend WithEvents L_MediaType As Label
    Friend WithEvents L_InterfaceType As Label
    Friend WithEvents L_Caption As Label
    Friend WithEvents L_DriveInterfaceType As Label
    Friend WithEvents L_DriveMediaType As Label
    Friend WithEvents L_DriveIndex As Label
    Friend WithEvents L_DriveSize As Label
    Friend WithEvents L_DriveLabel As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents L_DrivePartitions As Label
    Friend WithEvents L_Partitions As Label
    Friend WithEvents cb_Format_AddFiles As CheckBox
End Class
