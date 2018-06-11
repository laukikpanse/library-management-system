<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALL_PUBLISHERS
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
        Me.PUBLISHERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUBLISHERNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUBLISHERBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.USDATADataSet1 = New DB_LIBRARY.USDATADataSet1()
        Me.PUBLISHERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PUBLISHERTableAdapter = New DB_LIBRARY.USDATADataSet1TableAdapters.PUBLISHERTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PUBLISHERBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.USDATADataSet8 = New DB_LIBRARY.USDATADataSet8()
        Me.PUBLISHERBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PUBLISHERTableAdapter1 = New DB_LIBRARY.USDATADataSet8TableAdapters.PUBLISHERTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PUBLISHERBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USDATADataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PUBLISHERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PUBLISHERBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USDATADataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PUBLISHERBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PUBLISHERIDDataGridViewTextBoxColumn, Me.PUBLISHERNAMEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PUBLISHERBindingSource3
        Me.DataGridView1.Location = New System.Drawing.Point(208, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(247, 194)
        Me.DataGridView1.TabIndex = 0
        '
        'PUBLISHERIDDataGridViewTextBoxColumn
        '
        Me.PUBLISHERIDDataGridViewTextBoxColumn.DataPropertyName = "PUBLISHER_ID"
        Me.PUBLISHERIDDataGridViewTextBoxColumn.HeaderText = "PUBLISHER_ID"
        Me.PUBLISHERIDDataGridViewTextBoxColumn.Name = "PUBLISHERIDDataGridViewTextBoxColumn"
        Me.PUBLISHERIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PUBLISHERNAMEDataGridViewTextBoxColumn
        '
        Me.PUBLISHERNAMEDataGridViewTextBoxColumn.DataPropertyName = "PUBLISHER_NAME"
        Me.PUBLISHERNAMEDataGridViewTextBoxColumn.HeaderText = "PUBLISHER_NAME"
        Me.PUBLISHERNAMEDataGridViewTextBoxColumn.Name = "PUBLISHERNAMEDataGridViewTextBoxColumn"
        Me.PUBLISHERNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PUBLISHERBindingSource1
        '
        Me.PUBLISHERBindingSource1.DataMember = "PUBLISHER"
        Me.PUBLISHERBindingSource1.DataSource = Me.USDATADataSet1
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(391, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "PRINT DOCUMENT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CLICK HERE TO SELECT ALL ->"
        '
        'PUBLISHERBindingSource2
        '
        Me.PUBLISHERBindingSource2.DataMember = "PUBLISHER"
        Me.PUBLISHERBindingSource2.DataSource = Me.USDATADataSet1
        '
        'USDATADataSet8
        '
        Me.USDATADataSet8.DataSetName = "USDATADataSet8"
        Me.USDATADataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PUBLISHERBindingSource3
        '
        Me.PUBLISHERBindingSource3.DataMember = "PUBLISHER"
        Me.PUBLISHERBindingSource3.DataSource = Me.USDATADataSet8
        '
        'PUBLISHERTableAdapter1
        '
        Me.PUBLISHERTableAdapter1.ClearBeforeFill = True
        '
        'ALL_PUBLISHERS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(834, 514)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ALL_PUBLISHERS"
        Me.Text = "ALL_PUBLISHERS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PUBLISHERBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USDATADataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PUBLISHERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PUBLISHERBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USDATADataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PUBLISHERBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents USDATADataSet1 As DB_LIBRARY.USDATADataSet1
    Friend WithEvents PUBLISHERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PUBLISHERTableAdapter As DB_LIBRARY.USDATADataSet1TableAdapters.PUBLISHERTableAdapter
    Friend WithEvents PUBLISHERIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PUBLISHERNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PUBLISHERBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PUBLISHERBindingSource2 As BindingSource
    Friend WithEvents USDATADataSet8 As USDATADataSet8
    Friend WithEvents PUBLISHERBindingSource3 As BindingSource
    Friend WithEvents PUBLISHERTableAdapter1 As USDATADataSet8TableAdapters.PUBLISHERTableAdapter
End Class
