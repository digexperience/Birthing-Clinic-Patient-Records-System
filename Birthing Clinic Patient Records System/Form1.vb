Imports System.Windows.Media
Imports System.Data.OleDb
Imports System.Text
Imports System.Security.Cryptography
Imports System.Security.Policy

Public Class frmlogin
    Private Const SaltSize As Integer = 31
    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point

    Dim newFont As New Font("Segoe UI", 9.2, FontStyle.Underline)
    Dim newFont2 As New Font("Segoe UI", 9.2)
    Dim ByteHash() As Byte
    Dim ByteSourceText() As Byte
    Dim userLC As String
    Dim passLC As String
    Dim rSalt = CreateNewSalt(SaltSize)

    Private Sub BorderPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles BorderPanel.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.Default
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Private Sub BorderPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles BorderPanel.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub BorderPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles BorderPanel.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Private Sub Cornerbutton(btn As Button)
        Dim leftcorner As New Drawing2D.GraphicsPath
        Dim rightcorner As New Drawing2D.GraphicsPath

        leftcorner.StartFigure()
        rightcorner.StartFigure()

        leftcorner.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        leftcorner.AddLine(btnhelp.Width, 0, btn.Width, btn.Height)
        leftcorner.AddLine(btn.Width, btn.Width, 0, btn.Height)

        rightcorner.AddArc(New Rectangle(btncontactus.Width - 20, 0, 20, 20), -90, 90)
        rightcorner.AddLine(btn.Width, btn.Width, -btn.Width, -btn.Height)

        leftcorner.CloseFigure()
        rightcorner.CloseFigure()

        btnhelp.Region = New Region(leftcorner)
        btncontactus.Region = New Region(rightcorner)

    End Sub

    'Private Sub CornerTextbox(txt As TextBox)
    '    Dim leftcorner As New Drawing2D.GraphicsPath
    '    Dim rightcorner As New Drawing2D.GraphicsPath

    '    leftcorner.StartFigure()
    '    rightcorner.StartFigure()

    '    leftcorner.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
    '    leftcorner.AddLine(btnhelp.Width, 0, txt.Width, btn.Height)
    '    leftcorner.AddLine(btn.Width, txt.Width, 0, txt.Height)

    '    rightcorner.AddArc(New Rectangle(btncontactus.Width - 20, 0, 20, 20), -90, 90)
    '    rightcorner.AddLine(btn.Width, txt.Width, -txt.Width, -txt.Height)

    '    leftcorner.CloseFigure()
    '    rightcorner.CloseFigure()

    '    txt.Region = New Region(leftcorner)
    '    btncontactus.Region = New Region(rightcorner)
    'End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cornerbutton(btncontactus)
    End Sub

    Private Sub lblforgot_MouseLeave(sender As Object, e As EventArgs) Handles lblforgot.MouseLeave
        lblforgot.Font = newFont2
        lblforgot.ForeColor = System.Drawing.Color.WhiteSmoke
    End Sub

    Private Sub cbremember_MouseLeave(sender As Object, e As EventArgs) Handles cbremember.MouseLeave
        cbremember.Font = newFont2
        cbremember.ForeColor = System.Drawing.Color.WhiteSmoke
    End Sub

    Private Sub lblcreate_MouseLeave(sender As Object, e As EventArgs) Handles lblcreate.MouseLeave
        lblcreate.Font = newFont2
        lblcreate.ForeColor = System.Drawing.Color.WhiteSmoke
    End Sub

    Private Sub lblfogot_MouseHover(sender As Object, e As EventArgs) Handles lblforgot.MouseHover
        lblforgot.Font = newFont
        lblforgot.ForeColor = System.Drawing.Color.Silver
    End Sub

    Private Sub cbremember_MouseHover(sender As Object, e As EventArgs) Handles cbremember.MouseHover
        cbremember.Font = newFont
        cbremember.ForeColor = System.Drawing.Color.Silver
    End Sub

    Private Sub lblcreate_MouseHover(sender As Object, e As EventArgs) Handles lblcreate.MouseHover
        lblcreate.Font = newFont
        lblcreate.ForeColor = System.Drawing.Color.Silver
    End Sub
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        For disappear As Single = 1.0 To 0 Step -0.2
            Me.Opacity = disappear
            System.Threading.Thread.Sleep(50)
        Next
        Me.Opacity = 1.0
        Me.Close()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click

        For disappear As Single = 1.0 To 0 Step -0.2
            Me.Opacity = disappear
            System.Threading.Thread.Sleep(50)
        Next
        Me.Opacity = 1.0
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lblcreate_MouseUp(sender As Object, e As MouseEventArgs) Handles lblcreate.MouseUp
        lblcreate.ForeColor = System.Drawing.Color.Silver
    End Sub

    Private Sub lblforgot_MouseUp(sender As Object, e As MouseEventArgs) Handles lblforgot.MouseUp
        lblforgot.ForeColor = System.Drawing.Color.Silver
    End Sub

    Private Sub cbremember_MouseUp(sender As Object, e As MouseEventArgs) Handles cbremember.MouseUp
        cbremember.ForeColor = System.Drawing.Color.Silver
    End Sub

    Private Sub lblcreate_MouseDown(sender As Object, e As MouseEventArgs) Handles lblcreate.MouseDown
        lblcreate.ForeColor = System.Drawing.Color.White
    End Sub

    Private Sub lblforgot_MouseDown(sender As Object, e As MouseEventArgs) Handles lblforgot.MouseDown
        lblforgot.ForeColor = System.Drawing.Color.White
    End Sub

    Private Sub cbremember_MouseDown(sender As Object, e As MouseEventArgs) Handles cbremember.MouseDown
        cbremember.ForeColor = System.Drawing.Color.White
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        userLC = txtusername.Text.ToLowerInvariant
        passLC = txtpassword.Text.ToLowerInvariant
        Dim strPass As String
        Dim strUser As String
        Dim access As Boolean

        Using hasher As MD5 = MD5.Create()
            Dim dbytes1 As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(userLC))
            strUser = Convert.ToBase64String(dbytes1)
        End Using

        openCon()
        sql = "Select username,password from tbl_accounts"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader()

        Do While dr.Read() = True
            Dim split = dr("password").split(":")
            Using hasher As MD5 = MD5.Create()
                Dim check As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(passLC & split(0)))
                strPass = Convert.ToBase64String(check)
            End Using

            If strUser = dr("username") And strPass = split(1) Then
                frmmain.ShowDialog(Me)
                access = True
                Exit Do
            End If
        Loop
        dr.Close()
        cn.Close()
        If access = False Then
            Label5.Text = "Wrong Username or Password!, Invalid Account"
        End If
    End Sub

    Private Sub txtpassword_IconRightClick(sender As Object, e As EventArgs) Handles txtpassword.IconRightClick

        If txtpassword.UseSystemPasswordChar = True Then
            txtpassword.UseSystemPasswordChar = False
            txtpassword.PasswordChar = ""
            txtpassword.IconRight = My.Resources.iconvisible
        ElseIf txtpassword.UseSystemPasswordChar = False Then
            txtpassword.UseSystemPasswordChar = True
            txtpassword.PasswordChar = "●"
            txtpassword.IconRight = My.Resources.iconinvisible
        End If
    End Sub

    Private Function CreateNewSalt(SaltSize As Integer) As String

        Using rng As New RNGCryptoServiceProvider
            Dim data(If(SaltSize < 7, 7, SaltSize)) As Byte
            rng.GetBytes(data)
            Return Convert.ToBase64String(data)
        End Using
    End Function

    Private Sub lblcreate_Click(sender As Object, e As EventArgs) Handles lblcreate.Click
        Me.Opacity = 0.6
        Me.Enabled = False
        frmregistration.ShowDialog(Me)
    End Sub

End Class
