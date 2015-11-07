<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DBSUBMaker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
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
        Me.gr_GRUBEditor = New System.Windows.Forms.GroupBox()
        Me.TabControl_GRUB = New System.Windows.Forms.TabControl()
        Me.Menus = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gb_Format.SuspendLayout()
        Me.gb_Qemu.SuspendLayout()
        Me.gb_Devices.SuspendLayout()
        CType(Me.pb_CurrentDevice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.gr_GRUBEditor.SuspendLayout()
        Me.TabControl_GRUB.SuspendLayout()
        Me.SuspendLayout()
        '
        'b_Qemu
        '
        Me.b_Qemu.Location = New System.Drawing.Point(6, 19)
        Me.b_Qemu.Name = "b_Qemu"
        Me.b_Qemu.Size = New System.Drawing.Size(202, 23)
        Me.b_Qemu.TabIndex = 0
        Me.b_Qemu.Text = "Run on Virtual Machine"
        Me.b_Qemu.UseVisualStyleBackColor = True
        '
        'gb_Format
        '
        Me.gb_Format.Controls.Add(Me.cob_Format_type)
        Me.gb_Format.Controls.Add(Me.cb_Format_USBZip)
        Me.gb_Format.Controls.Add(Me.cb_Format_CHS)
        Me.gb_Format.Controls.Add(Me.cb_Format_Align)
        Me.gb_Format.Controls.Add(Me.cb_Format_Repartition)
        Me.gb_Format.Controls.Add(Me.cb_Format_MBR)
        Me.gb_Format.Controls.Add(Me.b_FormatDrive)
        Me.gb_Format.Controls.Add(Me.rb_ADFormat)
        Me.gb_Format.Controls.Add(Me.rb_EZFormat)
        Me.gb_Format.Location = New System.Drawing.Point(12, 305)
        Me.gb_Format.Name = "gb_Format"
        Me.gb_Format.Size = New System.Drawing.Size(214, 145)
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
        Me.b_FormatDrive.Location = New System.Drawing.Point(6, 112)
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
        Me.gb_Qemu.Location = New System.Drawing.Point(12, 249)
        Me.gb_Qemu.Name = "gb_Qemu"
        Me.gb_Qemu.Size = New System.Drawing.Size(214, 50)
        Me.gb_Qemu.TabIndex = 2
        Me.gb_Qemu.TabStop = False
        Me.gb_Qemu.Text = "QEMU"
        '
        'gb_Devices
        '
        Me.gb_Devices.Controls.Add(Me.pb_CurrentDevice)
        Me.gb_Devices.Controls.Add(Me.cob_RemovableDrives)
        Me.gb_Devices.Location = New System.Drawing.Point(12, 35)
        Me.gb_Devices.Name = "gb_Devices"
        Me.gb_Devices.Size = New System.Drawing.Size(214, 208)
        Me.gb_Devices.TabIndex = 3
        Me.gb_Devices.TabStop = False
        Me.gb_Devices.Text = "Device Selector"
        '
        'pb_CurrentDevice
        '
        Me.pb_CurrentDevice.Location = New System.Drawing.Point(6, 46)
        Me.pb_CurrentDevice.Name = "pb_CurrentDevice"
        Me.pb_CurrentDevice.Size = New System.Drawing.Size(201, 156)
        Me.pb_CurrentDevice.TabIndex = 1
        Me.pb_CurrentDevice.TabStop = False
        '
        'cob_RemovableDrives
        '
        Me.cob_RemovableDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
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
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(849, 24)
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
        Me.RescanDrivesToolStripMenuItem.Name = "RescanDrivesToolStripMenuItem"
        Me.RescanDrivesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RescanDrivesToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.RescanDrivesToolStripMenuItem.Text = "Rescan Drives"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllowDiskDrivesToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'AllowDiskDrivesToolStripMenuItem
        '
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
        Me.ManualToolStripMenuItem.Name = "ManualToolStripMenuItem"
        Me.ManualToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.ManualToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ManualToolStripMenuItem.Text = "Manual"
        '
        'gr_GRUBEditor
        '
        Me.gr_GRUBEditor.Controls.Add(Me.Button1)
        Me.gr_GRUBEditor.Controls.Add(Me.TabControl_GRUB)
        Me.gr_GRUBEditor.Location = New System.Drawing.Point(233, 35)
        Me.gr_GRUBEditor.Name = "gr_GRUBEditor"
        Me.gr_GRUBEditor.Size = New System.Drawing.Size(604, 415)
        Me.gr_GRUBEditor.TabIndex = 5
        Me.gr_GRUBEditor.TabStop = False
        Me.gr_GRUBEditor.Text = "GRUB Menu Editor"
        '
        'TabControl_GRUB
        '
        Me.TabControl_GRUB.Controls.Add(Me.Menus)
        Me.TabControl_GRUB.Controls.Add(Me.TabPage2)
        Me.TabControl_GRUB.Location = New System.Drawing.Point(6, 214)
        Me.TabControl_GRUB.Name = "TabControl_GRUB"
        Me.TabControl_GRUB.SelectedIndex = 0
        Me.TabControl_GRUB.Size = New System.Drawing.Size(583, 191)
        Me.TabControl_GRUB.TabIndex = 0
        '
        'Menus
        '
        Me.Menus.Location = New System.Drawing.Point(4, 22)
        Me.Menus.Name = "Menus"
        Me.Menus.Padding = New System.Windows.Forms.Padding(3)
        Me.Menus.Size = New System.Drawing.Size(575, 165)
        Me.Menus.TabIndex = 0
        Me.Menus.Text = "Menus"
        Me.Menus.ToolTipText = "Collection of menus present on the current device."
        Me.Menus.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(575, 165)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Color Editor"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(130, 127)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DBSUBMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 462)
        Me.Controls.Add(Me.gr_GRUBEditor)
        Me.Controls.Add(Me.gb_Devices)
        Me.Controls.Add(Me.gb_Qemu)
        Me.Controls.Add(Me.gb_Format)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "DBSUBMaker"
        Me.Text = "DBSUBMaker"
        Me.gb_Format.ResumeLayout(False)
        Me.gb_Format.PerformLayout()
        Me.gb_Qemu.ResumeLayout(False)
        Me.gb_Devices.ResumeLayout(False)
        CType(Me.pb_CurrentDevice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.gr_GRUBEditor.ResumeLayout(False)
        Me.TabControl_GRUB.ResumeLayout(False)
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
    Friend WithEvents gr_GRUBEditor As GroupBox
    Friend WithEvents TabControl_GRUB As TabControl
    Friend WithEvents Menus As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents pb_CurrentDevice As PictureBox
    Friend WithEvents cob_RemovableDrives As ComboBox
    Friend WithEvents Button1 As Button
End Class
