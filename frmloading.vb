Public Class frmloading

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        MainForm.Show()
        Me.Hide()
    End Sub
End Class