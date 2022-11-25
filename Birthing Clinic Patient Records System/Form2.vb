Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Imports Guna.UI2.WinForms
Imports Microsoft.VisualBasic.ApplicationServices

Public Class frmregistration
    Private Const SaltSize As Integer = 31
    Dim cbfill As Boolean = True
    Dim userLC As String
    Dim passLC As String
    Dim rSalt = CreateNewSalt(SaltSize)
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        For disappear As Single = 1.0 To 0 Step -0.2
            Me.Opacity = disappear
            System.Threading.Thread.Sleep(50)
        Next
        Me.Opacity = 1.0
        Me.Close()
        frmlogin.Opacity = 1.0
        frmlogin.Enabled = True
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click

        For disappear As Single = 1.0 To 0 Step -0.2
            Me.Opacity = disappear
            frmlogin.Opacity = disappear
            System.Threading.Thread.Sleep(50)
        Next
        Me.Opacity = 1.0
        Me.WindowState = FormWindowState.Minimized
        frmlogin.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub txtlastname_MouseDown(sender As Object, e As MouseEventArgs) Handles txtlastname.MouseDown
        If txtlastname.BorderColor = System.Drawing.Color.Red Then
            txtlastname.BorderColor = System.Drawing.Color.WhiteSmoke
            txtlastname.BorderThickness = 1
        End If
    End Sub

    Private Sub txtfirstname_MouseDown(sender As Object, e As MouseEventArgs) Handles txtfirstname.MouseDown
        If txtfirstname.BorderColor = System.Drawing.Color.Red Then
            txtfirstname.BorderColor = System.Drawing.Color.WhiteSmoke
            txtfirstname.BorderThickness = 1
        End If
    End Sub

    Private Sub txtusername_MouseDown(sender As Object, e As MouseEventArgs) Handles txtusername.MouseDown
        If txtusername.BorderColor = System.Drawing.Color.Red Then
            txtusername.BorderColor = System.Drawing.Color.WhiteSmoke
            txtusername.BorderThickness = 1
        End If
    End Sub

    Private Sub txtnewpassword_MouseDown(sender As Object, e As MouseEventArgs) Handles txtnewpassword.MouseDown
        If txtnewpassword.BorderColor = System.Drawing.Color.Red Then
            txtnewpassword.BorderColor = System.Drawing.Color.WhiteSmoke
            txtnewpassword.BorderThickness = 1
        End If
    End Sub

    Private Sub txtconfirmpassword_MouseDown(sender As Object, e As MouseEventArgs) Handles txtconfirmpassword.MouseDown
        If txtconfirmpassword.BorderColor = System.Drawing.Color.Red Then
            txtconfirmpassword.BorderColor = System.Drawing.Color.WhiteSmoke
            txtconfirmpassword.BorderThickness = 1
        End If
    End Sub

    Private Sub cbusertype_Click(sender As Object, e As MouseEventArgs) Handles cbusertype.Click
        If cbusertype.BorderColor = System.Drawing.Color.Red Then
            cbusertype.BorderColor = System.Drawing.Color.WhiteSmoke
            cbusertype.BorderThickness = 1
        End If
    End Sub

    Private Sub txtlastname_Enter(sender As Object, e As EventArgs) Handles txtlastname.Enter
        If txtlastname.BorderColor = System.Drawing.Color.Red Then
            txtlastname.BorderColor = System.Drawing.Color.WhiteSmoke
            txtlastname.BorderThickness = 1
        End If
    End Sub

    Private Sub txtfirstname_Enter(sender As Object, e As EventArgs) Handles txtfirstname.Enter
        If txtfirstname.BorderColor = System.Drawing.Color.Red Then
            txtfirstname.BorderColor = System.Drawing.Color.WhiteSmoke
            txtfirstname.BorderThickness = 1
        End If
    End Sub

    Private Sub txtusername_Enter(sender As Object, e As EventArgs) Handles txtusername.Enter
        If txtusername.BorderColor = System.Drawing.Color.Red Then
            txtusername.BorderColor = System.Drawing.Color.WhiteSmoke
            txtusername.BorderThickness = 1
        End If
    End Sub

    Private Sub txtnewpassword_Enter(sender As Object, e As EventArgs) Handles txtnewpassword.Enter
        If txtnewpassword.BorderColor = System.Drawing.Color.Red Then
            txtnewpassword.BorderColor = System.Drawing.Color.WhiteSmoke
            txtnewpassword.BorderThickness = 1
        End If
    End Sub

    Private Sub txtconfirmpassword_Enter(sender As Object, e As EventArgs) Handles txtconfirmpassword.Enter
        If txtconfirmpassword.BorderColor = System.Drawing.Color.Red Then
            txtconfirmpassword.BorderColor = System.Drawing.Color.WhiteSmoke
            txtconfirmpassword.BorderThickness = 1
        End If
    End Sub

    Private Sub cbusertype_Enter(sender As Object, e As EventArgs) Handles cbusertype.Enter
        If cbusertype.BorderColor = System.Drawing.Color.Red Then
            cbusertype.BorderColor = System.Drawing.Color.WhiteSmoke
            cbusertype.BorderThickness = 1
        End If
    End Sub

    Private Sub lblsignin_Click(sender As Object, e As EventArgs) Handles lblsignin.Click

        Me.Close()
        frmlogin.Opacity = 1.0
        frmlogin.Enabled = True
    End Sub

    Private Sub btnsignup_Click(sender As Object, e As EventArgs) Handles btnsignup.Click
        Dim empty As Boolean

        For Each ctrl As Control In Me.PanelRegistration.Controls
            If TypeOf ctrl Is Guna2TextBox Then
                If CType(ctrl, Guna2TextBox).Text = "" Then
                    CType(ctrl, Guna2TextBox).BorderColor = System.Drawing.Color.Red
                    CType(ctrl, Guna2TextBox).BorderThickness = 2
                    empty = True
                End If
            ElseIf TypeOf ctrl Is Guna2ComboBox Then
                If CType(ctrl, Guna2ComboBox).Text = "" Then
                    CType(ctrl, Guna2ComboBox).BorderColor = System.Drawing.Color.Red
                    CType(ctrl, Guna2ComboBox).BorderThickness = 2
                    empty = True
                End If
            End If
        Next ctrl

        If empty = True Then
            lblwarning.Text = "Please complete all the information requested."
        Else
            Dim access As Boolean

            openCon()
            sql = "Select username from tbl_accounts"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader()

            Do While dr.Read() = True

                If txtusername.Text = dr("username") Then
                    MsgBox("")
                    lblwarning.Text = "Username already exists"
                    txtusername.BorderColor = System.Drawing.Color.Red
                    txtusername.BorderThickness = 2
                    access = True
                    Exit Do
                End If
            Loop
            dr.Close()
            cn.Close()
            If access = False Then
                If MsgBox("Are you sure to register?", vbYesNo + vbQuestion, Me.Text) = vbYes Then

                    openCon()
                    sql = "INSERT INTO tbl_accountrequests(username,usertype,[password],lastname,firstname) Values ('" & txtusername.Text & "','" & cbusertype.Text & "','" & txtnewpassword.Text & "','" & txtlastname.Text & "','" & txtfirstname.Text & "')"
                    cmd = New OleDbCommand(sql, cn)
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("Record Saved!", 64, Me.Text)
                    Me.Close()
                    frmlogin.Opacity = 1.0
                    frmlogin.Enabled = True
                End If
            End If
        End If

        If cbusertype.Text = "" Then
            cbfill = False
        End If

        userLC = txtusername.Text.ToLowerInvariant
        passLC = txtnewpassword.Text.ToLowerInvariant
        Dim strPass As String
        Dim strUser As String
        Using hasher As MD5 = MD5.Create()
            Dim dbytes1 As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(userLC))
            Dim dbytes2 As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(passLC & rSalt))
            strUser = Convert.ToBase64String(dbytes1)
            strPass = Convert.ToBase64String(dbytes2)
        End Using

        openCon()
        sql = "INSERT INTO tbl_accounts(username,usertype,[password],lastname,firstname) Values ('" & strUser & "','" & cbusertype.Text & "','" & String.Format("{0}:{1}", rSalt, strPass) & "','" & txtlastname.Text & "','" & txtfirstname.Text & "')"
        cmd = New OleDbCommand(sql, cn)
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Record Saved!!", 64, Me.Text)
        Me.Close()
        frmlogin.Opacity = 1.0
        frmlogin.Enabled = True
    End Sub


    Private Function CreateNewSalt(SaltSize As Integer) As String

        Using rng As New RNGCryptoServiceProvider
            Dim data(If(SaltSize < 7, 7, SaltSize)) As Byte
            rng.GetBytes(data)
            Return Convert.ToBase64String(data)
        End Using
    End Function

End Class