<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BikeServices
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb1 = New System.Windows.Forms.ComboBox()
        Me.cmdREFRESH = New System.Windows.Forms.Button()
        Me.cmdDELETE = New System.Windows.Forms.Button()
        Me.cmdUPDATE = New System.Windows.Forms.Button()
        Me.cmdISELECT = New System.Windows.Forms.Button()
        Me.cmdINSERT = New System.Windows.Forms.Button()
        Me.txtServiceId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtServicedesc = New System.Windows.Forms.TextBox()
        Me.txtServiceCost = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(387, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.DividerHeight = 2
        Me.DataGridView1.Size = New System.Drawing.Size(729, 393)
        Me.DataGridView1.TabIndex = 15
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
        Me.GroupBox1.Controls.Add(Me.txtServiceId)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtServicedesc)
        Me.GroupBox1.Controls.Add(Me.txtServiceCost)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 393)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BIKE SERVICE INFROMATION"
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
        Me.cmdREFRESH.Location = New System.Drawing.Point(10, 338)
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
        Me.cmdDELETE.Location = New System.Drawing.Point(210, 241)
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
        Me.cmdUPDATE.Location = New System.Drawing.Point(210, 166)
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
        Me.cmdISELECT.Location = New System.Drawing.Point(38, 241)
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
        Me.cmdINSERT.Location = New System.Drawing.Point(38, 166)
        Me.cmdINSERT.Name = "cmdINSERT"
        Me.cmdINSERT.Size = New System.Drawing.Size(134, 67)
        Me.cmdINSERT.TabIndex = 8
        Me.cmdINSERT.Text = "SAVE"
        Me.cmdINSERT.UseVisualStyleBackColor = True
        '
        'txtServiceId
        '
        Me.txtServiceId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceId.Location = New System.Drawing.Point(219, 30)
        Me.txtServiceId.Name = "txtServiceId"
        Me.txtServiceId.Size = New System.Drawing.Size(113, 22)
        Me.txtServiceId.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Service Identification:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cost Service:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Service Description:"
        '
        'txtServicedesc
        '
        Me.txtServicedesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServicedesc.Location = New System.Drawing.Point(219, 73)
        Me.txtServicedesc.Name = "txtServicedesc"
        Me.txtServicedesc.Size = New System.Drawing.Size(113, 22)
        Me.txtServicedesc.TabIndex = 0
        '
        'txtServiceCost
        '
        Me.txtServiceCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceCost.Location = New System.Drawing.Point(219, 117)
        Me.txtServiceCost.Name = "txtServiceCost"
        Me.txtServiceCost.Size = New System.Drawing.Size(113, 22)
        Me.txtServiceCost.TabIndex = 1
        '
        'BikeServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 393)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BikeServices"
        Me.Text = "BikeServices"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmb1 As ComboBox
    Friend WithEvents cmdREFRESH As Button
    Friend WithEvents cmdDELETE As Button
    Friend WithEvents cmdUPDATE As Button
    Friend WithEvents cmdISELECT As Button
    Friend WithEvents cmdINSERT As Button
    Friend WithEvents txtServiceId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtServicedesc As TextBox
    Friend WithEvents txtServiceCost As TextBox
End Class
