<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtCusname = New System.Windows.Forms.TextBox()
        Me.txtCusphone = New System.Windows.Forms.TextBox()
        Me.txtCusaddress = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb1 = New System.Windows.Forms.ComboBox()
        Me.cmdREFRESH = New System.Windows.Forms.Button()
        Me.cmdDELETE = New System.Windows.Forms.Button()
        Me.cmdUPDATE = New System.Windows.Forms.Button()
        Me.cmdISELECT = New System.Windows.Forms.Button()
        Me.cmdINSERT = New System.Windows.Forms.Button()
        Me.txtCusid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCusname
        '
        Me.txtCusname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusname.Location = New System.Drawing.Point(200, 74)
        Me.txtCusname.Name = "txtCusname"
        Me.txtCusname.Size = New System.Drawing.Size(113, 22)
        Me.txtCusname.TabIndex = 0
        '
        'txtCusphone
        '
        Me.txtCusphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusphone.Location = New System.Drawing.Point(200, 118)
        Me.txtCusphone.Name = "txtCusphone"
        Me.txtCusphone.Size = New System.Drawing.Size(113, 22)
        Me.txtCusphone.TabIndex = 1
        '
        'txtCusaddress
        '
        Me.txtCusaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusaddress.Location = New System.Drawing.Point(200, 163)
        Me.txtCusaddress.Name = "txtCusaddress"
        Me.txtCusaddress.Size = New System.Drawing.Size(113, 22)
        Me.txtCusaddress.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cmb1)
        Me.GroupBox1.Controls.Add(Me.cmdREFRESH)
        Me.GroupBox1.Controls.Add(Me.cmdDELETE)
        Me.GroupBox1.Controls.Add(Me.cmdUPDATE)
        Me.GroupBox1.Controls.Add(Me.cmdISELECT)
        Me.GroupBox1.Controls.Add(Me.cmdINSERT)
        Me.GroupBox1.Controls.Add(Me.txtCusid)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCusname)
        Me.GroupBox1.Controls.Add(Me.txtCusphone)
        Me.GroupBox1.Controls.Add(Me.txtCusaddress)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 488)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CUSTOMER INFROMATION"
        '
        'cmb1
        '
        Me.cmb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb1.FormattingEnabled = True
        Me.cmb1.Location = New System.Drawing.Point(319, 31)
        Me.cmb1.Name = "cmb1"
        Me.cmb1.Size = New System.Drawing.Size(43, 24)
        Me.cmb1.TabIndex = 13
        '
        'cmdREFRESH
        '
        Me.cmdREFRESH.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdREFRESH.Location = New System.Drawing.Point(28, 400)
        Me.cmdREFRESH.Name = "cmdREFRESH"
        Me.cmdREFRESH.Size = New System.Drawing.Size(306, 43)
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
        Me.cmdDELETE.Location = New System.Drawing.Point(200, 299)
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
        Me.cmdUPDATE.Location = New System.Drawing.Point(200, 224)
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
        Me.cmdISELECT.Location = New System.Drawing.Point(28, 299)
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
        Me.cmdINSERT.Location = New System.Drawing.Point(28, 224)
        Me.cmdINSERT.Name = "cmdINSERT"
        Me.cmdINSERT.Size = New System.Drawing.Size(134, 67)
        Me.cmdINSERT.TabIndex = 8
        Me.cmdINSERT.Text = "SAVE"
        Me.cmdINSERT.UseVisualStyleBackColor = True
        '
        'txtCusid
        '
        Me.txtCusid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusid.Location = New System.Drawing.Point(200, 31)
        Me.txtCusid.Name = "txtCusid"
        Me.txtCusid.Size = New System.Drawing.Size(113, 22)
        Me.txtCusid.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Customer Identification:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Customer Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Customer Phone:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Customer name:"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cyan
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(381, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.DividerHeight = 2
        Me.DataGridView1.Size = New System.Drawing.Size(706, 487)
        Me.DataGridView1.TabIndex = 9
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1088, 488)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtCusname As TextBox
    Friend WithEvents txtCusphone As TextBox
    Friend WithEvents txtCusaddress As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCusid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdREFRESH As Button
    Friend WithEvents cmdDELETE As Button
    Friend WithEvents cmdUPDATE As Button
    Friend WithEvents cmdISELECT As Button
    Friend WithEvents cmdINSERT As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmb1 As ComboBox
End Class
