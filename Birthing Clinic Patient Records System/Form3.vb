Imports System.Runtime.CompilerServices

Public Class frmmain
    Dim newFont As New Font("Segoe UI", 9.2, FontStyle.Underline)
    Dim newFont2 As New Font("Segoe UI", 9.2)
    Dim hided = False

    Private Property MoveForm As Boolean

    Private Property MoveForm_MousePosition As Point

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
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        For disapper As Single = 1.0! To 0 Step -0.2!
            Me.Opacity = disapper
            System.Threading.Thread.Sleep(50)
        Next
        Me.Opacity = 1.0!
        Me.Close()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        For disapper As Single = 1.0! To 0 Step -0.2!
            Me.Opacity = disapper
            System.Threading.Thread.Sleep(50)
        Next
        Me.Opacity = 1.0!
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnslidepanel_Click(sender As Object, e As EventArgs) Handles btnslidepanel.Click

        If hided = False Then

            btnslidepanel.Image = Nothing
            While (sc.SplitterDistance > 40)
                sc.SplitterDistance -= 1
                btnslidepanel.Width -= 2
            End While

            While (btnslidepanel.Width < 51)
                btnslidepanel.Width += 1
            End While

            btnslidepanel.Image = My.Resources.iconslideshow

            hided = True
            btnhome.Text = Nothing
            btnrecords.Text = Nothing
            btnnotifi.Text = Nothing
            btncalendar.Text = Nothing
            btnhelp.Text = Nothing
            btncontrol.Text = Nothing
            btnaccount.Text = Nothing
            btnsetting.Text = Nothing
            btnabout.Text = Nothing
            btnlogout.Text = Nothing

            btnhome.Width = sc.SplitterDistance
            btnrecords.Width = sc.SplitterDistance
            btnnotifi.Width = sc.SplitterDistance
            btncalendar.Width = sc.SplitterDistance
            btnhelp.Width = sc.SplitterDistance
            btncontrol.Width = sc.SplitterDistance
            btnaccount.Width = sc.SplitterDistance
            btnsetting.Width = sc.SplitterDistance
            btnabout.Width = sc.SplitterDistance
            btnlogout.Width = sc.SplitterDistance

            btnhome.Image = My.Resources.iconhome
            btnrecords.Image = My.Resources.iconrecords
            btnnotifi.Image = My.Resources.iconnotifi
            btncalendar.Image = My.Resources.iconcalendar
            btnhelp.Image = My.Resources.iconhelp
            btncontrol.Image = My.Resources.iconcontrol
            btnlogout.Image = My.Resources.iconlogout

        ElseIf hided = True Then

            btnslidepanel.Image = Nothing
            While (sc.SplitterDistance < 120)
                sc.SplitterDistance += 1
                btnslidepanel.Width -= 2

                btnhome.Width = sc.SplitterDistance
                btnrecords.Width = sc.SplitterDistance
                btnnotifi.Width = sc.SplitterDistance
                btncalendar.Width = sc.SplitterDistance
                btnhelp.Width = sc.SplitterDistance
                btncontrol.Width = sc.SplitterDistance
                btnaccount.Width = sc.SplitterDistance - 2
                btnsetting.Width = sc.SplitterDistance - 2
                btnabout.Width = sc.SplitterDistance - 2
                btnlogout.Width = sc.SplitterDistance - 2
            End While

            While (btnslidepanel.Width < 51)
                btnslidepanel.Width += 1
            End While

            btnslidepanel.Image = My.Resources.iconslidehide

            hided = False
            btnhome.Image = Nothing
            btnrecords.Image = Nothing
            btnnotifi.Image = Nothing
            btncalendar.Image = Nothing
            btnhelp.Image = Nothing
            btncontrol.Image = Nothing
            btnlogout.Image = Nothing

            btnhome.Text = "Home"
            btnrecords.Text = "Patients record"
            btnnotifi.Text = "Notification"
            btncalendar.Text = "Calendar"
            btnhelp.Text = "Help and Tips"
            btncontrol.Text = "Accounts Control"
            btnaccount.Text = "Account"
            btnsetting.Text = "Setting"
            btnabout.Text = "About"
            btnlogout.Text = "Logout"

        End If

    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles btnaccount.Click

    End Sub
End Class