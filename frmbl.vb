Imports System.Drawing.Printing
Public Class frmbl
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet

    Dim dac As New OleDb.OleDbDataAdapter
    Dim dsc As New DataSet

    Dim dap As New OleDb.OleDbDataAdapter
    Dim dsp As New DataSet

    Dim dr As DataRow
    Dim drpn As DataRow
    Dim sr As Integer

    Private BMP As Bitmap
    Private Sub subA(ByVal s, ByVal args)
        args.Graphics.DrawImage(BMP, 0, 0)
        args.HasMorePages = False
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub frmbl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sr = 1

        Me.Top = 0
        Me.Left = Mainform.Panel1.Width

        Me.Width = Mainform.Width - Mainform.Panel1.Width
        Me.Height = Mainform.Height

        Panel4.Left = (Me.Width - Panel4.Width) / 2
        Panel4.Top = (Me.Height - Panel4.Height) / 2


        lblbdate.Text = Format(Now, "dd/MM/yyyy")
        da = New OleDb.OleDbDataAdapter("select max(bid)+1 from Bill", con)
        ds.Clear()
        da.Fill(ds)
        dr = ds.Tables(0).Rows(0)
        lblbno.Text = dr(0)

        dac = New OleDb.OleDbDataAdapter("Select cmob from customer", con)
        dsc.Clear()
        dac.Fill(dsc)

        Dim drc As DataRow
        Dim x As Integer
        x = 0
        While x < dsc.Tables(0).Rows.Count
            drc = dsc.Tables(0).Rows(x)
            cmbcust.Items.Add(drc(0))
            x = x + 1

        End While

        dap = New OleDb.OleDbDataAdapter("Select Bname from Book", con)
        dsp.Clear()
        dap.Fill(dsp)

        Dim drp As DataRow
        x = 0
        While x < dsp.Tables(0).Rows.Count
            drp = dsp.Tables(0).Rows(x)
            cmdprname.Items.Add(drp(0))
            x = x + 1

        End While

        ListView1.Items.Clear()
        ListView1.View = View.Details
        ListView1.FullRowSelect = True

        ListView1.Columns.Add("Sr", 50)
        ListView1.Columns.Add("Product Name", 240)
        ListView1.Columns.Add("Quantity", 150)
        ListView1.Columns.Add("Price", 130)
        ListView1.Columns.Add("Total", 130)
    End Sub


    Private Sub cmbcust_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcust.SelectedIndexChanged
        Dim dsc As New DataSet
        Dim drc As DataRow
        dac = New OleDb.OleDbDataAdapter("select cname,cadd from customer where cmob='" & cmbcust.Text & "'", con)
        dsc.Clear()
        dac.Fill(dsc)


        drc = dsc.Tables(0).Rows(0)
        lblcname.Text = drc(0)
        lblmobile.Text = cmbcust.Text

    End Sub

    Private Sub txtqty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtqty.GotFocus
        btnadditem.Enabled = False
    End Sub

    Private Sub txtqty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtqty.LostFocus
        Dim dsp As New DataSet

        dap = New OleDb.OleDbDataAdapter("Select * from Book where Bname='" & cmdprname.Text & "'", con)
        dsp.Clear()
        dap.Fill(dsp)
        drpn = dsp.Tables(0).Rows(0)
        If drpn(6) < CInt(txtqty.Text) Then
            MsgBox("Not Enough Qty Available :" & drpn(6))
            Exit Sub
        Else
            btnadditem.Enabled = True
        End If

    End Sub



    Private Sub btnadditem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadditem.Click
        If txtqty.Text <> "" And cmdprname.Text <> "" Then
            Module1.insert_update("insert into billshort values(" & CInt(lblbno.Text) & ",'" & cmdprname.Text & "','" & txtqty.Text & "')")
            Module1.insert_update("update Book set Bqty=Bqty-" & CInt(txtqty.Text) & " where Bname='" & cmdprname.Text & "'")
        End If
        Dim item As New ListViewItem(sr)
        item.SubItems.Add(cmdprname.Text)
        item.SubItems.Add(txtqty.Text)
        item.SubItems.Add(drpn(5))
        item.SubItems.Add(CInt(txtqty.Text) * drpn(5))

        lblsubtotal.Text = CLng(lblsubtotal.Text) + CLng(CInt(txtqty.Text) * drpn(5))
        lblgst.Text = CLng(lblsubtotal.Text) * 0.05
        lblgrand.Text = CLng(lblsubtotal.Text) + CLng(lblgst.Text)

        ListView1.Items.Add(item)
        sr = sr + 1
        txtqty.Clear()
        cmdprname.Text = ""
        btnadditem.Enabled = False

        btnprint.Enabled = True
    End Sub

    Private Sub txtqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.TextChanged

    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        If lblcname.Text <> "" And lblmobile.Text <> "" Then

        Else
            MsgBox("Select Customer Details")
            Exit Sub
        End If
        If MsgBox("Confirm Print", vbYesNo + vbQuestion, "Print") = MsgBoxResult.Yes Then
            Module1.insert_update("insert into bill values(" & CInt(lblbno.Text) & ",'" & lblmobile.Text & "','" & lblbdate.Text & "','" & lblsubtotal.Text & "','" & lblgst.Text & "','" & lblgrand.Text & "')")

            Dim pd As New PrintDocument
            Dim pdialog As New PrintDialog
            Dim ppd As New PrintPreviewDialog
            BMP = New Bitmap(GroupBox1.Width, GroupBox1.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            GroupBox1.DrawToBitmap(BMP, New Rectangle(0, 0, GroupBox1.Width, GroupBox1.Height))
            AddHandler pd.PrintPage, AddressOf subA
            '(Sub(s, args) args.Graphics.DrawImage(BMP, 0, 0)args.HasMorePages = False     End Sub)
            'choose a printer
            If pdialog.ShowDialog(Me) = Windows.Forms.DialogResult.Cancel Then
                MsgBox("Print Cancel")
                Exit Sub
            End If
            pd.PrinterSettings.PrinterName = pdialog.PrinterSettings.PrinterName
            If pd.PrinterSettings.CanDuplex.ToString Then
                pd.PrinterSettings.Duplex = Duplex.Vertical
            End If
            'Preview the document
            ppd.Document = pd
            If ppd.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                pd.Print()
                ppd.Dispose()

            Else
                '            MsgBox("Print Cancel")
            End If
        Else

            MsgBox("Operation Canclled")
        End If
    End Sub

   

   
End Class