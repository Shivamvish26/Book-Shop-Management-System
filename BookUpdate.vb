Public Class BookUpdate
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim dr As DataRow
    Dim x As Integer
    Dim cnt As Integer
    Private Sub Loadtext()
        lblisbn.Text = dr(0)
        txtBname.Text = dr(1)
        txtBauth.Text = dr(2)
        txtBpublication.Text = dr(3)
        txtBedition.Text = dr(4)
        txtBprice.Text = dr(5)
        txtBqty.Text = dr(6)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub Emptyfields()
        txtISBN.Clear()
        txtBauth.Clear()
        txtBname.Clear()
        txtBauth.Clear()
        txtBpublication.Clear()
        txtBedition.Clear()
        txtBprice.Clear()
        txtBqty.Clear()

    End Sub
    Private Sub BookUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Top = 0
        Me.Left = Mainform.Panel1.Width

        Me.Width = Mainform.Width - Mainform.Panel1.Width
        Me.Height = Mainform.Height

        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2

        da = New OleDb.OleDbDataAdapter("select ISBN,Bname as Book_Name,Bauth as Author,Bpublication as publication,Bedition as Edition,Bprice as Price,Bqty as Available_Quantity from Book", con)
        ds.Clear()
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

        x = 0
        cnt = ds.Tables(0).Rows.Count

        If ds.Tables(0).Rows.Count > 0 Then
            dr = ds.Tables(0).Rows(x)
            loadtext()
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtBqty.Text <> "" Then
            Module1.insert_update("update Book set Bqty=Bqty+" & CInt(txtBqty.Text) & " where ISBN='" & lblisbn.Text & "'")
            MsgBox("Book Quantity Upadte")
            Me.Close()
        End If
    End Sub

    Private Sub btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlast.Click
        dr = ds.Tables(0).Rows(cnt - 1)
        x = cnt - 1
        loadtext()



    End Sub

    Private Sub btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfirst.Click
        dr = ds.Tables(0).Rows(0)
        x = 0
        loadtext()

    End Sub

    
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        x = x + 1
        If x < cnt Then
            dr = ds.Tables(0).Rows(x)
            loadtext()
        Else
            MsgBox("This is a last record")
            x = cnt - 1
            dr = ds.Tables(0).Rows(x)
            loadtext()
        End If
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        x = x - 1
        If x >= 0 Then
            dr = ds.Tables(0).Rows(x)
            loadtext()
        Else
            MsgBox("This is a First record")
            x = 0
            dr = ds.Tables(0).Rows(x)
            loadtext()
        End If
    End Sub

    Private Sub txtISBN_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtISBN.KeyUp
        If txtISBN.Text <> "" Then

            da = New OleDb.OleDbDataAdapter("select ISBN,Bname as Book_Name,Bauth as Author,Bpublication as publication,Bedition as Edition,Bprice as Price,Bqty as Available_Quantity from Book where ISBN like '%" & txtISBN.Text & "%'", con)
            ds.Clear()
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)

            x = 0
            cnt = ds.Tables(0).Rows.Count

            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(x)
                loadtext()
            Else
                MsgBox("No such Record Found")
                Emptyfields()
            End If
        End If
    End Sub

    
End Class