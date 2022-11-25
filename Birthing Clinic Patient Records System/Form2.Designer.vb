<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmregistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmregistration))
        Me.BorderPanel = New System.Windows.Forms.Panel()
        Me.btnminimize = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.txtconfirmpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblsignin = New System.Windows.Forms.Label()
        Me.txtnewpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtfirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnsignup = New Guna.UI2.WinForms.Guna2Button()
        Me.txtusername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblwarning = New System.Windows.Forms.Label()
        Me.cbusertype = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtlastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PanelRegistration = New Guna.UI2.WinForms.Guna2Panel()
        Me.BorderPanel.SuspendLayout()
        Me.PanelRegistration.SuspendLayout()
        Me.SuspendLayout()
        '
        'BorderPanel
        '
        Me.BorderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BorderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BorderPanel.Controls.Add(Me.btnminimize)
        Me.BorderPanel.Controls.Add(Me.btnclose)
        Me.BorderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.BorderPanel.Location = New System.Drawing.Point(0, 0)
        Me.BorderPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.BorderPanel.Name = "BorderPanel"
        Me.BorderPanel.Size = New System.Drawing.Size(368, 19)
        Me.BorderPanel.TabIndex = 13
        '
        'btnminimize
        '
        Me.btnminimize.BackColor = System.Drawing.Color.Transparent
        Me.btnminimize.BackgroundImage = CType(resources.GetObject("btnminimize.BackgroundImage"), System.Drawing.Image)
        Me.btnminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnminimize.FlatAppearance.BorderSize = 0
        Me.btnminimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnminimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimize.Font = New System.Drawing.Font("Berlin Sans FB", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnminimize.ForeColor = System.Drawing.Color.Black
        Me.btnminimize.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnminimize.Location = New System.Drawing.Point(325, 2)
        Me.btnminimize.Margin = New System.Windows.Forms.Padding(2)
        Me.btnminimize.Name = "btnminimize"
        Me.btnminimize.Size = New System.Drawing.Size(19, 19)
        Me.btnminimize.TabIndex = 12
        Me.btnminimize.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.BackgroundImage = CType(resources.GetObject("btnclose.BackgroundImage"), System.Drawing.Image)
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Berlin Sans FB", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.Black
        Me.btnclose.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnclose.Location = New System.Drawing.Point(347, 2)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(19, 19)
        Me.btnclose.TabIndex = 13
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbltitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbltitle.Location = New System.Drawing.Point(21, 10)
        Me.lbltitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(83, 25)
        Me.lbltitle.TabIndex = 10
        Me.lbltitle.Text = "Sign Up"
        '
        'txtconfirmpassword
        '
        Me.txtconfirmpassword.Animated = True
        Me.txtconfirmpassword.AutoRoundedCorners = True
        Me.txtconfirmpassword.BackColor = System.Drawing.Color.Transparent
        Me.txtconfirmpassword.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtconfirmpassword.BorderRadius = 14
        Me.txtconfirmpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtconfirmpassword.DefaultText = ""
        Me.txtconfirmpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtconfirmpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtconfirmpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtconfirmpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtconfirmpassword.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtconfirmpassword.FocusedState.BorderColor = System.Drawing.Color.White
        Me.txtconfirmpassword.Font = New System.Drawing.Font("Segoe UI", 9.2!)
        Me.txtconfirmpassword.ForeColor = System.Drawing.Color.Black
        Me.txtconfirmpassword.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtconfirmpassword.IconLeft = Global.Birthing_Clinic_Patient_Records_System.My.Resources.Resources.iconpadlock
        Me.txtconfirmpassword.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtconfirmpassword.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtconfirmpassword.IconRight = Global.Birthing_Clinic_Patient_Records_System.My.Resources.Resources.iconinvisible
        Me.txtconfirmpassword.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtconfirmpassword.IconRightSize = New System.Drawing.Size(18, 18)
        Me.txtconfirmpassword.Location = New System.Drawing.Point(23, 161)
        Me.txtconfirmpassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtconfirmpassword.Name = "txtconfirmpassword"
        Me.txtconfirmpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtconfirmpassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtconfirmpassword.PlaceholderText = "Confirm Password"
        Me.txtconfirmpassword.SelectedText = ""
        Me.txtconfirmpassword.ShadowDecoration.BorderRadius = 5
        Me.txtconfirmpassword.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtconfirmpassword.ShadowDecoration.Enabled = True
        Me.txtconfirmpassword.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
        Me.txtconfirmpassword.Size = New System.Drawing.Size(324, 30)
        Me.txtconfirmpassword.TabIndex = 5
        Me.txtconfirmpassword.TextOffset = New System.Drawing.Point(5, 0)
        Me.txtconfirmpassword.UseSystemPasswordChar = True
        '
        'lblsignin
        '
        Me.lblsignin.AutoSize = True
        Me.lblsignin.BackColor = System.Drawing.Color.Transparent
        Me.lblsignin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblsignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblsignin.Font = New System.Drawing.Font("Segoe UI", 9.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsignin.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblsignin.Location = New System.Drawing.Point(139, 278)
        Me.lblsignin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblsignin.Name = "lblsignin"
        Me.lblsignin.Size = New System.Drawing.Size(93, 17)
        Me.lblsignin.TabIndex = 8
        Me.lblsignin.Text = "Sign in instead"
        '
        'txtnewpassword
        '
        Me.txtnewpassword.Animated = True
        Me.txtnewpassword.AutoRoundedCorners = True
        Me.txtnewpassword.BackColor = System.Drawing.Color.Transparent
        Me.txtnewpassword.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtnewpassword.BorderRadius = 14
        Me.txtnewpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnewpassword.DefaultText = ""
        Me.txtnewpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtnewpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtnewpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnewpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnewpassword.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtnewpassword.FocusedState.BorderColor = System.Drawing.Color.White
        Me.txtnewpassword.Font = New System.Drawing.Font("Segoe UI", 9.2!)
        Me.txtnewpassword.ForeColor = System.Drawing.Color.Black
        Me.txtnewpassword.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtnewpassword.IconLeft = Global.Birthing_Clinic_Patient_Records_System.My.Resources.Resources.iconpadlock
        Me.txtnewpassword.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtnewpassword.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtnewpassword.IconRight = Global.Birthing_Clinic_Patient_Records_System.My.Resources.Resources.iconinvisible
        Me.txtnewpassword.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtnewpassword.IconRightSize = New System.Drawing.Size(18, 18)
        Me.txtnewpassword.Location = New System.Drawing.Point(23, 127)
        Me.txtnewpassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnewpassword.Name = "txtnewpassword"
        Me.txtnewpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtnewpassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtnewpassword.PlaceholderText = "New Password"
        Me.txtnewpassword.SelectedText = ""
        Me.txtnewpassword.ShadowDecoration.BorderRadius = 5
        Me.txtnewpassword.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtnewpassword.ShadowDecoration.Enabled = True
        Me.txtnewpassword.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
        Me.txtnewpassword.Size = New System.Drawing.Size(324, 30)
        Me.txtnewpassword.TabIndex = 4
        Me.txtnewpassword.TextOffset = New System.Drawing.Point(5, 0)
        Me.txtnewpassword.UseSystemPasswordChar = True
        '
        'txtfirstname
        '
        Me.txtfirstname.Animated = True
        Me.txtfirstname.AutoRoundedCorners = True
        Me.txtfirstname.BackColor = System.Drawing.Color.Transparent
        Me.txtfirstname.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtfirstname.BorderRadius = 14
        Me.txtfirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfirstname.CustomizableEdges.BottomLeft = False
        Me.txtfirstname.CustomizableEdges.TopLeft = False
        Me.txtfirstname.DefaultText = ""
        Me.txtfirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtfirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtfirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfirstname.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtfirstname.FocusedState.BorderColor = System.Drawing.Color.White
        Me.txtfirstname.Font = New System.Drawing.Font("Segoe UI", 9.2!)
        Me.txtfirstname.ForeColor = System.Drawing.Color.Black
        Me.txtfirstname.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtfirstname.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtfirstname.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtfirstname.IconRightSize = New System.Drawing.Size(18, 18)
        Me.txtfirstname.Location = New System.Drawing.Point(187, 59)
        Me.txtfirstname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfirstname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtfirstname.PlaceholderText = "Firstname"
        Me.txtfirstname.SelectedText = ""
        Me.txtfirstname.ShadowDecoration.BorderRadius = 5
        Me.txtfirstname.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtfirstname.ShadowDecoration.Enabled = True
        Me.txtfirstname.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
        Me.txtfirstname.Size = New System.Drawing.Size(160, 30)
        Me.txtfirstname.TabIndex = 2
        Me.txtfirstname.TextOffset = New System.Drawing.Point(5, 0)
        '
        'btnsignup
        '
        Me.btnsignup.Animated = True
        Me.btnsignup.BackColor = System.Drawing.Color.Transparent
        Me.btnsignup.BorderColor = System.Drawing.Color.Transparent
        Me.btnsignup.BorderRadius = 5
        Me.btnsignup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsignup.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsignup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsignup.FillColor = System.Drawing.Color.Lime
        Me.btnsignup.FocusedColor = System.Drawing.Color.Transparent
        Me.btnsignup.Font = New System.Drawing.Font("Segoe UI", 9.2!, System.Drawing.FontStyle.Bold)
        Me.btnsignup.ForeColor = System.Drawing.Color.DimGray
        Me.btnsignup.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsignup.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsignup.Location = New System.Drawing.Point(101, 242)
        Me.btnsignup.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsignup.Name = "btnsignup"
        Me.btnsignup.ShadowDecoration.BorderRadius = 5
        Me.btnsignup.ShadowDecoration.Color = System.Drawing.Color.ForestGreen
        Me.btnsignup.ShadowDecoration.Depth = 20
        Me.btnsignup.ShadowDecoration.Enabled = True
        Me.btnsignup.Size = New System.Drawing.Size(166, 30)
        Me.btnsignup.TabIndex = 7
        Me.btnsignup.Text = "Sign up"
        '
        'txtusername
        '
        Me.txtusername.Animated = True
        Me.txtusername.AutoRoundedCorners = True
        Me.txtusername.BackColor = System.Drawing.Color.Transparent
        Me.txtusername.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtusername.BorderRadius = 14
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusername.DefaultText = ""
        Me.txtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtusername.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtusername.FocusedState.BorderColor = System.Drawing.Color.White
        Me.txtusername.Font = New System.Drawing.Font("Segoe UI", 9.2!)
        Me.txtusername.ForeColor = System.Drawing.Color.Black
        Me.txtusername.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtusername.IconLeft = Global.Birthing_Clinic_Patient_Records_System.My.Resources.Resources.iconuser
        Me.txtusername.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtusername.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtusername.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtusername.IconRightSize = New System.Drawing.Size(18, 18)
        Me.txtusername.Location = New System.Drawing.Point(23, 93)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtusername.PlaceholderText = "Username"
        Me.txtusername.SelectedText = ""
        Me.txtusername.ShadowDecoration.BorderRadius = 5
        Me.txtusername.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtusername.ShadowDecoration.Enabled = True
        Me.txtusername.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
        Me.txtusername.Size = New System.Drawing.Size(324, 30)
        Me.txtusername.TabIndex = 3
        Me.txtusername.TextOffset = New System.Drawing.Point(5, 0)
        '
        'lblwarning
        '
        Me.lblwarning.AutoSize = True
        Me.lblwarning.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwarning.ForeColor = System.Drawing.Color.Red
        Me.lblwarning.Location = New System.Drawing.Point(38, 41)
        Me.lblwarning.Name = "lblwarning"
        Me.lblwarning.Size = New System.Drawing.Size(0, 15)
        Me.lblwarning.TabIndex = 22
        '
        'cbusertype
        '
        Me.cbusertype.AutoCompleteCustomSource.AddRange(New String() {"Admin", "Doctor", "Staff"})
        Me.cbusertype.BackColor = System.Drawing.Color.Transparent
        Me.cbusertype.BorderRadius = 14
        Me.cbusertype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbusertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbusertype.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbusertype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbusertype.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbusertype.ForeColor = System.Drawing.Color.Black
        Me.cbusertype.ItemHeight = 24
        Me.cbusertype.Items.AddRange(New Object() {"Admin", "Doctor", "Staff"})
        Me.cbusertype.Location = New System.Drawing.Point(23, 195)
        Me.cbusertype.Name = "cbusertype"
        Me.cbusertype.Size = New System.Drawing.Size(324, 30)
        Me.cbusertype.TabIndex = 6
        '
        'txtlastname
        '
        Me.txtlastname.Animated = True
        Me.txtlastname.AutoRoundedCorners = True
        Me.txtlastname.BackColor = System.Drawing.Color.Transparent
        Me.txtlastname.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtlastname.BorderRadius = 14
        Me.txtlastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlastname.CustomizableEdges.BottomRight = False
        Me.txtlastname.CustomizableEdges.TopRight = False
        Me.txtlastname.DefaultText = ""
        Me.txtlastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtlastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtlastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlastname.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtlastname.FocusedState.BorderColor = System.Drawing.Color.White
        Me.txtlastname.Font = New System.Drawing.Font("Segoe UI", 9.2!)
        Me.txtlastname.ForeColor = System.Drawing.Color.Black
        Me.txtlastname.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtlastname.IconLeft = CType(resources.GetObject("txtlastname.IconLeft"), System.Drawing.Image)
        Me.txtlastname.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtlastname.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtlastname.IconRightSize = New System.Drawing.Size(18, 18)
        Me.txtlastname.Location = New System.Drawing.Point(23, 59)
        Me.txtlastname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlastname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtlastname.PlaceholderText = "Lastname"
        Me.txtlastname.SelectedText = ""
        Me.txtlastname.ShadowDecoration.BorderRadius = 5
        Me.txtlastname.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtlastname.ShadowDecoration.Enabled = True
        Me.txtlastname.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
        Me.txtlastname.Size = New System.Drawing.Size(160, 30)
        Me.txtlastname.TabIndex = 1
        Me.txtlastname.TextOffset = New System.Drawing.Point(5, 0)
        '
        'PanelRegistration
        '
        Me.PanelRegistration.BackColor = System.Drawing.Color.Transparent
        Me.PanelRegistration.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelRegistration.BorderRadius = 5
        Me.PanelRegistration.BorderThickness = 1
        Me.PanelRegistration.Controls.Add(Me.txtlastname)
        Me.PanelRegistration.Controls.Add(Me.cbusertype)
        Me.PanelRegistration.Controls.Add(Me.lblwarning)
        Me.PanelRegistration.Controls.Add(Me.txtusername)
        Me.PanelRegistration.Controls.Add(Me.btnsignup)
        Me.PanelRegistration.Controls.Add(Me.txtfirstname)
        Me.PanelRegistration.Controls.Add(Me.txtnewpassword)
        Me.PanelRegistration.Controls.Add(Me.lblsignin)
        Me.PanelRegistration.Controls.Add(Me.txtconfirmpassword)
        Me.PanelRegistration.Controls.Add(Me.lbltitle)
        Me.PanelRegistration.Location = New System.Drawing.Point(0, 19)
        Me.PanelRegistration.Name = "PanelRegistration"
        Me.PanelRegistration.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelRegistration.ShadowDecoration.Depth = 1
        Me.PanelRegistration.ShadowDecoration.Enabled = True
        Me.PanelRegistration.Size = New System.Drawing.Size(368, 302)
        Me.PanelRegistration.TabIndex = 1
        '
        'frmregistration
        '
        Me.AcceptButton = Me.btnsignup
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Birthing_Clinic_Patient_Records_System.My.Resources.Resources.background1
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(368, 321)
        Me.Controls.Add(Me.PanelRegistration)
        Me.Controls.Add(Me.BorderPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmregistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Floresca Birthing Clinic Registration"
        Me.BorderPanel.ResumeLayout(False)
        Me.PanelRegistration.ResumeLayout(False)
        Me.PanelRegistration.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BorderPanel As Panel
    Friend WithEvents btnminimize As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents lbltitle As Label
    Friend WithEvents txtconfirmpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblsignin As Label
    Friend WithEvents txtnewpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtfirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnsignup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtusername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblwarning As Label
    Friend WithEvents cbusertype As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtlastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PanelRegistration As Guna.UI2.WinForms.Guna2Panel
End Class
