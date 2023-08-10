Public Class AddBook

    Private Sub AddBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = Mainform.Panel1.Width

        Me.Width = Mainform.Width - Mainform.Panel1.Width
        Me.Height = Mainform.Height

        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2


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
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtBauth.Text <> "" And txtBname.Text <> "" And txtBedition.Text <> "" And txtISBN.Text <> "" And txtBpublication.Text <> "" And txtBprice.Text <> "" And txtBqty.Text <> "" Then
            Module1.insert_update("Insert into Book values('" & txtISBN.Text & "','" & txtBname.Text & "','" & txtBauth.Text & "','" & txtBpublication.Text & "','" & txtBedition.Text & "','" & txtBprice.Text & "'," & CInt(txtBqty.Text) & ")")
            MsgBox("Book Added", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Save Book")
            Emptyfields()
        Else
            MsgBox("Fields Should Not Be Empty")
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class