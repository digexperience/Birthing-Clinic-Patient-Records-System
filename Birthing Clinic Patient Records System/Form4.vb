'Imports System.ComponentModel.Design
'Imports System.Data.OleDb
'Public Class Form4
'    Dim lv As ListViewItem
'    Dim selected As String

'    Private Sub PopListView()
'        ListView1.Clear()

'        With ListView1
'            .View = View.Details
'            .GridLines = True
'            .Columns.Add("Book No", 60)
'            .Columns.Add("Title", 100)
'            .Columns.Add("Author", 100)
'            .Columns.Add("Publisher", 100)
'            .Columns.Add("Subject", 100)
'        End With

'        openCon()
'        sql = "Select * from tbl_bookinfo order by bookid"
'        cmd = New OleDb.OleDbCommand(sql, cn)
'        dr = cmd.ExecuteReader()

'        Do While dr.Read() = True
'            lv = New ListViewItem(dr("bookid").ToString)
'            lv.SubItems.Add(dr("booktitle"))
'            lv.SubItems.Add(dr("bookauthor"))
'            lv.SubItems.Add(dr("bookpublisher"))
'            lv.SubItems.Add(dr("booksubject"))
'            ListView1.Items.Add(lv)
'        Loop
'        dr.Close()
'        cn.Close()
'    End Sub

'    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        PopListView()
'    End Sub

'    Private Sub resetform()
'        txtbookid.Text = Nothing
'        txttitle.Text = Nothing
'        txtauthor.Text = Nothing
'        txtpublisher.Text = Nothing
'        txtsubject.Text = Nothing
'        txtcategory.Text = Nothing

'        txttitle.Enabled = False
'        txtauthor.Enabled = False
'        txtpublisher.Enabled = False
'        txtsubject.Enabled = False
'        txtcategory.Enabled = False

'        btnadd.Text = "Add New"
'        btndelete.Text = "Delete"
'        btndelete.ForeColor = Color.Red
'        btndelete.Enabled = False
'        btnclose.Text = "Close"
'        btnadd.Enabled = True
'        btnupdate.Enabled = False
'        btnupdate.Text = "Update"
'        ListView1.Enabled = True
'    End Sub

'    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
'        If btnadd.Text = "Add New" Then
'            btnupdate.Text = "Save"
'            ListView1.Enabled = False
'            txtbookid.Text = "(Auto Generated)"
'        Else
'            ListView1.Enabled = False
'            btndelete.Enabled = True
'        End If

'        Me.txttitle.Enabled = True
'        Me.txtauthor.Enabled = True
'        Me.txtpublisher.Enabled = True
'        Me.txtsubject.Enabled = True
'        Me.txtcategory.Enabled = True
'        btnupdate.Enabled = True
'        btnclose.Text = "Cancel"
'        btnadd.Enabled = False
'        btndelete.Text = "Clear"
'        btndelete.ForeColor = Color.Black
'    End Sub

'    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
'        If txttitle.Text = "" Or txtauthor.Text = "" Or txtpublisher.Text = "" Or txtsubject.Text = "" Or txtcategory.Text = "" Then
'            If btnupdate.Text = "Save" Then
'                MsgBox("Please complete all data before Saving it.", vbExclamation, Me.Text)
'            ElseIf btnupdate.Text = "Update" Then
'                MsgBox("Please complete all data before Updating it.", vbExclamation, Me.Text)
'            End If
'        Else
'            If btnupdate.Text = "Save" Then
'                If MsgBox("Are you sure to save this data?", vbYesNo + vbQuestion, Me.Text) = vbYes Then
'                    openCon()
'                    sql = "INSERT INTO tbl_bookinfo (booktitle,bookauthor,bookpublisher,booksubject,bookcategory) VALUES ('" & txttitle.Text & "','" & txtauthor.Text & "','" & txtpublisher.Text & "','" & txtsubject.Text & "','" & txtcategory.Text & "')"
'                    cmd = New OleDbCommand(sql, cn)
'                    cmd.ExecuteNonQuery()
'                    cn.Close()
'                    MsgBox("Record Saved!", 64, Me.Text)
'                    PopListView()
'                    resetform()
'                End If
'            ElseIf btnupdate.Text = "Update" Then
'                If MsgBox("Are you sure to update this data?", vbYesNo + vbQuestion, Me.Text) = vbYes Then
'                    openCon()
'                    sql = "update tbl_bookinfo set booktitle='" & txttitle.Text & "',bookauthor='" & txtauthor.Text & "',bookpublisher='" & txtpublisher.Text & "',booksubject='" & txtsubject.Text & "',bookcategory='" & txtcategory.Text & "' where bookid =" & selected
'                    cmd = New OleDbCommand(sql, cn)
'                    cmd.ExecuteNonQuery()
'                    cn.Close()
'                    MsgBox("Record Updated!", 64, Me.Text)
'                    PopListView()
'                    resetform()
'                End If
'            End If
'        End If
'    End Sub

'    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged, ListView1.Click
'        Dim i As Integer
'        For i = 0 To ListView1.SelectedItems.Count - 1

'            selected = ListView1.SelectedItems(i).Text
'            openCon()
'            sql = "Select * from tbl_bookinfo where bookid=" & selected
'            cmd = New OleDbCommand(sql, cn)
'            dr = cmd.ExecuteReader()

'            dr.Read()

'            txtbookid.Text = dr("bookid")
'            txttitle.Text = dr("booktitle")
'            txtauthor.Text = dr("bookauthor")
'            txtpublisher.Text = dr("bookpublisher")
'            txtsubject.Text = dr("booksubject")
'            txtcategory.Text = dr("bookcategory")

'            dr.Close()
'            cn.Close()
'        Next
'        btnadd.Text = "Edit"
'        btndelete.Enabled = True
'        btnclose.Text = "Cancel"
'    End Sub

'    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
'        If btndelete.Text = "Delete" Then
'            If MsgBox("Are you sure to delete this data?", vbYesNo + vbQuestion, Me.Text) = vbYes Then
'                openCon()
'                sql = "Delete from tbl_bookinfo where bookid=" & selected
'                cmd = New OleDbCommand(sql, cn)
'                cmd.ExecuteNonQuery()
'                cn.Close()
'                MsgBox("Record Deleted!", 64, Me.Text)
'                resetform()
'                PopListView()
'            End If
'        Else
'            txttitle.Text = Nothing
'            txtauthor.Text = Nothing
'            txtpublisher.Text = Nothing
'            txtsubject.Text = Nothing
'            txtcategory.Text = Nothing
'        End If
'    End Sub

'    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
'        If btnclose.Text = "Close" Then
'            Me.Close()
'        Else
'            resetform()
'        End If
'    End Sub

'    Private Sub Textbox_TextChanged(sender As Object, e As EventArgs) Handles txttitle.TextChanged, txtauthor.TextChanged, txtpublisher.TextChanged, txtsubject.TextChanged, txtcategory.TextChanged
'        If txttitle.Text = "" And txtauthor.Text = "" And txtpublisher.Text = "" And txtsubject.Text = "" And txtcategory.Text = "" Then
'            btndelete.Enabled = False
'        Else
'            btndelete.Enabled = True
'        End If
'    End Sub
'End Class
