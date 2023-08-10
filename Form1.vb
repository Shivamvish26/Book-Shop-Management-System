Imports System.Data.OleDb

Public Class Form1
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub lblani1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblani1.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblani1.Left = lblani1.Left + 5

        If lblani1.Left >= 255 Then
            Timer1.Stop()
            lblani1.Left = 255
            Timer2.Start()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Top = -Panel1.Height
        Module1.connectdb()

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Panel1.Top = Panel1.Top + 5
        If Panel1.Top >= 50 Then
            Timer2.Stop()
            Panel1.Top = 12

        End If
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim dr As DataRow
        If txtuser.Text <> "" And txtpass.Text <> "" Then
            da = New OleDbDataAdapter("select count (*) from Admin where uname='" & txtuser.Text & "' and upass='" & txtpass.Text & "'", con)
            ds.Clear()
            da.Fill(ds)
            'MsgBox(ds.Tables(0).Rows.Count)
            dr = ds.Tables(0).Rows(0)
            If dr(0) = 1 Then
                frmloading.Show()
                Me.Hide()
            Else
                MsgBox("Invalid Username or Password", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel, "Error")
                txtuser.Select()



            End If
        End If



    End Sub

    Private Sub btnlogin_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnlogin.GotFocus

    End Sub

    Private Sub txtuser_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuser.GotFocus
        txtuser.Clear()
    End Sub

    Private Sub txtuser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuser.TextChanged

    End Sub

    Private Sub txtpass_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpass.GotFocus
        txtpass.Clear()
    End Sub

    Private Sub txtpass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpass.TextChanged

    End Sub
End Class
