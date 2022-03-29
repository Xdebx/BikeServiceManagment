<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdCREATE = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.rbtMechanic = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.checkB = New System.Windows.Forms.CheckBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.rbtOwner = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdLOGIN = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.cmdCREATE)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.rbtMechanic)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.checkB)
        Me.Panel1.Controls.Add(Me.txtType)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.rbtOwner)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.cmdLOGIN)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(7, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 312)
        Me.Panel1.TabIndex = 5
        '
        'cmdCREATE
        '
        Me.cmdCREATE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCREATE.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info
        Me.cmdCREATE.FlatAppearance.BorderSize = 3
        Me.cmdCREATE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.cmdCREATE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.cmdCREATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCREATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCREATE.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdCREATE.Location = New System.Drawing.Point(206, 221)
        Me.cmdCREATE.Name = "cmdCREATE"
        Me.cmdCREATE.Size = New System.Drawing.Size(113, 38)
        Me.cmdCREATE.TabIndex = 23
        Me.cmdCREATE.Text = "CREATE "
        Me.cmdCREATE.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(274, 289)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(113, 16)
        Me.LinkLabel1.TabIndex = 22
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Create Account"
        '
        'rbtMechanic
        '
        Me.rbtMechanic.AutoSize = True
        Me.rbtMechanic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtMechanic.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbtMechanic.Location = New System.Drawing.Point(21, 40)
        Me.rbtMechanic.Name = "rbtMechanic"
        Me.rbtMechanic.Size = New System.Drawing.Size(87, 19)
        Me.rbtMechanic.TabIndex = 21
        Me.rbtMechanic.TabStop = True
        Me.rbtMechanic.Text = "Mechanic"
        Me.rbtMechanic.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(37, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "User Type"
        '
        'checkB
        '
        Me.checkB.AutoSize = True
        Me.checkB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.checkB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkB.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.checkB.Location = New System.Drawing.Point(268, 183)
        Me.checkB.Name = "checkB"
        Me.checkB.Size = New System.Drawing.Size(112, 17)
        Me.checkB.TabIndex = 16
        Me.checkB.Text = "Show password"
        Me.checkB.UseVisualStyleBackColor = True
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(126, 113)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(136, 20)
        Me.txtType.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(37, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(126, 179)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(136, 21)
        Me.txtPassword.TabIndex = 14
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'rbtOwner
        '
        Me.rbtOwner.AutoSize = True
        Me.rbtOwner.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtOwner.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbtOwner.Location = New System.Drawing.Point(21, 15)
        Me.rbtOwner.Name = "rbtOwner"
        Me.rbtOwner.Size = New System.Drawing.Size(66, 19)
        Me.rbtOwner.TabIndex = 20
        Me.rbtOwner.TabStop = True
        Me.rbtOwner.Text = "Owner"
        Me.rbtOwner.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(147, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'cmdLOGIN
        '
        Me.cmdLOGIN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLOGIN.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info
        Me.cmdLOGIN.FlatAppearance.BorderSize = 3
        Me.cmdLOGIN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.cmdLOGIN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.cmdLOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLOGIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLOGIN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdLOGIN.Location = New System.Drawing.Point(72, 221)
        Me.cmdLOGIN.Name = "cmdLOGIN"
        Me.cmdLOGIN.Size = New System.Drawing.Size(113, 38)
        Me.cmdLOGIN.TabIndex = 5
        Me.cmdLOGIN.Text = "LOGIN"
        Me.cmdLOGIN.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtUsername.Location = New System.Drawing.Point(126, 148)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(136, 21)
        Me.txtUsername.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(37, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User Name:"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 323)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmdLOGIN As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents checkB As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents rbtMechanic As RadioButton
    Friend WithEvents rbtOwner As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtType As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents cmdCREATE As Button
End Class
