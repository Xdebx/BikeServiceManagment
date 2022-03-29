<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MechanicProfile
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
        Me.Dgrid1 = New System.Windows.Forms.DataGridView()
        Me.txtMechIDD = New System.Windows.Forms.TextBox()
        Me.cmb1 = New System.Windows.Forms.ComboBox()
        Me.cmSearch = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.Dgrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgrid1
        '
        Me.Dgrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgrid1.Location = New System.Drawing.Point(367, -3)
        Me.Dgrid1.Name = "Dgrid1"
        Me.Dgrid1.Size = New System.Drawing.Size(687, 285)
        Me.Dgrid1.TabIndex = 42
        '
        'txtMechIDD
        '
        Me.txtMechIDD.Enabled = False
        Me.txtMechIDD.Location = New System.Drawing.Point(168, 85)
        Me.txtMechIDD.Name = "txtMechIDD"
        Me.txtMechIDD.Size = New System.Drawing.Size(134, 20)
        Me.txtMechIDD.TabIndex = 48
        '
        'cmb1
        '
        Me.cmb1.FormattingEnabled = True
        Me.cmb1.Location = New System.Drawing.Point(308, 85)
        Me.cmb1.Name = "cmb1"
        Me.cmb1.Size = New System.Drawing.Size(48, 21)
        Me.cmb1.TabIndex = 54
        '
        'cmSearch
        '
        Me.cmSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmSearch.Location = New System.Drawing.Point(143, 156)
        Me.cmSearch.Name = "cmSearch"
        Me.cmSearch.Size = New System.Drawing.Size(134, 23)
        Me.cmSearch.TabIndex = 57
        Me.cmSearch.Text = "Search"
        Me.cmSearch.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label4.Location = New System.Drawing.Point(5, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 18)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Mechanics ID:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Dgrid1)
        Me.Panel1.Controls.Add(Me.cmSearch)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtMechIDD)
        Me.Panel1.Controls.Add(Me.cmb1)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1057, 285)
        Me.Panel1.TabIndex = 65
        '
        'MechanicProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1063, 293)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MechanicProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MechanicProfile"
        CType(Me.Dgrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dgrid1 As DataGridView
    Friend WithEvents txtMechIDD As TextBox
    Friend WithEvents cmb1 As ComboBox
    Friend WithEvents cmSearch As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
End Class
