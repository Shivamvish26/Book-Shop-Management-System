<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnsave = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.txtemail = New System.Windows.Forms.Label
        Me.txtadd = New System.Windows.Forms.Label
        Me.txtnam = New System.Windows.Forms.Label
        Me.txtmob = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtcemail = New System.Windows.Forms.TextBox
        Me.txtcadd = New System.Windows.Forms.TextBox
        Me.txtcname = New System.Windows.Forms.TextBox
        Me.txtcmob = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Black
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(222, 339)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(210, 33)
        Me.btnsave.TabIndex = 14
        Me.btnsave.Text = "SAVE CUSTOMER DETAILS"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(26, 22)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtemail
        '
        Me.txtemail.AutoSize = True
        Me.txtemail.ForeColor = System.Drawing.Color.White
        Me.txtemail.Location = New System.Drawing.Point(167, 266)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(53, 13)
        Me.txtemail.TabIndex = 10
        Me.txtemail.Text = "EMAIL ID"
        '
        'txtadd
        '
        Me.txtadd.AutoSize = True
        Me.txtadd.ForeColor = System.Drawing.Color.White
        Me.txtadd.Location = New System.Drawing.Point(167, 177)
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(59, 13)
        Me.txtadd.TabIndex = 9
        Me.txtadd.Text = "ADDRESS"
        '
        'txtnam
        '
        Me.txtnam.AutoSize = True
        Me.txtnam.ForeColor = System.Drawing.Color.White
        Me.txtnam.Location = New System.Drawing.Point(167, 128)
        Me.txtnam.Name = "txtnam"
        Me.txtnam.Size = New System.Drawing.Size(41, 13)
        Me.txtnam.TabIndex = 8
        Me.txtnam.Text = " NAME"
        '
        'txtmob
        '
        Me.txtmob.AutoSize = True
        Me.txtmob.ForeColor = System.Drawing.Color.White
        Me.txtmob.Location = New System.Drawing.Point(167, 71)
        Me.txtmob.Name = "txtmob"
        Me.txtmob.Size = New System.Drawing.Size(47, 13)
        Me.txtmob.TabIndex = 7
        Me.txtmob.Text = "MOBILE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.txtemail)
        Me.Panel1.Controls.Add(Me.txtadd)
        Me.Panel1.Controls.Add(Me.txtnam)
        Me.Panel1.Controls.Add(Me.txtmob)
        Me.Panel1.Controls.Add(Me.txtcemail)
        Me.Panel1.Controls.Add(Me.txtcadd)
        Me.Panel1.Controls.Add(Me.txtcname)
        Me.Panel1.Controls.Add(Me.txtcmob)
        Me.Panel1.Location = New System.Drawing.Point(29, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(735, 512)
        Me.Panel1.TabIndex = 10
        '
        'txtcemail
        '
        Me.txtcemail.BackColor = System.Drawing.Color.Silver
        Me.txtcemail.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcemail.Location = New System.Drawing.Point(356, 262)
        Me.txtcemail.Name = "txtcemail"
        Me.txtcemail.Size = New System.Drawing.Size(217, 24)
        Me.txtcemail.TabIndex = 3
        '
        'txtcadd
        '
        Me.txtcadd.BackColor = System.Drawing.Color.Silver
        Me.txtcadd.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcadd.Location = New System.Drawing.Point(356, 173)
        Me.txtcadd.Multiline = True
        Me.txtcadd.Name = "txtcadd"
        Me.txtcadd.Size = New System.Drawing.Size(248, 59)
        Me.txtcadd.TabIndex = 2
        '
        'txtcname
        '
        Me.txtcname.BackColor = System.Drawing.Color.Silver
        Me.txtcname.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcname.Location = New System.Drawing.Point(356, 124)
        Me.txtcname.Name = "txtcname"
        Me.txtcname.Size = New System.Drawing.Size(217, 24)
        Me.txtcname.TabIndex = 1
        '
        'txtcmob
        '
        Me.txtcmob.BackColor = System.Drawing.Color.Silver
        Me.txtcmob.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcmob.Location = New System.Drawing.Point(356, 67)
        Me.txtcmob.MaxLength = 10
        Me.txtcmob.Name = "txtcmob"
        Me.txtcmob.Size = New System.Drawing.Size(178, 24)
        Me.txtcmob.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Mistral", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(548, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(224, 26)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "ADD NEW CUSTOMERs DETAILS"
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(784, 584)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Customer"
        Me.Opacity = 0.9
        Me.Text = "Customer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtemail As System.Windows.Forms.Label
    Friend WithEvents txtadd As System.Windows.Forms.Label
    Friend WithEvents txtnam As System.Windows.Forms.Label
    Friend WithEvents txtmob As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtcemail As System.Windows.Forms.TextBox
    Friend WithEvents txtcadd As System.Windows.Forms.TextBox
    Friend WithEvents txtcname As System.Windows.Forms.TextBox
    Friend WithEvents txtcmob As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
