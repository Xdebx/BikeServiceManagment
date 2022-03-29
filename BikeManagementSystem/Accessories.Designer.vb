<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accessories
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtItemCat = New System.Windows.Forms.TextBox()
        Me.cmb1 = New System.Windows.Forms.ComboBox()
        Me.cmdREFRESH = New System.Windows.Forms.Button()
        Me.cmdDELETE = New System.Windows.Forms.Button()
        Me.cmdUPDATE = New System.Windows.Forms.Button()
        Me.cmdISELECT = New System.Windows.Forms.Button()
        Me.cmdINSERT = New System.Windows.Forms.Button()
        Me.txtAccessId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAccessdesc = New System.Windows.Forms.TextBox()
        Me.txtAccesscp = New System.Windows.Forms.TextBox()
        Me.txtAccessprice = New System.Windows.Forms.TextBox()
        Me.cmb3 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAccessBrand = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Location = New System.Drawing.Point(388, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.DividerHeight = 2
        Me.DataGridView1.Size = New System.Drawing.Size(729, 513)
        Me.DataGridView1.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cmb3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtAccessBrand)
        Me.GroupBox1.Controls.Add(Me.cmb2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtItemCat)
        Me.GroupBox1.Controls.Add(Me.cmb1)
        Me.GroupBox1.Controls.Add(Me.cmdREFRESH)
        Me.GroupBox1.Controls.Add(Me.cmdDELETE)
        Me.GroupBox1.Controls.Add(Me.cmdUPDATE)
        Me.GroupBox1.Controls.Add(Me.cmdISELECT)
        Me.GroupBox1.Controls.Add(Me.cmdINSERT)
        Me.GroupBox1.Controls.Add(Me.txtAccessId)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtAccessdesc)
        Me.GroupBox1.Controls.Add(Me.txtAccesscp)
        Me.GroupBox1.Controls.Add(Me.txtAccessprice)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 513)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ACCESSORIES INFROMATION"
        '
        'cmb2
        '
        Me.cmb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb2.FormattingEnabled = True
        Me.cmb2.Location = New System.Drawing.Point(338, 203)
        Me.cmb2.Name = "cmb2"
        Me.cmb2.Size = New System.Drawing.Size(43, 24)
        Me.cmb2.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 18)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Item Category:"
        '
        'txtItemCat
        '
        Me.txtItemCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCat.Location = New System.Drawing.Point(220, 203)
        Me.txtItemCat.Name = "txtItemCat"
        Me.txtItemCat.Size = New System.Drawing.Size(113, 22)
        Me.txtItemCat.TabIndex = 14
        '
        'cmb1
        '
        Me.cmb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb1.FormattingEnabled = True
        Me.cmb1.Location = New System.Drawing.Point(338, 30)
        Me.cmb1.Name = "cmb1"
        Me.cmb1.Size = New System.Drawing.Size(43, 24)
        Me.cmb1.TabIndex = 13
        '
        'cmdREFRESH
        '
        Me.cmdREFRESH.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdREFRESH.Location = New System.Drawing.Point(6, 461)
        Me.cmdREFRESH.Name = "cmdREFRESH"
        Me.cmdREFRESH.Size = New System.Drawing.Size(368, 43)
        Me.cmdREFRESH.TabIndex = 12
        Me.cmdREFRESH.Text = "REFRESH"
        Me.cmdREFRESH.UseVisualStyleBackColor = True
        '
        'cmdDELETE
        '
        Me.cmdDELETE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdDELETE.FlatAppearance.BorderSize = 2
        Me.cmdDELETE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.cmdDELETE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.cmdDELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDELETE.ForeColor = System.Drawing.Color.Black
        Me.cmdDELETE.Location = New System.Drawing.Point(209, 382)
        Me.cmdDELETE.Name = "cmdDELETE"
        Me.cmdDELETE.Size = New System.Drawing.Size(134, 67)
        Me.cmdDELETE.TabIndex = 11
        Me.cmdDELETE.Text = "DELETE"
        Me.cmdDELETE.UseVisualStyleBackColor = True
        '
        'cmdUPDATE
        '
        Me.cmdUPDATE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdUPDATE.FlatAppearance.BorderSize = 2
        Me.cmdUPDATE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.cmdUPDATE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.cmdUPDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUPDATE.ForeColor = System.Drawing.Color.Black
        Me.cmdUPDATE.Location = New System.Drawing.Point(209, 307)
        Me.cmdUPDATE.Name = "cmdUPDATE"
        Me.cmdUPDATE.Size = New System.Drawing.Size(134, 67)
        Me.cmdUPDATE.TabIndex = 10
        Me.cmdUPDATE.Text = "EDIT"
        Me.cmdUPDATE.UseVisualStyleBackColor = True
        '
        'cmdISELECT
        '
        Me.cmdISELECT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdISELECT.FlatAppearance.BorderSize = 2
        Me.cmdISELECT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.cmdISELECT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.cmdISELECT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdISELECT.ForeColor = System.Drawing.Color.Black
        Me.cmdISELECT.Location = New System.Drawing.Point(37, 382)
        Me.cmdISELECT.Name = "cmdISELECT"
        Me.cmdISELECT.Size = New System.Drawing.Size(134, 67)
        Me.cmdISELECT.TabIndex = 9
        Me.cmdISELECT.Text = "VIEW"
        Me.cmdISELECT.UseVisualStyleBackColor = True
        '
        'cmdINSERT
        '
        Me.cmdINSERT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdINSERT.FlatAppearance.BorderSize = 2
        Me.cmdINSERT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.cmdINSERT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.cmdINSERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdINSERT.ForeColor = System.Drawing.Color.Black
        Me.cmdINSERT.Location = New System.Drawing.Point(37, 307)
        Me.cmdINSERT.Name = "cmdINSERT"
        Me.cmdINSERT.Size = New System.Drawing.Size(134, 67)
        Me.cmdINSERT.TabIndex = 8
        Me.cmdINSERT.Text = "SAVE"
        Me.cmdINSERT.UseVisualStyleBackColor = True
        '
        'txtAccessId
        '
        Me.txtAccessId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccessId.Location = New System.Drawing.Point(219, 30)
        Me.txtAccessId.Name = "txtAccessId"
        Me.txtAccessId.Size = New System.Drawing.Size(113, 22)
        Me.txtAccessId.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Accessories Identification:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Accessories Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Accessories Cost Price:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Accessories Description:"
        '
        'txtAccessdesc
        '
        Me.txtAccessdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccessdesc.Location = New System.Drawing.Point(219, 73)
        Me.txtAccessdesc.Name = "txtAccessdesc"
        Me.txtAccessdesc.Size = New System.Drawing.Size(113, 22)
        Me.txtAccessdesc.TabIndex = 0
        '
        'txtAccesscp
        '
        Me.txtAccesscp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccesscp.Location = New System.Drawing.Point(219, 117)
        Me.txtAccesscp.Name = "txtAccesscp"
        Me.txtAccesscp.Size = New System.Drawing.Size(113, 22)
        Me.txtAccesscp.TabIndex = 1
        '
        'txtAccessprice
        '
        Me.txtAccessprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccessprice.Location = New System.Drawing.Point(219, 162)
        Me.txtAccessprice.Name = "txtAccessprice"
        Me.txtAccessprice.Size = New System.Drawing.Size(113, 22)
        Me.txtAccessprice.TabIndex = 2
        '
        'cmb3
        '
        Me.cmb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb3.FormattingEnabled = True
        Me.cmb3.Location = New System.Drawing.Point(338, 243)
        Me.cmb3.Name = "cmb3"
        Me.cmb3.Size = New System.Drawing.Size(43, 24)
        Me.cmb3.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 18)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Item Brand:"
        '
        'txtAccessBrand
        '
        Me.txtAccessBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccessBrand.Location = New System.Drawing.Point(220, 243)
        Me.txtAccessBrand.Name = "txtAccessBrand"
        Me.txtAccessBrand.Size = New System.Drawing.Size(113, 22)
        Me.txtAccessBrand.TabIndex = 17
        '
        'Accessories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 513)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Accessories"
        Me.Text = "Accessories"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmb2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtItemCat As TextBox
    Friend WithEvents cmb1 As ComboBox
    Friend WithEvents cmdREFRESH As Button
    Friend WithEvents cmdDELETE As Button
    Friend WithEvents cmdUPDATE As Button
    Friend WithEvents cmdISELECT As Button
    Friend WithEvents cmdINSERT As Button
    Friend WithEvents txtAccessId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAccessdesc As TextBox
    Friend WithEvents txtAccesscp As TextBox
    Friend WithEvents txtAccessprice As TextBox
    Friend WithEvents cmb3 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAccessBrand As TextBox
End Class
