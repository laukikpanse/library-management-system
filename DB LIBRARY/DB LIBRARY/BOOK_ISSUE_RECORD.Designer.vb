<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BOOK_ISSUE_RECORD
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
        Me.TRANSACTIONIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.READERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BOOKIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TITLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AUTHORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LIBRARYBRANCHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BORROWDTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BORROWBOOKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USDATADataSet2 = New DB_LIBRARY.USDATADataSet2()
        Me.BORROW_BOOKTableAdapter = New DB_LIBRARY.USDATADataSet2TableAdapters.BORROW_BOOKTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BORROWBOOKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USDATADataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TRANSACTIONIDDataGridViewTextBoxColumn, Me.READERIDDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.BOOKIDDataGridViewTextBoxColumn, Me.TITLEDataGridViewTextBoxColumn, Me.AUTHORDataGridViewTextBoxColumn, Me.LIBRARYBRANCHDataGridViewTextBoxColumn, Me.BORROWDTDataGridViewTextBoxColumn, Me.ISBNDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BORROWBOOKBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1025, 571)
        Me.DataGridView1.TabIndex = 0
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
        'BOOKIDDataGridViewTextBoxColumn
        '
        Me.BOOKIDDataGridViewTextBoxColumn.DataPropertyName = "BOOK_ID"
        Me.BOOKIDDataGridViewTextBoxColumn.HeaderText = "BOOK_ID"
        Me.BOOKIDDataGridViewTextBoxColumn.Name = "BOOKIDDataGridViewTextBoxColumn"
        Me.BOOKIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TITLEDataGridViewTextBoxColumn
        '
        Me.TITLEDataGridViewTextBoxColumn.DataPropertyName = "TITLE"
        Me.TITLEDataGridViewTextBoxColumn.HeaderText = "TITLE"
        Me.TITLEDataGridViewTextBoxColumn.Name = "TITLEDataGridViewTextBoxColumn"
        Me.TITLEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AUTHORDataGridViewTextBoxColumn
        '
        Me.AUTHORDataGridViewTextBoxColumn.DataPropertyName = "AUTHOR"
        Me.AUTHORDataGridViewTextBoxColumn.HeaderText = "AUTHOR"
        Me.AUTHORDataGridViewTextBoxColumn.Name = "AUTHORDataGridViewTextBoxColumn"
        Me.AUTHORDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LIBRARYBRANCHDataGridViewTextBoxColumn
        '
        Me.LIBRARYBRANCHDataGridViewTextBoxColumn.DataPropertyName = "LIBRARY_BRANCH"
        Me.LIBRARYBRANCHDataGridViewTextBoxColumn.HeaderText = "LIBRARY_BRANCH"
        Me.LIBRARYBRANCHDataGridViewTextBoxColumn.Name = "LIBRARYBRANCHDataGridViewTextBoxColumn"
        Me.LIBRARYBRANCHDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BORROWDTDataGridViewTextBoxColumn
        '
        Me.BORROWDTDataGridViewTextBoxColumn.DataPropertyName = "BORROW_D_T"
        Me.BORROWDTDataGridViewTextBoxColumn.HeaderText = "BORROW_D_T"
        Me.BORROWDTDataGridViewTextBoxColumn.Name = "BORROWDTDataGridViewTextBoxColumn"
        Me.BORROWDTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ISBNDataGridViewTextBoxColumn
        '
        Me.ISBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.HeaderText = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.Name = "ISBNDataGridViewTextBoxColumn"
        Me.ISBNDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BORROWBOOKBindingSource
        '
        Me.BORROWBOOKBindingSource.DataMember = "BORROW_BOOK"
        Me.BORROWBOOKBindingSource.DataSource = Me.USDATADataSet2
        '
        'USDATADataSet2
        '
        Me.USDATADataSet2.DataSetName = "USDATADataSet2"
        Me.USDATADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BORROW_BOOKTableAdapter
        '
        Me.BORROW_BOOKTableAdapter.ClearBeforeFill = True
        '
        'BOOK_ISSUE_RECORD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 571)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "BOOK_ISSUE_RECORD"
        Me.Text = "BOOK_ISSUE_RECORD"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BORROWBOOKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USDATADataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents USDATADataSet2 As DB_LIBRARY.USDATADataSet2
    Friend WithEvents BORROWBOOKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BORROW_BOOKTableAdapter As DB_LIBRARY.USDATADataSet2TableAdapters.BORROW_BOOKTableAdapter
    Friend WithEvents TRANSACTIONIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents READERIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BOOKIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TITLEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AUTHORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LIBRARYBRANCHDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BORROWDTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ISBNDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
