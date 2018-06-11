<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMIN_LOGIN
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
        Me.adminlogin = New System.Windows.Forms.Button()
        Me.adminpasstxt = New System.Windows.Forms.TextBox()
        Me.adminunametxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.adminreset = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'adminlogin
        '
        Me.adminlogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.adminlogin.Location = New System.Drawing.Point(79, 126)
        Me.adminlogin.Name = "adminlogin"
        Me.adminlogin.Size = New System.Drawing.Size(75, 23)
        Me.adminlogin.TabIndex = 5
        Me.adminlogin.Text = "SUBMIT"
        Me.adminlogin.UseVisualStyleBackColor = True
        '
        'adminpasstxt
        '
        Me.adminpasstxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.adminpasstxt.Location = New System.Drawing.Point(354, 186)
        Me.adminpasstxt.Name = "adminpasstxt"
        Me.adminpasstxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.adminpasstxt.Size = New System.Drawing.Size(178, 20)
        Me.adminpasstxt.TabIndex = 10
        '
        'adminunametxt
        '
        Me.adminunametxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.adminunametxt.Location = New System.Drawing.Point(354, 149)
        Me.adminunametxt.Name = "adminunametxt"
        Me.adminunametxt.Size = New System.Drawing.Size(178, 20)
        Me.adminunametxt.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "USERNAME"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(558, 28)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "YOU CAN ONLY LOGIN USING ADMIN CREDENTIALS"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(251, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "PASSWORD"
        '
        'adminreset
        '
        Me.adminreset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.adminreset.Location = New System.Drawing.Point(173, 126)
        Me.adminreset.Name = "adminreset"
        Me.adminreset.Size = New System.Drawing.Size(75, 23)
        Me.adminreset.TabIndex = 7
        Me.adminreset.Text = "RESET"
        Me.adminreset.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 501)
        Me.Panel1.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(267, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.adminlogin)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.adminreset)
        Me.GroupBox1.Location = New System.Drawing.Point(195, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 192)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LOGIN DETAILS"
        '
        'ADMIN_LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(776, 525)
        Me.Controls.Add(Me.adminpasstxt)
        Me.Controls.Add(Me.adminunametxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ADMIN_LOGIN"
        Me.Text = "ADMIN_LOGIN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents adminlogin As System.Windows.Forms.Button
    Friend WithEvents adminpasstxt As System.Windows.Forms.TextBox
    Friend WithEvents adminunametxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents adminreset As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
