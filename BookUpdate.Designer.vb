<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookUpdate
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
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblisbn = New System.Windows.Forms.Label
        Me.btnlast = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnPrev = New System.Windows.Forms.Button
        Me.btnfirst = New System.Windows.Forms.Button
        Me.txtBqty = New System.Windows.Forms.TextBox
        Me.txtBprice = New System.Windows.Forms.TextBox
        Me.txtBedition = New System.Windows.Forms.TextBox
        Me.txtBpublication = New System.Windows.Forms.TextBox
        Me.txtBauth = New System.Windows.Forms.TextBox
        Me.txtBname = New System.Windows.Forms.TextBox
        Me.txtISBN = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Black
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(534, 323)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(169, 47)
        Me.btnsave.TabIndex = 14
        Me.btnsave.Text = "UPDATE BOOK DETAILS"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(48, 370)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "QUANTITY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(48, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "EDITION"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(-1, -1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(26, 22)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(48, 318)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "PRICE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(48, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "PUBLICATION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(48, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "AUTHOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(48, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "BOOK NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(48, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ISBN"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblisbn)
        Me.Panel1.Controls.Add(Me.btnlast)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.btnPrev)
        Me.Panel1.Controls.Add(Me.btnfirst)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtBqty)
        Me.Panel1.Controls.Add(Me.txtBprice)
        Me.Panel1.Controls.Add(Me.txtBedition)
        Me.Panel1.Controls.Add(Me.txtBpublication)
        Me.Panel1.Controls.Add(Me.txtBauth)
        Me.Panel1.Controls.Add(Me.txtBname)
        Me.Panel1.Controls.Add(Me.txtISBN)
        Me.Panel1.Location = New System.Drawing.Point(247, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(735, 512)
        Me.Panel1.TabIndex = 10
        '
        'lblisbn
        '
        Me.lblisbn.AutoSize = True
        Me.lblisbn.ForeColor = System.Drawing.Color.White
        Me.lblisbn.Location = New System.Drawing.Point(237, 81)
        Me.lblisbn.Name = "lblisbn"
        Me.lblisbn.Size = New System.Drawing.Size(32, 13)
        Me.lblisbn.TabIndex = 19
        Me.lblisbn.Text = "ISBN"
        '
        'btnlast
        '
        Me.btnlast.BackColor = System.Drawing.Color.Black
        Me.btnlast.ForeColor = System.Drawing.Color.White
        Me.btnlast.Location = New System.Drawing.Point(534, 270)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(169, 47)
        Me.btnlast.TabIndex = 18
        Me.btnlast.Text = ">>|"
        Me.btnlast.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Black
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(534, 217)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(169, 47)
        Me.btnNext.TabIndex = 17
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.Black
        Me.btnPrev.ForeColor = System.Drawing.Color.White
        Me.btnPrev.Location = New System.Drawing.Point(534, 164)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(169, 47)
        Me.btnPrev.TabIndex = 16
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'btnfirst
        '
        Me.btnfirst.BackColor = System.Drawing.Color.Black
        Me.btnfirst.ForeColor = System.Drawing.Color.White
        Me.btnfirst.Location = New System.Drawing.Point(534, 111)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(169, 47)
        Me.btnfirst.TabIndex = 15
        Me.btnfirst.Text = "|<<"
        Me.btnfirst.UseVisualStyleBackColor = False
        '
        'txtBqty
        '
        Me.txtBqty.BackColor = System.Drawing.Color.Silver
        Me.txtBqty.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBqty.Location = New System.Drawing.Point(237, 366)
        Me.txtBqty.Name = "txtBqty"
        Me.txtBqty.Size = New System.Drawing.Size(133, 24)
        Me.txtBqty.TabIndex = 6
        '
        'txtBprice
        '
        Me.txtBprice.BackColor = System.Drawing.Color.Silver
        Me.txtBprice.Enabled = False
        Me.txtBprice.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBprice.Location = New System.Drawing.Point(237, 314)
        Me.txtBprice.Name = "txtBprice"
        Me.txtBprice.Size = New System.Drawing.Size(133, 24)
        Me.txtBprice.TabIndex = 5
        '
        'txtBedition
        '
        Me.txtBedition.BackColor = System.Drawing.Color.Silver
        Me.txtBedition.Enabled = False
        Me.txtBedition.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBedition.Location = New System.Drawing.Point(237, 259)
        Me.txtBedition.Name = "txtBedition"
        Me.txtBedition.Size = New System.Drawing.Size(133, 24)
        Me.txtBedition.TabIndex = 4
        '
        'txtBpublication
        '
        Me.txtBpublication.BackColor = System.Drawing.Color.Silver
        Me.txtBpublication.Enabled = False
        Me.txtBpublication.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBpublication.Location = New System.Drawing.Point(237, 209)
        Me.txtBpublication.Name = "txtBpublication"
        Me.txtBpublication.Size = New System.Drawing.Size(217, 24)
        Me.txtBpublication.TabIndex = 3
        '
        'txtBauth
        '
        Me.txtBauth.BackColor = System.Drawing.Color.Silver
        Me.txtBauth.Enabled = False
        Me.txtBauth.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBauth.Location = New System.Drawing.Point(237, 160)
        Me.txtBauth.Name = "txtBauth"
        Me.txtBauth.Size = New System.Drawing.Size(217, 24)
        Me.txtBauth.TabIndex = 2
        '
        'txtBname
        '
        Me.txtBname.BackColor = System.Drawing.Color.Silver
        Me.txtBname.Enabled = False
        Me.txtBname.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBname.Location = New System.Drawing.Point(237, 111)
        Me.txtBname.Name = "txtBname"
        Me.txtBname.Size = New System.Drawing.Size(217, 24)
        Me.txtBname.TabIndex = 1
        '
        'txtISBN
        '
        Me.txtISBN.BackColor = System.Drawing.Color.Silver
        Me.txtISBN.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISBN.Location = New System.Drawing.Point(237, 54)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(178, 24)
        Me.txtISBN.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Mistral", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(575, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 26)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "UPDATE BOOK DETAILS"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(300, 712)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(743, 114)
        Me.DataGridView1.TabIndex = 12
        '
        'BookUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1490, 880)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BookUpdate"
        Me.Opacity = 0.9
        Me.Text = "BookUpdate"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtBqty As System.Windows.Forms.TextBox
    Friend WithEvents txtBprice As System.Windows.Forms.TextBox
    Friend WithEvents txtBedition As System.Windows.Forms.TextBox
    Friend WithEvents txtBpublication As System.Windows.Forms.TextBox
    Friend WithEvents txtBauth As System.Windows.Forms.TextBox
    Friend WithEvents txtBname As System.Windows.Forms.TextBox
    Friend WithEvents txtISBN As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnlast As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnfirst As System.Windows.Forms.Button
    Friend WithEvents lblisbn As System.Windows.Forms.Label
End Class
