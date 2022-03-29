<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerBikeTransaction
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmb3 = New System.Windows.Forms.ComboBox()
        Me.cmb2 = New System.Windows.Forms.ComboBox()
        Me.cmb1 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMechAddr = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMechname = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMechID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCusAddr = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCustnumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCusname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCostService = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOD = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtServDesc = New System.Windows.Forms.TextBox()
        Me.txtOS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtServID = New System.Windows.Forms.TextBox()
        Me.Dgrid1 = New System.Windows.Forms.DataGridView()
        Me.cOD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cServID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cServDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cServCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCust = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCusname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCusAddr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMechID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMechName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMechAddr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dgrid2 = New System.Windows.Forms.DataGridView()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdFinisOrder = New System.Windows.Forms.Button()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dgrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmb3)
        Me.GroupBox1.Controls.Add(Me.cmb2)
        Me.GroupBox1.Controls.Add(Me.cmb1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtMechAddr)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtMechname)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtMechID)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtCusAddr)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtCustnumber)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCusname)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtCustID)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCostService)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtOD)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtServDesc)
        Me.GroupBox1.Controls.Add(Me.txtOS)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtServID)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(4, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 728)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bike Service Trasaction"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(185, 612)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(92, 26)
        Me.txtSearch.TabIndex = 39
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(30, 615)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 23)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "SEARCH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmb3
        '
        Me.cmb3.FormattingEnabled = True
        Me.cmb3.Location = New System.Drawing.Point(304, 498)
        Me.cmb3.Name = "cmb3"
        Me.cmb3.Size = New System.Drawing.Size(48, 28)
        Me.cmb3.TabIndex = 33
        '
        'cmb2
        '
        Me.cmb2.FormattingEnabled = True
        Me.cmb2.Location = New System.Drawing.Point(304, 307)
        Me.cmb2.Name = "cmb2"
        Me.cmb2.Size = New System.Drawing.Size(48, 28)
        Me.cmb2.TabIndex = 32
        '
        'cmb1
        '
        Me.cmb1.FormattingEnabled = True
        Me.cmb1.Location = New System.Drawing.Point(307, 152)
        Me.cmb1.Name = "cmb1"
        Me.cmb1.Size = New System.Drawing.Size(48, 28)
        Me.cmb1.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Enabled = False
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 566)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(151, 18)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Mechanic Address:"
        '
        'txtMechAddr
        '
        Me.txtMechAddr.Location = New System.Drawing.Point(167, 562)
        Me.txtMechAddr.Name = "txtMechAddr"
        Me.txtMechAddr.Size = New System.Drawing.Size(134, 26)
        Me.txtMechAddr.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Enabled = False
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 534)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 18)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Mechanic name:"
        '
        'txtMechname
        '
        Me.txtMechname.Location = New System.Drawing.Point(167, 530)
        Me.txtMechname.Name = "txtMechname"
        Me.txtMechname.Size = New System.Drawing.Size(134, 26)
        Me.txtMechname.TabIndex = 24
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Enabled = False
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 502)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 18)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Mechanic ID:"
        '
        'txtMechID
        '
        Me.txtMechID.Location = New System.Drawing.Point(167, 498)
        Me.txtMechID.Name = "txtMechID"
        Me.txtMechID.Size = New System.Drawing.Size(134, 26)
        Me.txtMechID.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 407)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 18)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Customer Address:"
        '
        'txtCusAddr
        '
        Me.txtCusAddr.Location = New System.Drawing.Point(167, 403)
        Me.txtCusAddr.Name = "txtCusAddr"
        Me.txtCusAddr.Size = New System.Drawing.Size(134, 26)
        Me.txtCusAddr.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 375)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 18)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Customer Number:"
        '
        'txtCustnumber
        '
        Me.txtCustnumber.Location = New System.Drawing.Point(167, 371)
        Me.txtCustnumber.Name = "txtCustnumber"
        Me.txtCustnumber.Size = New System.Drawing.Size(134, 26)
        Me.txtCustnumber.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 343)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 18)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Customer Name:"
        '
        'txtCusname
        '
        Me.txtCusname.Location = New System.Drawing.Point(167, 339)
        Me.txtCusname.Name = "txtCusname"
        Me.txtCusname.Size = New System.Drawing.Size(134, 26)
        Me.txtCusname.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 311)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 18)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Customer ID:"
        '
        'txtCustID
        '
        Me.txtCustID.Location = New System.Drawing.Point(167, 307)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(134, 26)
        Me.txtCustID.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Service Cost:"
        '
        'txtCostService
        '
        Me.txtCostService.Location = New System.Drawing.Point(167, 222)
        Me.txtCostService.Name = "txtCostService"
        Me.txtCostService.Size = New System.Drawing.Size(134, 26)
        Me.txtCostService.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Date Start:"
        '
        'txtOD
        '
        Me.txtOD.Location = New System.Drawing.Point(170, 37)
        Me.txtOD.Name = "txtOD"
        Me.txtOD.Size = New System.Drawing.Size(134, 26)
        Me.txtOD.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Service Description:"
        '
        'txtServDesc
        '
        Me.txtServDesc.Location = New System.Drawing.Point(167, 186)
        Me.txtServDesc.Name = "txtServDesc"
        Me.txtServDesc.Size = New System.Drawing.Size(134, 26)
        Me.txtServDesc.TabIndex = 8
        '
        'txtOS
        '
        Me.txtOS.Location = New System.Drawing.Point(170, 73)
        Me.txtOS.Name = "txtOS"
        Me.txtOS.Size = New System.Drawing.Size(134, 26)
        Me.txtOS.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Date Finish:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Service ID:"
        '
        'txtServID
        '
        Me.txtServID.Location = New System.Drawing.Point(167, 152)
        Me.txtServID.Name = "txtServID"
        Me.txtServID.Size = New System.Drawing.Size(134, 26)
        Me.txtServID.TabIndex = 2
        '
        'Dgrid1
        '
        Me.Dgrid1.AllowUserToAddRows = False
        Me.Dgrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cOD, Me.cOS, Me.cServID, Me.cServDesc, Me.cServCost, Me.cCust, Me.cCusname, Me.cNum, Me.cCusAddr, Me.cMechID, Me.cMechName, Me.cMechAddr})
        Me.Dgrid1.Location = New System.Drawing.Point(375, 12)
        Me.Dgrid1.Name = "Dgrid1"
        Me.Dgrid1.Size = New System.Drawing.Size(866, 307)
        Me.Dgrid1.TabIndex = 1
        '
        'cOD
        '
        Me.cOD.HeaderText = "Date Start"
        Me.cOD.Name = "cOD"
        '
        'cOS
        '
        Me.cOS.HeaderText = "Date Finish"
        Me.cOS.Name = "cOS"
        '
        'cServID
        '
        Me.cServID.HeaderText = "Service ID"
        Me.cServID.Name = "cServID"
        '
        'cServDesc
        '
        Me.cServDesc.HeaderText = "Service Description"
        Me.cServDesc.Name = "cServDesc"
        '
        'cServCost
        '
        Me.cServCost.HeaderText = "Service Cost"
        Me.cServCost.Name = "cServCost"
        '
        'cCust
        '
        Me.cCust.HeaderText = "Customer ID"
        Me.cCust.Name = "cCust"
        '
        'cCusname
        '
        Me.cCusname.HeaderText = "Customer Name"
        Me.cCusname.Name = "cCusname"
        '
        'cNum
        '
        Me.cNum.HeaderText = "Customer Number"
        Me.cNum.Name = "cNum"
        '
        'cCusAddr
        '
        Me.cCusAddr.HeaderText = "Customer Address"
        Me.cCusAddr.Name = "cCusAddr"
        '
        'cMechID
        '
        Me.cMechID.HeaderText = "Mechanic ID"
        Me.cMechID.Name = "cMechID"
        '
        'cMechName
        '
        Me.cMechName.HeaderText = "Mechanic Name"
        Me.cMechName.Name = "cMechName"
        '
        'cMechAddr
        '
        Me.cMechAddr.HeaderText = "Mechanic Address"
        Me.cMechAddr.Name = "cMechAddr"
        '
        'Dgrid2
        '
        Me.Dgrid2.AllowUserToAddRows = False
        Me.Dgrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgrid2.Location = New System.Drawing.Point(375, 375)
        Me.Dgrid2.Name = "Dgrid2"
        Me.Dgrid2.Size = New System.Drawing.Size(866, 365)
        Me.Dgrid2.TabIndex = 2
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.ForeColor = System.Drawing.Color.Black
        Me.cmdAdd.Location = New System.Drawing.Point(440, 328)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(158, 41)
        Me.cmdAdd.TabIndex = 34
        Me.cmdAdd.Text = "ADD TO CART"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.Color.Black
        Me.cmdCancel.Location = New System.Drawing.Point(631, 328)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(158, 41)
        Me.cmdCancel.TabIndex = 35
        Me.cmdCancel.Text = "CANCEL ORDER"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdFinisOrder
        '
        Me.cmdFinisOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFinisOrder.ForeColor = System.Drawing.Color.Black
        Me.cmdFinisOrder.Location = New System.Drawing.Point(1019, 328)
        Me.cmdFinisOrder.Name = "cmdFinisOrder"
        Me.cmdFinisOrder.Size = New System.Drawing.Size(158, 41)
        Me.cmdFinisOrder.TabIndex = 36
        Me.cmdFinisOrder.Text = "CHECK OUT"
        Me.cmdFinisOrder.UseVisualStyleBackColor = True
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.ForeColor = System.Drawing.Color.Black
        Me.cmdRefresh.Location = New System.Drawing.Point(825, 327)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(158, 41)
        Me.cmdRefresh.TabIndex = 37
        Me.cmdRefresh.Text = "RELOAD"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(163, 674)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Total"
        '
        'CustomerBikeTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1245, 752)
        Me.Controls.Add(Me.cmdFinisOrder)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.Dgrid2)
        Me.Controls.Add(Me.Dgrid1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdAdd)
        Me.Name = "CustomerBikeTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerBikeTransaction"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dgrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCostService As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtOD As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtServDesc As TextBox
    Friend WithEvents txtOS As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtServID As TextBox
    Friend WithEvents Dgrid1 As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents txtMechAddr As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtMechname As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtMechID As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCusAddr As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCustnumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCusname As TextBox
    Friend WithEvents Dgrid2 As DataGridView
    Friend WithEvents cmb3 As ComboBox
    Friend WithEvents cmb2 As ComboBox
    Friend WithEvents cmb1 As ComboBox
    Friend WithEvents cmdAdd As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdFinisOrder As Button
    Friend WithEvents cmdRefresh As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cOD As DataGridViewTextBoxColumn
    Friend WithEvents cOS As DataGridViewTextBoxColumn
    Friend WithEvents cServID As DataGridViewTextBoxColumn
    Friend WithEvents cServDesc As DataGridViewTextBoxColumn
    Friend WithEvents cServCost As DataGridViewTextBoxColumn
    Friend WithEvents cCust As DataGridViewTextBoxColumn
    Friend WithEvents cCusname As DataGridViewTextBoxColumn
    Friend WithEvents cNum As DataGridViewTextBoxColumn
    Friend WithEvents cCusAddr As DataGridViewTextBoxColumn
    Friend WithEvents cMechID As DataGridViewTextBoxColumn
    Friend WithEvents cMechName As DataGridViewTextBoxColumn
    Friend WithEvents cMechAddr As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
End Class
