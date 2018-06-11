<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USER_LOGIN
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
        Me.usrloginsubmit = New System.Windows.Forms.Button()
        Me.usrpasslabel = New System.Windows.Forms.Label()
        Me.usrloginreset = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.usrloginlabel = New System.Windows.Forms.Label()
        Me.usrpasstxt = New System.Windows.Forms.TextBox()
        Me.usrlogintxt = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'usrloginsubmit
        '
        Me.usrloginsubmit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.usrloginsubmit.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrloginsubmit.Location = New System.Drawing.Point(157, 128)
        Me.usrloginsubmit.Name = "usrloginsubmit"
        Me.usrloginsubmit.Size = New System.Drawing.Size(75, 23)
        Me.usrloginsubmit.TabIndex = 11
        Me.usrloginsubmit.Text = "SUBMIT"
        Me.usrloginsubmit.UseVisualStyleBackColor = True
        '
        'usrpasslabel
        '
        Me.usrpasslabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.usrpasslabel.AutoSize = True
        Me.usrpasslabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrpasslabel.Location = New System.Drawing.Point(229, 203)
        Me.usrpasslabel.Name = "usrpasslabel"
        Me.usrpasslabel.Size = New System.Drawing.Size(81, 19)
        Me.usrpasslabel.TabIndex = 10
        Me.usrpasslabel.Text = "PASSWORD"
        '
        'usrloginreset
        '
        Me.usrloginreset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.usrloginreset.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrloginreset.Location = New System.Drawing.Point(238, 128)
        Me.usrloginreset.Name = "usrloginreset"
        Me.usrloginreset.Size = New System.Drawing.Size(75, 23)
        Me.usrloginreset.TabIndex = 12
        Me.usrloginreset.Text = "RESET"
        Me.usrloginreset.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(111, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(598, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "LOGIN USING YOUR REGISTERED USERNAME AND PASSWORD"
        '
        'usrloginlabel
        '
        Me.usrloginlabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.usrloginlabel.AutoSize = True
        Me.usrloginlabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrloginlabel.Location = New System.Drawing.Point(35, 47)
        Me.usrloginlabel.Name = "usrloginlabel"
        Me.usrloginlabel.Size = New System.Drawing.Size(81, 19)
        Me.usrloginlabel.TabIndex = 9
        Me.usrloginlabel.Text = "USERNAME"
        '
        'usrpasstxt
        '
        Me.usrpasstxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.usrpasstxt.Location = New System.Drawing.Point(381, 196)
        Me.usrpasstxt.Name = "usrpasstxt"
        Me.usrpasstxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.usrpasstxt.Size = New System.Drawing.Size(162, 20)
        Me.usrpasstxt.TabIndex = 8
        '
        'usrlogintxt
        '
        Me.usrlogintxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.usrlogintxt.Location = New System.Drawing.Point(381, 159)
        Me.usrlogintxt.Name = "usrlogintxt"
        Me.usrlogintxt.Size = New System.Drawing.Size(162, 20)
        Me.usrlogintxt.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(767, 466)
        Me.Panel1.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.usrloginsubmit)
        Me.GroupBox1.Controls.Add(Me.usrloginreset)
        Me.GroupBox1.Controls.Add(Me.usrloginlabel)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(181, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 217)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "USER LOGIN "
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(319, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'USER_LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(791, 490)
        Me.Controls.Add(Me.usrpasslabel)
        Me.Controls.Add(Me.usrpasstxt)
        Me.Controls.Add(Me.usrlogintxt)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "USER_LOGIN"
        Me.Text = "USER_LOGIN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents usrloginsubmit As System.Windows.Forms.Button
    Friend WithEvents usrpasslabel As System.Windows.Forms.Label
    Friend WithEvents usrloginreset As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents usrloginlabel As System.Windows.Forms.Label
    Friend WithEvents usrpasstxt As System.Windows.Forms.TextBox
    Friend WithEvents usrlogintxt As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As Button
End Class
