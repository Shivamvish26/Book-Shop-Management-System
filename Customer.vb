Public Class Customer

    Private Sub Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        txtcmob.Clear()
        txtcname.Clear()
        txtcadd.Clear()
        txtcemail.Clear()

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtcmob.Text <> "" And txtcname.Text <> "" And txtcadd.Text <> "" And txtcemail.Text <> "" Then
            Module1.insert_update("insert into customer values('" & txtcmob.Text & "','" & txtcname.Text & "','" & txtcadd.Text & "','" & txtcemail.Text & "')")
            MsgBox("Customer Added", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Customer Added")
            Emptyfields()
        Else
            MsgBox("Fields Should Not Be Empty")
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtcmob_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcmob.TextChanged

    End Sub

    Private Sub txtcemail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcemail.TextChanged

    End Sub

    Private Sub txtcemail_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcemail.Leave
        Dim f As Boolean
        f = Module1.validateEmail(txtcemail.Text)
        If f = False Then
            MsgBox("Enter valid Email", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Invalid Input")
            txtcemail.Select()
        End If

    End Sub
    Private Sub txtmo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcmob.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = Convert.ToChar(Keys.Back) Then

        Else
            e.KeyChar = ""
            txtcmob.Select()
            MsgBox("Enter only Numbers", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Invalid Input")
        End If
    End Sub


    Private Sub txtcmob_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcmob.Leave
        Try

            If txtcmob.Text.Substring(0, 1) >= 7 And txtcmob.Text.Length = 10 Then

            Else

                txtcmob.Select()
                MsgBox("Enter valid mobile", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Invalid Input")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Private Sub txtcname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcname.KeyPress
        If e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar >= "A" And e.KeyChar <= "Z" Or e.KeyChar = " " Or e.KeyChar = Convert.ToChar(Keys.Back) Then
            'nothing to do valid character
        Else
            e.KeyChar = ""
            txtcname.Select()
            MsgBox("Enter only Alphabets", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Invalid Input")
        End If
    End Sub

End Class