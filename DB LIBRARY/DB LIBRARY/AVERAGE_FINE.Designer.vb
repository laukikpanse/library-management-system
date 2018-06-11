<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AVERAGE_FINE
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
        Me.USDATADataSet7 = New DB_LIBRARY.USDATADataSet7()
        Me.FINEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FINETableAdapter = New DB_LIBRARY.USDATADataSet7TableAdapters.FINETableAdapter()
        Me.TRANSACTIONIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.READERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FINEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USDATADataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FINEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TRANSACTIONIDDataGridViewTextBoxColumn, Me.READERIDDataGridViewTextBoxColumn, Me.USERNAMEDataGridViewTextBoxColumn, Me.FINEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FINEBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(76, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(445, 184)
        Me.DataGridView1.TabIndex = 0
        '
        'USDATADataSet7
        '
        Me.USDATADataSet7.DataSetName = "USDATADataSet7"
        Me.USDATADataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FINEBindingSource
        '
        Me.FINEBindingSource.DataMember = "FINE"
        Me.FINEBindingSource.DataSource = Me.USDATADataSet7
        '
        'FINETableAdapter
        '
        Me.FINETableAdapter.ClearBeforeFill = True
        '
        'TRANSACTIONIDDataGridViewTextBoxColumn
        '
        Me.TRANSACTIONIDDataGridViewTextBoxColumn.DataPropertyName = "TRANSACTION_ID"
        Me.TRANSACTIONIDDataGridViewTextBoxColumn.HeaderText = "TRANSACTION_ID"
        Me.TRANSACTIONIDDataGridViewTextBoxColumn.Name = "TRANSACTIONIDDataGridViewTextBoxColumn"
        Me.TRANSACTIONIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'READERIDDataGridViewTextBoxColumn
        '
        Me.READERIDDataGridViewTextBoxColumn.DataPropertyName = "READER_ID"
        Me.READERIDDataGridViewTextBoxColumn.HeaderText = "READER_ID"
        Me.READERIDDataGridViewTextBoxColumn.Name = "READERIDDataGridViewTextBoxColumn"
        Me.READERIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'USERNAMEDataGridViewTextBoxColumn
        '
        Me.USERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME"
        Me.USERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME"
        Me.USERNAMEDataGridViewTextBoxColumn.Name = "USERNAMEDataGridViewTextBoxColumn"
        Me.USERNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FINEDataGridViewTextBoxColumn
        '
        Me.FINEDataGridViewTextBoxColumn.DataPropertyName = "FINE"
        Me.FINEDataGridViewTextBoxColumn.HeaderText = "FINE"
        Me.FINEDataGridViewTextBoxColumn.Name = "FINEDataGridViewTextBoxColumn"
        Me.FINEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(76, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AVERAGE_FINE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 402)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AVERAGE_FINE"
        Me.Text = "AVERAGE_FINE"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USDATADataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FINEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents USDATADataSet7 As DB_LIBRARY.USDATADataSet7
    Friend WithEvents FINEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FINETableAdapter As DB_LIBRARY.USDATADataSet7TableAdapters.FINETableAdapter
    Friend WithEvents TRANSACTIONIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents READERIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USERNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FINEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
