Imports System.Data.OleDb
Imports System.Text
Imports System.Security.Cryptography
Module Module1
    Public cn As OleDbConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public da As OleDbDataAdapter
    Public sql As String

    Public Sub openCon()
        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" & Application.StartupPath & "\FlorescaDB.accdb")
        ';Jet OLEDB:Database Password=admin;
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
    End Sub
End Module
