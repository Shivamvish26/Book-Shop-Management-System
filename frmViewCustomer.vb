Public Class frmViewCustomer

    Dim da4 As New OleDb.OleDbDataAdapter
    Dim ds4 As New DataSet
    Dim dtsup As DataTable
    Dim drsup As DataRow
    Private Sub frmViewCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Top = 0
        Me.Left = Mainform.Panel1.Width

        Me.Width = Mainform.Width - Mainform.Panel1.Width
        Me.Height = Mainform.Height

        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2



        da4 = New OleDb.OleDbDataAdapter(" select * from Customer ", con)
        ds4.Clear()
        da4.Fill(ds4)
        DataGridView1.DataSource = ds4.Tables(0)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class