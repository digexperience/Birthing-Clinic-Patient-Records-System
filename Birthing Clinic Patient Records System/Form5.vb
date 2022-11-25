Public Class Form5
    Dim hided = False
    'Private Sub btnslidepanel_Click(sender As Object, e As EventArgs)
    '    If hided = False Then
    '        While (Guna2Panel1.Width > 40)
    '            Guna2Panel1.Width -= 1
    '            hided = True
    '        End While
    '    ElseIf hided = True Then
    '        While (Guna2Panel1.Width < 120)
    '            Guna2Panel1.Width += 1
    '            hided = False
    '        End While
    '    End If
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = "11"
            End If
        Next ctrl
    End Sub
End Class