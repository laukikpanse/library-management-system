<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SELECT_USER
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.READERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRST_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LAST_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.READERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USDATADataSet = New DB_LIBRARY.USDATADataSet()
        Me.READERTableAdapter = New DB_LIBRARY.USDATADataSetTableAdapters.READERTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.READERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USDATADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.READERIDDataGridViewTextBoxColumn, Me.FIRST_NAME, Me.LAST_NAME, Me.USERNAME})
        Me.DataGridView1.DataSource = Me.READERBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(220, 15)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(438, 184)
        Me.DataGridView1.TabIndex = 0
        '
        'READERIDDataGridViewTextBoxColumn
        '
        Me.READERIDDataGridViewTextBoxColumn.DataPropertyName = "READER_ID"
        Me.READERIDDataGridViewTextBoxColumn.HeaderText = "READER_ID"
        Me.READERIDDataGridViewTextBoxColumn.Name = "READERIDDataGridViewTextBoxColumn"
        Me.READERIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FIRST_NAME
        '
        Me.FIRST_NAME.DataPropertyName = "FIRST_NAME"
        Me.FIRST_NAME.HeaderText = "FIRST_NAME"
        Me.FIRST_NAME.Name = "FIRST_NAME"
        Me.FIRST_NAME.ReadOnly = True
        '
        'LAST_NAME
        '
        Me.LAST_NAME.DataPropertyName = "LAST_NAME"
        Me.LAST_NAME.HeaderText = "LAST_NAME"
        Me.LAST_NAME.Name = "LAST_NAME"
        Me.LAST_NAME.ReadOnly = True
        '
        'USERNAME
        '
        Me.USERNAME.DataPropertyName = "USERNAME"
        Me.USERNAME.HeaderText = "USERNAME"
        Me.USERNAME.Name = "USERNAME"
        Me.USERNAME.ReadOnly = True
        '
        'READERBindingSource
        '
        Me.READERBindingSource.DataMember = "READER"
        Me.READERBindingSource.DataSource = Me.USDATADataSet
        '
        'USDATADataSet
        '
        Me.USDATADataSet.DataSetName = "USDATADataSet"
        Me.USDATADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'READERTableAdapter
        '
        Me.READERTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(106, 107)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(171, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PASSWORD"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(300, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "CONFIRM"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(106, 77)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(169, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "READER ID"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Wheat
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(3, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(810, 443)
        Me.Panel1.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(272, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 192)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "VERIFY USER"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(106, 51)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 6
        '
        'SELECT_USER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(825, 467)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SELECT_USER"
        Me.Text = "SELECT_USER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.READERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USDATADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents USDATADataSet As DB_LIBRARY.USDATADataSet
    Friend WithEvents READERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents READERTableAdapter As DB_LIBRARY.USDATADataSetTableAdapters.READERTableAdapter
    Friend WithEvents READERIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FIRST_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LAST_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents USERNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
