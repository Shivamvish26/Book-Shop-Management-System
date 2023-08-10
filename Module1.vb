
Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Module Module1
    Public con As New OleDbConnection
    Public cmd As OleDbCommand
    Public da As New OleDbDataAdapter
    Public ds As New DataSet
    Public dt As New DataTable
    Public dr As DataRow
    Public nb As Integer
    Public Sub connectdb()
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\shubham\Documents\BookStore.mdb"
        con.Open()
        ' MsgBox("Connected To Database")
    End Sub
    Public Sub scalarquery(ByVal q As String)
        'MsgBox(q)
        cmd = New OleDbCommand(q, con)
        nb = cmd.ExecuteScalar()
    End Sub
    Public Sub insert_update(ByVal query As String)
        cmd = New OleDbCommand(query, con)
        cmd.ExecuteNonQuery()



    End Sub
    Public Sub returndata(ByVal q As String)
        da = New OleDbDataAdapter(q, con)
        da.Fill(ds, "d")
        dt = ds.Tables("d")

    End Sub

    Public Function validateEmail(ByVal emailAddress) As Boolean
        ' Dim email As New Regex("^(?[^@]+)@(?.+)$")
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
