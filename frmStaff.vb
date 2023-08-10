Public Class frmStaff


    Dim dsemp As New DataSet
    Dim daemp As New OleDb.OleDbDataAdapter
    Dim dremp As DataRow

    Dim dotoc As Integer

   

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub frmStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = Mainform.Panel1.Width

        Me.Width = Mainform.Width - Mainform.Panel1.Width
        Me.Height = Mainform.Height

        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2

        dtp2.MinDate = Today
        dsemp.Clear()
        daemp = New OleDb.OleDbDataAdapter("select * from employeee", con)
        daemp.Fill(dsemp)
        DataGridView4.DataSource = dsemp.Tables(0)



    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Module1.scalarquery("select max(emp_id)+1 from employeee")
        txtid.Text = Module1.nb
        txtid.Enabled = False
        txtadd.Text = ""
        txtemail.Text = ""
        txtlv.Text = ""
        txtmo.Text = ""
        txtname.Text = ""
        txtsal.Text = ""
        btnSave.Enabled = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtemail.Text <> "" And txtadd.Text <> "" And txtlv.Text <> "" And txtmo.Text <> "" And txtname.Text <> "" And txtsal.Text <> "" Then
            'Module1.upinquery("insert into employee values(" & (txtadd.Text) & ",'" & txtname.Text & "','" & txtadd.Text & "','" & txtemail.Text & "')")
            Module1.insert_update("insert into employeee values(" & CInt(txtid.Text) & ",'" & txtname.Text & "','" & txtadd.Text & "','" & txtemail.Text & "','" & txtmo.Text & "','" & ComboBox4.Text & "','" & dtp2.Value & "','" & txtsal.Text & "'," & CInt(txtlv.Text) & ",'" & dtp1.Value & "')")
            MsgBox("Employee Added")

            txtid.Text = ""
            txtid.Enabled = False
            txtadd.Text = ""
            txtemail.Text = ""
            txtlv.Text = ""
            txtmo.Text = ""
            txtname.Text = ""
            txtsal.Text = ""
            btnSave.Enabled = False
            Call loaddata()
        Else
            MsgBox("All Fields Required")
        End If
    End Sub
    Private Sub loaddata()
        dsemp.Clear()
        daemp = New OleDb.OleDbDataAdapter("Select * from employeee", con)
        daemp.fill(dsemp)
        DataGridView4.DataSource = dsemp.Tables(0)
    End Sub


    
    
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim empid As Integer
        dsemp.Clear()
        Try
            empid = CInt(InputBox("Enter Empid to Search"))

        Catch ex As Exception
            MsgBox("Enter Number")
            Exit Sub

        End Try
        daemp = New OleDb.OleDbDataAdapter("Select * from employeee where emp_id=" & empid & "", con)
        daemp.Fill(dsemp)
        If dsemp.Tables(0).Rows.Count > 0 Then
            DataGridView4.DataSource = dsemp.Tables(0)
            dremp = dsemp.Tables(0).Rows(0)
            txtid.Text = dremp(0)
            txtid.Enabled = False
            txtadd.Text = dremp(2)
            ComboBox4.Text = dremp(5)

            txtemail.Text = dremp(3)
            txtlv.Text = dremp(8)
            txtmo.Text = dremp(4)
            txtname.Text = dremp(1)
            txtsal.Text = dremp(7)
            btnUpdate.Enabled = True
            dtp1.Value = dremp(9)
            'dtp2.Value = dremp(6)

        Else
            MsgBox("No Such Employee Found")
        End If

    End Sub

    

    Private Sub btnUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If txtemail.Text <> "" And txtadd.Text <> "" And txtlv.Text <> "" And txtmo.Text <> "" And txtname.Text <> "" And txtsal.Text <> "" Then
            'Module1.upinquery("insert into employee values(" & (txtadd.Text) & ",'" & txtname.Text & "','" & txtadd.Text & "','" & txtemail.Text & "')")
            Module1.insert_update("update employeee set em_name='" & txtname.Text & "',emp_address='" & txtadd.Text & "',emp_email='" & txtemail.Text & "',emp_mobile='" & txtmo.Text & "',emp_sal='" & txtsal.Text & "',emp_leaves=" & CInt(txtlv.Text) & " where emp_id=" & CInt(txtid.Text) & "")
            MsgBox("Employee Updated")
            txtid.Text = ""
            txtid.Enabled = False
            txtadd.Text = ""
            txtemail.Text = ""
            txtlv.Text = ""
            txtmo.Text = ""
            txtname.Text = ""
            txtsal.Text = ""
            btnUpdate.Enabled = False
            Call loaddata()
        Else
            MsgBox("All Fields Required")
        End If
    End Sub

    Private Sub txtlv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlv.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = Convert.ToChar(Keys.Back) Then

        Else
            e.KeyChar = ""
            txtlv.Select()
            MsgBox("Enter only Numbers", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Invalid Input")
        End If
    End Sub

    Private Sub txtsal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsal.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = "." Or e.KeyChar = Convert.ToChar(Keys.Back) Then
            If e.KeyChar = "." Then
                dotoc = dotoc + 1

            End If
        Else
            e.KeyChar = ""
            txtsal.Select()
            MsgBox("Enter only Numbers", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Invalid Input")
        End If
    End Sub

    Private Sub txtsal_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsal.Leave
        If dotoc > 1 Then
            MsgBox("Enter Valid Salary")
            txtsal.Select()
            dotoc = 0

        End If
    End Sub

    
    Private Sub txtsal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsal.TextChanged

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

    Private Sub txtmo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmo.TextChanged

    End Sub

    Private Sub txtname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        If e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar >= "A" And e.KeyChar <= "Z" Or e.KeyChar = " " Or e.KeyChar = Convert.ToChar(Keys.Back) Then
            'nothing to do valid character
        Else
            e.KeyChar = ""
            txtname.Select()
            MsgBox("Enter only Alphabets", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Invalid Input")
        End If
    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged

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
End Class