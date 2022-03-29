<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierTransaction
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdDelDataGrid = New System.Windows.Forms.Button()
        Me.txtAccessDesc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtProdDesc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdReload = New System.Windows.Forms.Button()
        Me.cmb2 = New System.Windows.Forms.ComboBox()
        Me.txtSourced = New System.Windows.Forms.TextBox()
        Me.txtDS = New System.Windows.Forms.TextBox()
        Me.txtDO = New System.Windows.Forms.TextBox()
        Me.txtTravel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdDONEorder = New System.Windows.Forms.Button()
        Me.cmdADDtoCART = New System.Windows.Forms.Button()
        Me.cmb4 = New System.Windows.Forms.ComboBox()
        Me.cmb3 = New System.Windows.Forms.ComboBox()
        Me.cmb1 = New System.Windows.Forms.ComboBox()
        Me.txtAccessQTY = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProdQTY = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAccessID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProdID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDeliveryID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dgrid1 = New System.Windows.Forms.DataGridView()
        Me.Dgrid2 = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtProdBrand = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAccessBrand = New System.Windows.Forms.TextBox()
        Me.cTravel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSource = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrdBrand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cProductQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAccessoriesID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cADesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAccessBrandd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAccessoriesQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dgrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtAccessBrand)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtProdBrand)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.cmdSearch)
        Me.GroupBox1.Controls.Add(Me.cmdDelDataGrid)
        Me.GroupBox1.Controls.Add(Me.txtAccessDesc)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtProdDesc)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmdReload)
        Me.GroupBox1.Controls.Add(Me.cmb2)
        Me.GroupBox1.Controls.Add(Me.txtSourced)
        Me.GroupBox1.Controls.Add(Me.txtDS)
        Me.GroupBox1.Controls.Add(Me.txtDO)
        Me.GroupBox1.Controls.Add(Me.txtTravel)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmdDONEorder)
        Me.GroupBox1.Controls.Add(Me.cmdADDtoCART)
        Me.GroupBox1.Controls.Add(Me.cmb4)
        Me.GroupBox1.Controls.Add(Me.cmb3)
        Me.GroupBox1.Controls.Add(Me.cmb1)
        Me.GroupBox1.Controls.Add(Me.txtAccessQTY)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtProdQTY)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtAccessID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtProdID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDeliveryID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 817)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DELIVERY INFORMATION"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(196, 765)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 30)
        Me.txtSearch.TabIndex = 31
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(61, 756)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(104, 45)
        Me.cmdSearch.TabIndex = 30
        Me.cmdSearch.Text = "SEARCH"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdDelDataGrid
        '
        Me.cmdDelDataGrid.Location = New System.Drawing.Point(45, 671)
        Me.cmdDelDataGrid.Name = "cmdDelDataGrid"
        Me.cmdDelDataGrid.Size = New System.Drawing.Size(145, 80)
        Me.cmdDelDataGrid.TabIndex = 29
        Me.cmdDelDataGrid.Text = "CANCEL ORDER"
        Me.cmdDelDataGrid.UseVisualStyleBackColor = True
        '
        'txtAccessDesc
        '
        Me.txtAccessDesc.Location = New System.Drawing.Point(196, 438)
        Me.txtAccessDesc.Name = "txtAccessDesc"
        Me.txtAccessDesc.Size = New System.Drawing.Size(100, 24)
        Me.txtAccessDesc.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 441)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(181, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Accessories Description:"
        '
        'txtProdDesc
        '
        Me.txtProdDesc.Location = New System.Drawing.Point(196, 261)
        Me.txtProdDesc.Name = "txtProdDesc"
        Me.txtProdDesc.Size = New System.Drawing.Size(100, 24)
        Me.txtProdDesc.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 264)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 16)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Product Description:"
        '
        'cmdReload
        '
        Me.cmdReload.Location = New System.Drawing.Point(196, 671)
        Me.cmdReload.Name = "cmdReload"
        Me.cmdReload.Size = New System.Drawing.Size(125, 80)
        Me.cmdReload.TabIndex = 24
        Me.cmdReload.Text = "RELOAD"
        Me.cmdReload.UseVisualStyleBackColor = True
        '
        'cmb2
        '
        Me.cmb2.FormattingEnabled = True
        Me.cmb2.Location = New System.Drawing.Point(302, 177)
        Me.cmb2.Name = "cmb2"
        Me.cmb2.Size = New System.Drawing.Size(108, 26)
        Me.cmb2.TabIndex = 23
        '
        'txtSourced
        '
        Me.txtSourced.Location = New System.Drawing.Point(196, 179)
        Me.txtSourced.Name = "txtSourced"
        Me.txtSourced.Size = New System.Drawing.Size(100, 24)
        Me.txtSourced.TabIndex = 22
        '
        'txtDS
        '
        Me.txtDS.Location = New System.Drawing.Point(196, 140)
        Me.txtDS.Name = "txtDS"
        Me.txtDS.Size = New System.Drawing.Size(100, 24)
        Me.txtDS.TabIndex = 21
        '
        'txtDO
        '
        Me.txtDO.Location = New System.Drawing.Point(196, 106)
        Me.txtDO.Name = "txtDO"
        Me.txtDO.Size = New System.Drawing.Size(100, 24)
        Me.txtDO.TabIndex = 20
        '
        'txtTravel
        '
        Me.txtTravel.Location = New System.Drawing.Point(196, 68)
        Me.txtTravel.Name = "txtTravel"
        Me.txtTravel.Size = New System.Drawing.Size(100, 24)
        Me.txtTravel.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Sourced From:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Date Shipped:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Date Order:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Travel Fee:"
        '
        'cmdDONEorder
        '
        Me.cmdDONEorder.Location = New System.Drawing.Point(196, 585)
        Me.cmdDONEorder.Name = "cmdDONEorder"
        Me.cmdDONEorder.Size = New System.Drawing.Size(125, 80)
        Me.cmdDONEorder.TabIndex = 14
        Me.cmdDONEorder.Text = "CHECK OUT"
        Me.cmdDONEorder.UseVisualStyleBackColor = True
        '
        'cmdADDtoCART
        '
        Me.cmdADDtoCART.Location = New System.Drawing.Point(45, 585)
        Me.cmdADDtoCART.Name = "cmdADDtoCART"
        Me.cmdADDtoCART.Size = New System.Drawing.Size(145, 80)
        Me.cmdADDtoCART.TabIndex = 13
        Me.cmdADDtoCART.Text = "ADD TO CART"
        Me.cmdADDtoCART.UseVisualStyleBackColor = True
        '
        'cmb4
        '
        Me.cmb4.FormattingEnabled = True
        Me.cmb4.Location = New System.Drawing.Point(302, 392)
        Me.cmb4.Name = "cmb4"
        Me.cmb4.Size = New System.Drawing.Size(108, 26)
        Me.cmb4.TabIndex = 12
        '
        'cmb3
        '
        Me.cmb3.FormattingEnabled = True
        Me.cmb3.Location = New System.Drawing.Point(302, 220)
        Me.cmb3.Name = "cmb3"
        Me.cmb3.Size = New System.Drawing.Size(108, 26)
        Me.cmb3.TabIndex = 11
        '
        'cmb1
        '
        Me.cmb1.FormattingEnabled = True
        Me.cmb1.Location = New System.Drawing.Point(302, 31)
        Me.cmb1.Name = "cmb1"
        Me.cmb1.Size = New System.Drawing.Size(108, 26)
        Me.cmb1.TabIndex = 10
        '
        'txtAccessQTY
        '
        Me.txtAccessQTY.Location = New System.Drawing.Point(196, 482)
        Me.txtAccessQTY.Name = "txtAccessQTY"
        Me.txtAccessQTY.Size = New System.Drawing.Size(100, 24)
        Me.txtAccessQTY.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 485)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Accessories Quantity:"
        '
        'txtProdQTY
        '
        Me.txtProdQTY.Location = New System.Drawing.Point(196, 299)
        Me.txtProdQTY.Name = "txtProdQTY"
        Me.txtProdQTY.Size = New System.Drawing.Size(100, 24)
        Me.txtProdQTY.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Product Quantity:"
        '
        'txtAccessID
        '
        Me.txtAccessID.Location = New System.Drawing.Point(196, 394)
        Me.txtAccessID.Name = "txtAccessID"
        Me.txtAccessID.Size = New System.Drawing.Size(100, 24)
        Me.txtAccessID.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 397)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Accessories Identification:"
        '
        'txtProdID
        '
        Me.txtProdID.Location = New System.Drawing.Point(196, 220)
        Me.txtProdID.Name = "txtProdID"
        Me.txtProdID.Size = New System.Drawing.Size(100, 24)
        Me.txtProdID.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product Identification:"
        '
        'txtDeliveryID
        '
        Me.txtDeliveryID.Location = New System.Drawing.Point(196, 31)
        Me.txtDeliveryID.Name = "txtDeliveryID"
        Me.txtDeliveryID.Size = New System.Drawing.Size(100, 24)
        Me.txtDeliveryID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Delivery Identification:"
        '
        'Dgrid1
        '
        Me.Dgrid1.AllowUserToAddRows = False
        Me.Dgrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cTravel, Me.cDO, Me.cDS, Me.cSource, Me.cProductID, Me.cPDesc, Me.cPrdBrand, Me.cProductQTY, Me.cAccessoriesID, Me.cADesc, Me.cAccessBrandd, Me.cAccessoriesQTY})
        Me.Dgrid1.Location = New System.Drawing.Point(425, 0)
        Me.Dgrid1.Name = "Dgrid1"
        Me.Dgrid1.Size = New System.Drawing.Size(857, 376)
        Me.Dgrid1.TabIndex = 1
        '
        'Dgrid2
        '
        Me.Dgrid2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Dgrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgrid2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Dgrid2.Location = New System.Drawing.Point(419, 382)
        Me.Dgrid2.Name = "Dgrid2"
        Me.Dgrid2.Size = New System.Drawing.Size(853, 435)
        Me.Dgrid2.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 348)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 16)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Product Brand:"
        '
        'txtProdBrand
        '
        Me.txtProdBrand.Enabled = False
        Me.txtProdBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdBrand.Location = New System.Drawing.Point(196, 345)
        Me.txtProdBrand.Name = "txtProdBrand"
        Me.txtProdBrand.Size = New System.Drawing.Size(101, 22)
        Me.txtProdBrand.TabIndex = 41
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 528)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(143, 16)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Accessories Brand:"
        '
        'txtAccessBrand
        '
        Me.txtAccessBrand.Enabled = False
        Me.txtAccessBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccessBrand.Location = New System.Drawing.Point(195, 527)
        Me.txtAccessBrand.Name = "txtAccessBrand"
        Me.txtAccessBrand.Size = New System.Drawing.Size(101, 22)
        Me.txtAccessBrand.TabIndex = 43
        '
        'cTravel
        '
        Me.cTravel.HeaderText = "Travel Fee"
        Me.cTravel.Name = "cTravel"
        '
        'cDO
        '
        Me.cDO.HeaderText = "Date Order"
        Me.cDO.Name = "cDO"
        '
        'cDS
        '
        Me.cDS.HeaderText = "Date Shipped"
        Me.cDS.Name = "cDS"
        '
        'cSource
        '
        Me.cSource.HeaderText = "Source"
        Me.cSource.Name = "cSource"
        '
        'cProductID
        '
        Me.cProductID.HeaderText = "Product Identification"
        Me.cProductID.Name = "cProductID"
        '
        'cPDesc
        '
        Me.cPDesc.HeaderText = "Product Description"
        Me.cPDesc.Name = "cPDesc"
        '
        'cPrdBrand
        '
        Me.cPrdBrand.HeaderText = "Product Brand"
        Me.cPrdBrand.Name = "cPrdBrand"
        '
        'cProductQTY
        '
        Me.cProductQTY.HeaderText = "Product Quantity"
        Me.cProductQTY.Name = "cProductQTY"
        '
        'cAccessoriesID
        '
        Me.cAccessoriesID.HeaderText = "Accessories Identification"
        Me.cAccessoriesID.Name = "cAccessoriesID"
        '
        'cADesc
        '
        Me.cADesc.HeaderText = "Accessories Description"
        Me.cADesc.Name = "cADesc"
        '
        'cAccessBrandd
        '
        Me.cAccessBrandd.HeaderText = "Accessories Brand"
        Me.cAccessBrandd.Name = "cAccessBrandd"
        '
        'cAccessoriesQTY
        '
        Me.cAccessoriesQTY.HeaderText = "Accessories Quantity"
        Me.cAccessoriesQTY.Name = "cAccessoriesQTY"
        '
        'SupplierTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1272, 817)
        Me.Controls.Add(Me.Dgrid2)
        Me.Controls.Add(Me.Dgrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SupplierTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SupplierTransaction"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dgrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAccessQTY As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProdQTY As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAccessID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProdID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDeliveryID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb4 As ComboBox
    Friend WithEvents cmb3 As ComboBox
    Friend WithEvents cmb1 As ComboBox
    Friend WithEvents Dgrid1 As DataGridView
    Friend WithEvents cmdADDtoCART As Button
    Friend WithEvents cmdDONEorder As Button
    Friend WithEvents cmb2 As ComboBox
    Friend WithEvents txtSourced As TextBox
    Friend WithEvents txtDS As TextBox
    Friend WithEvents txtDO As TextBox
    Friend WithEvents txtTravel As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Dgrid2 As DataGridView
    Friend WithEvents txtAccessDesc As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtProdDesc As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmdReload As Button
    Friend WithEvents cmdDelDataGrid As Button
    Friend WithEvents cmdSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtProdBrand As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtAccessBrand As TextBox
    Friend WithEvents cTravel As DataGridViewTextBoxColumn
    Friend WithEvents cDO As DataGridViewTextBoxColumn
    Friend WithEvents cDS As DataGridViewTextBoxColumn
    Friend WithEvents cSource As DataGridViewTextBoxColumn
    Friend WithEvents cProductID As DataGridViewTextBoxColumn
    Friend WithEvents cPDesc As DataGridViewTextBoxColumn
    Friend WithEvents cPrdBrand As DataGridViewTextBoxColumn
    Friend WithEvents cProductQTY As DataGridViewTextBoxColumn
    Friend WithEvents cAccessoriesID As DataGridViewTextBoxColumn
    Friend WithEvents cADesc As DataGridViewTextBoxColumn
    Friend WithEvents cAccessBrandd As DataGridViewTextBoxColumn
    Friend WithEvents cAccessoriesQTY As DataGridViewTextBoxColumn
End Class
