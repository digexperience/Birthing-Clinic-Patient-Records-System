<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.BorderPanel = New System.Windows.Forms.Panel()
        Me.btnminimize = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnlogin = New Guna.UI2.WinForms.Guna2Button()
        Me.txtpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtusername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblcreate = New System.Windows.Forms.Label()
        Me.cbremember = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblforgot = New System.Windows.Forms.Label()
        Me.panelbutton = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnhelp = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btncontactus = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panellogin = New System.Windows.Forms.Panel()
        Me.BorderPanel.SuspendLayout()
        Me.panelbutton.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panellogin.SuspendLayout()
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
        Me.BorderPanel.Size = New System.Drawing.Size(564, 19)
        Me.BorderPanel.TabIndex = 12
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
        Me.btnminimize.Location = New System.Drawing.Point(524, 0)
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
        Me.btnclose.Location = New System.Drawing.Point(545, 0)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(19, 19)
        Me.btnclose.TabIndex = 13
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btnlogin
        '
        Me.btnlogin.Animated = True
        Me.btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.btnlogin.BorderColor = System.Drawing.Color.Transparent
        Me.btnlogin.BorderRadius = 5
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnlogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnlogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnlogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnlogin.FillColor = System.Drawing.Color.Lime
        Me.btnlogin.FocusedColor = System.Drawing.Color.Transparent
        Me.btnlogin.Font = New System.Drawing.Font("Segoe UI", 9.2!, System.Drawing.FontStyle.Bold)
        Me.btnlogin.ForeColor = System.Drawing.Color.DimGray
        Me.btnlogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlogin.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlogin.Location = New System.Drawing.Point(85, 157)
        Me.btnlogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.ShadowDecoration.BorderRadius = 5
        Me.btnlogin.ShadowDecoration.Color = System.Drawing.Color.ForestGreen
        Me.btnlogin.ShadowDecoration.Depth = 20
        Me.btnlogin.ShadowDecoration.Enabled = True
        Me.btnlogin.Size = New System.Drawing.Size(166, 30)
        Me.btnlogin.TabIndex = 3
        Me.btnlogin.Text = "Login"
        '
        'txtpassword
        '
        Me.txtpassword.AutoRoundedCorners = True
        Me.txtpassword.BackColor = System.Drawing.Color.Transparent
        Me.txtpassword.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtpassword.BorderRadius = 14
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassword.DefaultText = ""
        Me.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassword.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtpassword.FocusedState.BorderColor = System.Drawing.Color.White
        Me.txtpassword.Font = New System.Drawing.Font("Segoe UI", 9.2!)
        Me.txtpassword.ForeColor = System.Drawing.Color.Black
        Me.txtpassword.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.txtpassword.IconLeft = CType(resources.GetObject("txtpassword.IconLeft"), System.Drawing.Image)
        Me.txtpassword.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtpassword.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtpassword.IconRight = CType(resources.GetObject("txtpassword.IconRight"), System.Drawing.Image)
        Me.txtpassword.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtpassword.IconRightSize = New System.Drawing.Size(18, 18)
        Me.txtpassword.Location = New System.Drawing.Point(22, 100)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtpassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtpassword.PlaceholderText = "Password"
        Me.txtpassword.SelectedText = ""
        Me.txtpassword.ShadowDecoration.BorderRadius = 5
        Me.txtpassword.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.txtpassword.ShadowDecoration.Enabled = True
        Me.txtpassword.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
        Me.txtpassword.Size = New System.Drawing.Size(293, 30)
        Me.txtpassword.TabIndex = 2
        Me.txtpassword.TextOffset = New System.Drawing.Point(5, 0)
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'txtusername
        '
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
        Me.txtusername.IconLeft = CType(resources.GetObject("txtusername.IconLeft"), System.Drawing.Image)
        Me.txtusername.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtusername.IconLeftSize = New System.Drawing.Size(18, 18)
        Me.txtusername.IconRightSize = New System.Drawing.Size(18, 18)
        Me.txtusername.Location = New System.Drawing.Point(22, 65)
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
        Me.txtusername.Size = New System.Drawing.Size(293, 30)
        Me.txtusername.TabIndex = 1
        Me.txtusername.TextOffset = New System.Drawing.Point(5, 0)
        '
        'lblcreate
        '
        Me.lblcreate.AutoSize = True
        Me.lblcreate.BackColor = System.Drawing.Color.Transparent
        Me.lblcreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblcreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblcreate.Font = New System.Drawing.Font("Segoe UI", 9.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcreate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblcreate.Location = New System.Drawing.Point(105, 193)
        Me.lblcreate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcreate.Name = "lblcreate"
        Me.lblcreate.Size = New System.Drawing.Size(126, 17)
        Me.lblcreate.TabIndex = 6
        Me.lblcreate.Text = "Create New Account"
        '
        'cbremember
        '
        Me.cbremember.AutoSize = True
        Me.cbremember.BackColor = System.Drawing.Color.Transparent
        Me.cbremember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbremember.Font = New System.Drawing.Font("Segoe UI", 9.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbremember.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cbremember.Location = New System.Drawing.Point(22, 133)
        Me.cbremember.Margin = New System.Windows.Forms.Padding(2)
        Me.cbremember.Name = "cbremember"
        Me.cbremember.Size = New System.Drawing.Size(114, 21)
        Me.cbremember.TabIndex = 4
        Me.cbremember.Text = "Remember Me"
        Me.cbremember.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(124, 14)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Please Sign....."
        '
        'lblforgot
        '
        Me.lblforgot.AutoSize = True
        Me.lblforgot.BackColor = System.Drawing.Color.Transparent
        Me.lblforgot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblforgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblforgot.Font = New System.Drawing.Font("Segoe UI", 9.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblforgot.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblforgot.Location = New System.Drawing.Point(218, 133)
        Me.lblforgot.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblforgot.Name = "lblforgot"
        Me.lblforgot.Size = New System.Drawing.Size(113, 17)
        Me.lblforgot.TabIndex = 5
        Me.lblforgot.Text = "Forgot Password?"
        '
        'panelbutton
        '
        Me.panelbutton.BackColor = System.Drawing.Color.Transparent
        Me.panelbutton.Controls.Add(Me.Button5)
        Me.panelbutton.Controls.Add(Me.Button2)
        Me.panelbutton.Controls.Add(Me.btnhelp)
        Me.panelbutton.Controls.Add(Me.Button4)
        Me.panelbutton.Controls.Add(Me.btncontactus)
        Me.panelbutton.Location = New System.Drawing.Point(10, 403)
        Me.panelbutton.Margin = New System.Windows.Forms.Padding(2)
        Me.panelbutton.Name = "panelbutton"
        Me.panelbutton.Size = New System.Drawing.Size(542, 33)
        Me.panelbutton.TabIndex = 7
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button5.Location = New System.Drawing.Point(111, 2)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(106, 29)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Terms"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Location = New System.Drawing.Point(218, 2)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 29)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Privacy Policy"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnhelp
        '
        Me.btnhelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnhelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhelp.FlatAppearance.BorderSize = 0
        Me.btnhelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnhelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnhelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhelp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhelp.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnhelp.Location = New System.Drawing.Point(4, 2)
        Me.btnhelp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(106, 29)
        Me.btnhelp.TabIndex = 7
        Me.btnhelp.Text = "Help and Tips"
        Me.btnhelp.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button4.Location = New System.Drawing.Point(325, 2)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(106, 29)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "About"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btncontactus
        '
        Me.btncontactus.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncontactus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncontactus.FlatAppearance.BorderSize = 0
        Me.btncontactus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncontactus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncontactus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncontactus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncontactus.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btncontactus.Location = New System.Drawing.Point(432, 2)
        Me.btncontactus.Margin = New System.Windows.Forms.Padding(2)
        Me.btncontactus.Name = "btncontactus"
        Me.btncontactus.Size = New System.Drawing.Size(106, 29)
        Me.btncontactus.TabIndex = 11
        Me.btncontactus.Text = "Contact"
        Me.btncontactus.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(152, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(357, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Block 91 Lot 92 Barangay Cristo Rey Capas, Tarlac"
        '
        'Label4
        '
        Me.Label4.AllowDrop = True
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(149, 61)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 32)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "BIRTHING CLINIC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(148, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 41)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "FLORESCA"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Birthing_Clinic_Patient_Records_System.My.Resources.Resources.yellowgreen_picture
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(48, 27)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 84)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'panellogin
        '
        Me.panellogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.panellogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panellogin.Controls.Add(Me.btnlogin)
        Me.panellogin.Controls.Add(Me.txtpassword)
        Me.panellogin.Controls.Add(Me.txtusername)
        Me.panellogin.Controls.Add(Me.lblcreate)
        Me.panellogin.Controls.Add(Me.cbremember)
        Me.panellogin.Controls.Add(Me.Label5)
        Me.panellogin.Controls.Add(Me.lblforgot)
        Me.panellogin.Location = New System.Drawing.Point(118, 139)
        Me.panellogin.Margin = New System.Windows.Forms.Padding(2)
        Me.panellogin.Name = "panellogin"
        Me.panellogin.Size = New System.Drawing.Size(336, 224)
        Me.panellogin.TabIndex = 1
        '
        'frmlogin
        '
        Me.AcceptButton = Me.btnlogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImage = Global.Birthing_Clinic_Patient_Records_System.My.Resources.Resources.background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(564, 437)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.panelbutton)
        Me.Controls.Add(Me.panellogin)
        Me.Controls.Add(Me.BorderPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Floresca Birthing Clinic"
        Me.BorderPanel.ResumeLayout(False)
        Me.panelbutton.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panellogin.ResumeLayout(False)
        Me.panellogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BorderPanel As Panel
    Friend WithEvents btnclose As Button
    Friend WithEvents panelbutton As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btncontactus As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnhelp As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblforgot As Label
    Friend WithEvents cbremember As CheckBox
    Friend WithEvents lblcreate As Label
    Friend WithEvents txtusername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnlogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnminimize As Button
    Friend WithEvents panellogin As Panel
End Class
