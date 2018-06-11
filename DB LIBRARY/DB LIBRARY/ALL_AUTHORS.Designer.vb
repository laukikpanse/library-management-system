<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALL_AUTHORS
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
        Me.USDATADataSet = New DB_LIBRARY.USDATADataSet()
        Me.USDATADataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USDATADataSet1 = New DB_LIBRARY.USDATADataSet1()
        Me.PUBLISHERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PUBLISHERTableAdapter = New DB_LIBRARY.USDATADataSet1TableAdapters.PUBLISHERTableAdapter()
        Me.USDATADataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AUTHORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BOOKSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BOOKSTableAdapter = New DB_LIBRARY.USDATADataSetTableAdapters.BOOKSTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.USDATADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USDATADataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USDATADataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PUBLISHERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USDATADataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'USDATADataSet
        '
        Me.USDATADataSet.DataSetName = "USDATADataSet"
        Me.USDATADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'USDATADataSetBindingSource
        '
        Me.USDATADataSetBindingSource.DataSource = Me.USDATADataSet
        Me.USDATADataSetBindingSource.Position = 0
        '
        'USDATADataSet1
        '
        Me.USDATADataSet1.DataSetName = "USDATADataSet1"
        Me.USDATADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PUBLISHERBindingSource
        '
        Me.PUBLISHERBindingSource.DataMember = "PUBLISHER"
        Me.PUBLISHERBindingSource.DataSource = Me.USDATADataSet1
        '
        'PUBLISHERTableAdapter
        '
        Me.PUBLISHERTableAdapter.ClearBeforeFill = True
        '
        'USDATADataSetBindingSource1
        '
        Me.USDATADataSetBindingSource1.DataSource = Me.USDATADataSet
        Me.USDATADataSetBindingSource1.Position = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AUTHORDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BOOKSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(209, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(144, 139)
        Me.DataGridView1.TabIndex = 0
        '
        'AUTHORDataGridViewTextBoxColumn
        '
        Me.AUTHORDataGridViewTextBoxColumn.DataPropertyName = "AUTHOR"
        Me.AUTHORDataGridViewTextBoxColumn.HeaderText = "AUTHOR"
        Me.AUTHORDataGridViewTextBoxColumn.Name = "AUTHORDataGridViewTextBoxColumn"
        Me.AUTHORDataGridViewTextBoxColumn.ReadOnly = True
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
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(248, 222)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 21)
        Me.Button4.TabIndex = 73
        Me.Button4.Text = "PRINT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'ALL_AUTHORS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(571, 444)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ALL_AUTHORS"
        Me.Text = "ALL_AUTHORS"
        CType(Me.USDATADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USDATADataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USDATADataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PUBLISHERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USDATADataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents USDATADataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents USDATADataSet As DB_LIBRARY.USDATADataSet
    Friend WithEvents USDATADataSet1 As DB_LIBRARY.USDATADataSet1
    Friend WithEvents PUBLISHERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PUBLISHERTableAdapter As DB_LIBRARY.USDATADataSet1TableAdapters.PUBLISHERTableAdapter
    Friend WithEvents USDATADataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BOOKSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BOOKSTableAdapter As DB_LIBRARY.USDATADataSetTableAdapters.BOOKSTableAdapter
    Friend WithEvents AUTHORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
