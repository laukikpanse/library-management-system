<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MODIFY_USER
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.READERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHONENODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSWORDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.READERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USDATADataSet = New DB_LIBRARY.USDATADataSet()
        Me.BOOKSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BOOKSTableAdapter = New DB_LIBRARY.USDATADataSetTableAdapters.BOOKSTableAdapter()
        Me.READERTableAdapter = New DB_LIBRARY.USDATADataSetTableAdapters.READERTableAdapter()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CMBREGADD = New System.Windows.Forms.ComboBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.READERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USDATADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(388, 553)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "UPDATE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.READERIDDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn, Me.PHONENODataGridViewTextBoxColumn, Me.EMAILIDDataGridViewTextBoxColumn, Me.USERNAMEDataGridViewTextBoxColumn, Me.PASSWORDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.READERBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(27, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(845, 183)
        Me.DataGridView1.TabIndex = 36
        '
        'READERIDDataGridViewTextBoxColumn
        '
        Me.READERIDDataGridViewTextBoxColumn.DataPropertyName = "READER_ID"
        Me.READERIDDataGridViewTextBoxColumn.HeaderText = "READER_ID"
        Me.READERIDDataGridViewTextBoxColumn.Name = "READERIDDataGridViewTextBoxColumn"
        Me.READERIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST_NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRST_NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Name = "FIRSTNAMEDataGridViewTextBoxColumn"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LASTNAMEDataGridViewTextBoxColumn
        '
        Me.LASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LAST_NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.HeaderText = "LAST_NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.Name = "LASTNAMEDataGridViewTextBoxColumn"
        Me.LASTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ADDRESSDataGridViewTextBoxColumn
        '
        Me.ADDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.Name = "ADDRESSDataGridViewTextBoxColumn"
        Me.ADDRESSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PHONENODataGridViewTextBoxColumn
        '
        Me.PHONENODataGridViewTextBoxColumn.DataPropertyName = "PHONE_NO"
        Me.PHONENODataGridViewTextBoxColumn.HeaderText = "PHONE_NO"
        Me.PHONENODataGridViewTextBoxColumn.Name = "PHONENODataGridViewTextBoxColumn"
        Me.PHONENODataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMAILIDDataGridViewTextBoxColumn
        '
        Me.EMAILIDDataGridViewTextBoxColumn.DataPropertyName = "EMAIL_ID"
        Me.EMAILIDDataGridViewTextBoxColumn.HeaderText = "EMAIL_ID"
        Me.EMAILIDDataGridViewTextBoxColumn.Name = "EMAILIDDataGridViewTextBoxColumn"
        Me.EMAILIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'USERNAMEDataGridViewTextBoxColumn
        '
        Me.USERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME"
        Me.USERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME"
        Me.USERNAMEDataGridViewTextBoxColumn.Name = "USERNAMEDataGridViewTextBoxColumn"
        Me.USERNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PASSWORDDataGridViewTextBoxColumn
        '
        Me.PASSWORDDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD"
        Me.PASSWORDDataGridViewTextBoxColumn.HeaderText = "PASSWORD"
        Me.PASSWORDDataGridViewTextBoxColumn.Name = "PASSWORDDataGridViewTextBoxColumn"
        Me.PASSWORDDataGridViewTextBoxColumn.ReadOnly = True
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
        'BOOKSBindingSource
        '
        Me.BOOKSBindingSource.DataMember = "BOOKS"
        Me.BOOKSBindingSource.DataSource = Me.USDATADataSet
        '
        'BOOKSTableAdapter
        '
        Me.BOOKSTableAdapter.ClearBeforeFill = True
        '
        'READERTableAdapter
        '
        Me.READERTableAdapter.ClearBeforeFill = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(205, 515)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "PASSWORD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(205, 463)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "USERNAME"
        '
        'CMBREGADD
        '
        Me.CMBREGADD.FormattingEnabled = True
        Me.CMBREGADD.Items.AddRange(New Object() {"Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming"})
        Me.CMBREGADD.Location = New System.Drawing.Point(290, 355)
        Me.CMBREGADD.Name = "CMBREGADD"
        Me.CMBREGADD.Size = New System.Drawing.Size(134, 21)
        Me.CMBREGADD.TabIndex = 68
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(290, 508)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox7.Size = New System.Drawing.Size(188, 20)
        Me.TextBox7.TabIndex = 67
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(290, 460)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(188, 20)
        Me.TextBox6.TabIndex = 66
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(290, 411)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(188, 20)
        Me.TextBox5.TabIndex = 65
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(526, 355)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(151, 20)
        Me.TextBox4.TabIndex = 64
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(526, 301)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(151, 20)
        Me.TextBox3.TabIndex = 63
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(290, 301)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(134, 20)
        Me.TextBox2.TabIndex = 62
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(290, 259)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(188, 20)
        Me.TextBox1.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(205, 414)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "EMAIL ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(453, 358)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "PHONE NO."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(205, 358)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "ADDRESS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(452, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "LAST NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(205, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "FIRST NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(205, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "READER ID"
        '
        'MODIFY_USER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 622)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CMBREGADD)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "MODIFY_USER"
        Me.Text = "MODIFY_USER"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.READERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USDATADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents USDATADataSet As USDATADataSet
    Friend WithEvents BOOKSBindingSource As BindingSource
    Friend WithEvents BOOKSTableAdapter As USDATADataSetTableAdapters.BOOKSTableAdapter
    Friend WithEvents READERBindingSource As BindingSource
    Friend WithEvents READERTableAdapter As USDATADataSetTableAdapters.READERTableAdapter
    Friend WithEvents READERIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PHONENODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMAILIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents USERNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PASSWORDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CMBREGADD As ComboBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
