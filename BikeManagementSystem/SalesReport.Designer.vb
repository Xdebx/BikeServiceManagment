<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesReport
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
        Me.Dgrid1 = New System.Windows.Forms.DataGridView()
        Me.Dgrid2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtOrderSaleGrandTotal = New System.Windows.Forms.TextBox()
        Me.txtServiceSalesGrandTotal = New System.Windows.Forms.TextBox()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cmdDaily = New System.Windows.Forms.Button()
        Me.cmdMonthly = New System.Windows.Forms.Button()
        Me.cmdYearly = New System.Windows.Forms.Button()
        CType(Me.Dgrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgrid1
        '
        Me.Dgrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgrid1.Location = New System.Drawing.Point(3, 18)
        Me.Dgrid1.Name = "Dgrid1"
        Me.Dgrid1.Size = New System.Drawing.Size(800, 303)
        Me.Dgrid1.TabIndex = 0
        '
        'Dgrid2
        '
        Me.Dgrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgrid2.Location = New System.Drawing.Point(3, 18)
        Me.Dgrid2.Name = "Dgrid2"
        Me.Dgrid2.Size = New System.Drawing.Size(800, 303)
        Me.Dgrid2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dgrid1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(806, 324)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Sales"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Dgrid2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 339)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(806, 324)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Service Sales"
        '
        'txtOrderSaleGrandTotal
        '
        Me.txtOrderSaleGrandTotal.Enabled = False
        Me.txtOrderSaleGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderSaleGrandTotal.Location = New System.Drawing.Point(824, 47)
        Me.txtOrderSaleGrandTotal.Multiline = True
        Me.txtOrderSaleGrandTotal.Name = "txtOrderSaleGrandTotal"
        Me.txtOrderSaleGrandTotal.Size = New System.Drawing.Size(209, 48)
        Me.txtOrderSaleGrandTotal.TabIndex = 4
        '
        'txtServiceSalesGrandTotal
        '
        Me.txtServiceSalesGrandTotal.Enabled = False
        Me.txtServiceSalesGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceSalesGrandTotal.Location = New System.Drawing.Point(824, 583)
        Me.txtServiceSalesGrandTotal.Multiline = True
        Me.txtServiceSalesGrandTotal.Name = "txtServiceSalesGrandTotal"
        Me.txtServiceSalesGrandTotal.Size = New System.Drawing.Size(209, 48)
        Me.txtServiceSalesGrandTotal.TabIndex = 5
        '
        'btnReport
        '
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Location = New System.Drawing.Point(1025, 288)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(209, 63)
        Me.btnReport.TabIndex = 6
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(865, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Grand Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(865, 634)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Grand Total"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(1047, 47)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'cmdDaily
        '
        Me.cmdDaily.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDaily.Location = New System.Drawing.Point(958, 223)
        Me.cmdDaily.Name = "cmdDaily"
        Me.cmdDaily.Size = New System.Drawing.Size(75, 59)
        Me.cmdDaily.TabIndex = 10
        Me.cmdDaily.Text = "Daily"
        Me.cmdDaily.UseVisualStyleBackColor = True
        '
        'cmdMonthly
        '
        Me.cmdMonthly.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMonthly.Location = New System.Drawing.Point(1090, 223)
        Me.cmdMonthly.Name = "cmdMonthly"
        Me.cmdMonthly.Size = New System.Drawing.Size(75, 59)
        Me.cmdMonthly.TabIndex = 11
        Me.cmdMonthly.Text = "Monthly"
        Me.cmdMonthly.UseVisualStyleBackColor = True
        '
        'cmdYearly
        '
        Me.cmdYearly.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdYearly.Location = New System.Drawing.Point(1171, 223)
        Me.cmdYearly.Name = "cmdYearly"
        Me.cmdYearly.Size = New System.Drawing.Size(75, 59)
        Me.cmdYearly.TabIndex = 12
        Me.cmdYearly.Text = "Yearly"
        Me.cmdYearly.UseVisualStyleBackColor = True
        '
        'SalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1259, 668)
        Me.Controls.Add(Me.cmdYearly)
        Me.Controls.Add(Me.cmdMonthly)
        Me.Controls.Add(Me.cmdDaily)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.txtServiceSalesGrandTotal)
        Me.Controls.Add(Me.txtOrderSaleGrandTotal)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SalesReport"
        Me.Text = "SalesReport"
        CType(Me.Dgrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgrid1 As DataGridView
    Friend WithEvents Dgrid2 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtOrderSaleGrandTotal As TextBox
    Friend WithEvents txtServiceSalesGrandTotal As TextBox
    Friend WithEvents btnReport As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cmdDaily As Button
    Friend WithEvents cmdMonthly As Button
    Friend WithEvents cmdYearly As Button
End Class
