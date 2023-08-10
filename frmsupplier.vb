Public Class frmsupplier

    Dim dasup As New OleDb.OleDbDataAdapter
    Dim dssup As New DataSet
    Dim dtsup As DataTable
    Dim drsup As DataRow


    Private Sub btnAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddnew.Click
        Module1.scalarquery("select max(supplier_id)+1 from supplier")
        txtsid.Text = Module1.nb
        txtsid.Enabled = False
        btnSave.Enabled = True
        txtmo.Text = ""
        txtsadd.Text = ""
        txtsname.Text = ""

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtsid.Text <> "" And txtsname.Text <> "" And txtmo.Text <> "" And txtsadd.Text <> "" And txtemail.Text <> "" Then
            Module1.insert_update("insert into supplier values(" & CInt(txtsid.Text) & ",'" & txtsname.Text & "','" & txtsadd.Text & "','" & txtmo.Text & "','" & txtemail.Text & "')")

            MsgBox("Supplier added successfully")
            btnSave.Enabled = False
            txtmo.Text = ""
            txtsadd.Text = ""
            txtsname.Text = ""
            txtsid.Text = ""

        Else
            MsgBox("Fill all the fields", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")

        End If




    End Sub

    Private Sub txtsname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsname.KeyPress
        If e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar >= "A" And e.KeyChar <= "Z" Or e.KeyChar = " " Or e.KeyChar = Convert.ToChar(Keys.Back) Then
            'nothing to do valid character
        Else
            e.KeyChar = ""
            txtsname.Select()
            MsgBox("Enter only Alphabets", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Invalid Input")
        End If
    End Sub

    Private Sub txtmo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmo.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = Convert.ToChar(Keys.Back) Then

        Else
            e.KeyChar = ""
            txtmo.Select()
            MsgBox("Enter only Numbers", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Invalid Input")
        End If
    End Sub


    Private Sub txtmo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmo.Leave
        Try

            If txtmo.Text.Substring(0, 1) >= 7 And txtmo.Text.Length = 10 Then

            Else

                txtmo.Select()
                MsgBox("Enter valid mobile", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Invalid Input")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub addsupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = Mainform.Panel1.Width

        Me.Width = Mainform.Width - Mainform.Panel1.Width
        Me.Height = Mainform.Height

        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2


        dssup.Clear()

        dasup = New OleDb.OleDbDataAdapter("select * from supplier", con)
        dasup.Fill(dssup)
        Call loadgrid()

    End Sub
    Private Sub loadgrid()
        DataGridView1.DataSource = dssup.Tables(0)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            dssup.Clear()
            dasup = New OleDb.OleDbDataAdapter("select * from supplier where supplier_id=" & CInt(TextBox1.Text) & "", con)
            dasup.Fill(dssup)
            If dssup.Tables(0).Rows.Count < 1 Then
                MsgBox("Supplier Not Found")
            Else
                Call loadgrid()
                TextBox1.Text = ""
                dtsup = dssup.Tables(0)
                drsup = dtsup.Rows(0)
                txtsid.Text = drsup(0)
                txtsname.Text = drsup(1)
                txtsadd.Text = drsup(2)
                txtmo.Text = drsup(3)
                txtemail.Text = drsup(4)

                btnUpdate.Enabled = True
            End If
            Call loadgrid()
        Else
            MsgBox("Enter Supplier id to display")
        End If

    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        dssup.Clear()

        dasup = New OleDb.OleDbDataAdapter("select * from supplier", con)
        dasup.Fill(dssup)
        Call loadgrid()
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If txtmo.Text <> "" And txtsadd.Text <> "" And txtsid.Text <> "" And txtsname.Text <> "" Then
            Module1.insert_update("update supplier set supplier_name='" & _
                              txtsname.Text & "',supplier_address='" & txtsadd.Text & _
                              "',supplier_contact='" & txtmo.Text & _
                              "',supplier_email='" & txtemail.Text & "' where supplier_id=" & CInt(txtsid.Text) & "")

            MsgBox("Supplier Updated")
            dssup.Clear()

            dasup = New OleDb.OleDbDataAdapter("select * from supplier", con)
            dasup.Fill(dssup)
            Call loadgrid()
            btnUpdate.Enabled = False

        End If

    End Sub

    Private Sub buttonClosePicturebox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Close()

    End Sub

    Private Sub txtsname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsname.TextChanged

    End Sub

    Private Sub txtmo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmo.TextChanged

    End Sub

    Private Sub txtemail_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemail.Leave
        Dim f As Boolean
        f = Module1.validateEmail(txtemail.Text)
        If f = False Then
            MsgBox("Enter valid Email", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Invalid Input")
            txtemail.Select()
        End If

    End Sub

    Private Sub txtemail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemail.TextChanged

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Me.Close()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class