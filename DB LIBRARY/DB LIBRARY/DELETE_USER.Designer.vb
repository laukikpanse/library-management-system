<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DELETE_USER
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
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHONENODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSWORDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.READERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USDATADataSet = New DB_LIBRARY.USDATADataSet()
        Me.READERTableAdapter = New DB_LIBRARY.USDATADataSetTableAdapters.READERTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.READERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USDATADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.READERIDDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn, Me.PHONENODataGridViewTextBoxColumn, Me.EMAILIDDataGridViewTextBoxColumn, Me.USERNAMEDataGridViewTextBoxColumn, Me.PASSWORDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.READERBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(28, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(830, 160)
        Me.DataGridView1.TabIndex = 0
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
        'READERTableAdapter
        '
        Me.READERTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "READER ID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(203, 243)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(213, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "DELETE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(203, 281)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "SELECTED READER ID"
        '
        'DELETE_USER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 548)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DELETE_USER"
        Me.Text = "DELETE_USER"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.READERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USDATADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents USDATADataSet As DB_LIBRARY.USDATADataSet
    Friend WithEvents READERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents READERTableAdapter As DB_LIBRARY.USDATADataSetTableAdapters.READERTableAdapter
    Friend WithEvents READERIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PHONENODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMAILIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USERNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PASSWORDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
End Class
