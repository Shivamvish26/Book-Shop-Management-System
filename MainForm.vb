Public Class Mainform




    Private Sub btnbook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbook.Click
        Panel4.Visible = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Panel4.Left = Panel4.Left + 10
        If Panel4.Left >= 196 Then
            Panel4.Left = 196
            Timer1.Stop()
        End If
    End Sub

    Private Sub Panel1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.MouseHover
        Timer12.Start()
        Timer10.Start()
        Timer8.Start()
        Timer6.Start()
        Timer2.Start()
    End Sub


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Panel4.Left = Panel4.Left - 5
        If Panel4.Left <= 50 Then
            Panel4.Left = 48
            Panel4.Visible = False
            Timer2.Stop()
        End If
    End Sub

    Private Sub btncompress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncompress.Click
        Timer3.Start()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Panel1.Width = Panel1.Width - 10
        If Panel1.Width <= 67 Then
            Panel1.Width = 67
            Timer3.Stop()
            btnexpand.Visible = True
            btncompress.Visible = False

        End If
    End Sub

    Private Sub btnexpand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexpand.Click
        Timer4.Start()
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Panel1.Width = Panel1.Width + 10
        If Panel1.Width >= 195 Then
            Panel1.Width = 195
            Timer4.Stop()
            btnexpand.Visible = False
            btncompress.Visible = True
        End If
    End Sub

    Private Sub Mainform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Width = 70
    End Sub

    Private Sub btnaddbook_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnaddbook.Click
        Timer2.Start()
        AddBook.ShowDialog()

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Panel4.Visible = True
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Timer2.Start()
        BookUpdate.Show()
    End Sub

    
    Private Sub btnrep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrep.Click
        Panel6.Visible = True
        Timer11.Start()
        'frmBookrep.Show()
    End Sub

  
    
    Private Sub btncustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncustomer.Click




        Panel2.Visible = True
        Timer5.Start()

        'Customer.Show()
        ' frmViewCustomer.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frmbl.ShowDialog()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Panel5.Visible = True
        Timer9.Start()

        'frmStaff.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MsgBox("Do you really Want to Exit?", vbYesNo + vbQuestion, " Logout") = vbYes Then
            End
        End If

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        Panel3.Visible = True
        Timer7.Start()

        'frmsupplier.Show()
    End Sub

    

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

   
    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        Panel2.Left = Panel2.Left + 10
        If Panel2.Left >= 196 Then
            Panel2.Left = 196
            Timer5.Stop()
        End If
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        Panel2.Left = Panel2.Left - 5
        If Panel2.Left <= 50 Then
            Panel2.Left = 48
            Panel2.Visible = False
            Timer6.Stop()
        End If
    End Sub

    

    

    Private Sub btnaddcut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddcut.Click
        Timer6.Start()
        Customer.ShowDialog()

    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        Timer6.Start()
        frmViewCustomer.ShowDialog()
    End Sub

    Private Sub btnaddsup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmsupplier.ShowDialog()
    End Sub

    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        Panel3.Left = Panel3.Left + 10
        If Panel3.Left >= 196 Then
            Panel3.Left = 196
            Timer7.Stop()
        End If
    End Sub

    Private Sub Timer8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer8.Tick
        Panel3.Left = Panel3.Left - 5
        If Panel3.Left <= 50 Then
            Panel3.Left = 48
            Panel3.Visible = False
            Timer8.Stop()
        End If
    End Sub

   
    Private Sub btnaddsup_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddsup.Click
        Timer8.Start()
        frmsupplier.ShowDialog()
    End Sub

    Private Sub Timer9_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer9.Tick
        Panel5.Left = Panel5.Left + 10
        If Panel5.Left >= 196 Then
            Panel5.Left = 196
            Timer9.Stop()
        End If
    End Sub

    Private Sub Timer10_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer10.Tick
        Panel5.Left = Panel5.Left - 5
        If Panel5.Left <= 50 Then
            Panel5.Left = 48
            Panel5.Visible = False
            Timer10.Stop()
        End If
    End Sub

    Private Sub btnaddemp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddemp.Click
        Timer10.Start()
        frmStaff.ShowDialog()
    End Sub

    Private Sub Timer11_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer11.Tick
        Panel6.Left = Panel6.Left + 10
        If Panel6.Left >= 196 Then
            Panel6.Left = 196
            Timer11.Stop()
        End If
    End Sub

    Private Sub Timer12_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer12.Tick
        Panel6.Left = Panel6.Left - 5
        If Panel6.Left <= 50 Then
            Panel6.Left = 48
            Panel6.Visible = False
            Timer12.Stop()
        End If
    End Sub

    Private Sub btncrcust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncrcust.Click
        Timer12.Start()
        frmcustorep.ShowDialog()
    End Sub

    Private Sub btncrsup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncrsup.Click
        Timer12.Start()
        frmsupprep.ShowDialog()

    End Sub

    Private Sub btncrbill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncrbill.Click
        Timer12.Start()
        frmBookrep.ShowDialog()
    End Sub

    Private Sub btncremp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncremp.Click
        Timer12.Start()
        frmemprep.ShowDialog()
    End Sub
End Class

