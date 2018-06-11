<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TOP_BOOKS
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
        Me.BOOKSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BOOKSTableAdapter = New DB_LIBRARY.USDATADataSetTableAdapters.BOOKSTableAdapter()
        Me.BOOKSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BOOKIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TITLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AUTHORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUBLISHERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUBLICATIONDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LIBRARYBRANCHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AVAILABILITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COUNTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BOOKSBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.USDATADataSet14 = New DB_LIBRARY.USDATADataSet14()
        Me.BOOKSTableAdapter1 = New DB_LIBRARY.USDATADataSet14TableAdapters.BOOKSTableAdapter()
        Me.FillBy2ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillBy2ToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.USDATADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKSBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USDATADataSet14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy2ToolStrip.SuspendLayout()
        Me.SuspendLayout()
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
        'BOOKSBindingSource1
        '
        Me.BOOKSBindingSource1.DataMember = "BOOKS"
        Me.BOOKSBindingSource1.DataSource = Me.USDATADataSet
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BOOKIDDataGridViewTextBoxColumn, Me.ISBNDataGridViewTextBoxColumn, Me.TITLEDataGridViewTextBoxColumn, Me.AUTHORDataGridViewTextBoxColumn, Me.PUBLISHERDataGridViewTextBoxColumn, Me.PUBLICATIONDATEDataGridViewTextBoxColumn, Me.LIBRARYBRANCHDataGridViewTextBoxColumn, Me.AVAILABILITYDataGridViewTextBoxColumn, Me.COUNTDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BOOKSBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(917, 232)
        Me.DataGridView1.TabIndex = 0
        '
        'BOOKIDDataGridViewTextBoxColumn
        '
        Me.BOOKIDDataGridViewTextBoxColumn.DataPropertyName = "BOOK_ID"
        Me.BOOKIDDataGridViewTextBoxColumn.HeaderText = "BOOK_ID"
        Me.BOOKIDDataGridViewTextBoxColumn.Name = "BOOKIDDataGridViewTextBoxColumn"
        Me.BOOKIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ISBNDataGridViewTextBoxColumn
        '
        Me.ISBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.HeaderText = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.Name = "ISBNDataGridViewTextBoxColumn"
        Me.ISBNDataGridViewTextBoxColumn.ReadOnly = True
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
        'PUBLISHERDataGridViewTextBoxColumn
        '
        Me.PUBLISHERDataGridViewTextBoxColumn.DataPropertyName = "PUBLISHER"
        Me.PUBLISHERDataGridViewTextBoxColumn.HeaderText = "PUBLISHER"
        Me.PUBLISHERDataGridViewTextBoxColumn.Name = "PUBLISHERDataGridViewTextBoxColumn"
        Me.PUBLISHERDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PUBLICATIONDATEDataGridViewTextBoxColumn
        '
        Me.PUBLICATIONDATEDataGridViewTextBoxColumn.DataPropertyName = "PUBLICATION_DATE"
        Me.PUBLICATIONDATEDataGridViewTextBoxColumn.HeaderText = "PUBLICATION_DATE"
        Me.PUBLICATIONDATEDataGridViewTextBoxColumn.Name = "PUBLICATIONDATEDataGridViewTextBoxColumn"
        Me.PUBLICATIONDATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LIBRARYBRANCHDataGridViewTextBoxColumn
        '
        Me.LIBRARYBRANCHDataGridViewTextBoxColumn.DataPropertyName = "LIBRARY_BRANCH"
        Me.LIBRARYBRANCHDataGridViewTextBoxColumn.HeaderText = "LIBRARY_BRANCH"
        Me.LIBRARYBRANCHDataGridViewTextBoxColumn.Name = "LIBRARYBRANCHDataGridViewTextBoxColumn"
        Me.LIBRARYBRANCHDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AVAILABILITYDataGridViewTextBoxColumn
        '
        Me.AVAILABILITYDataGridViewTextBoxColumn.DataPropertyName = "AVAILABILITY"
        Me.AVAILABILITYDataGridViewTextBoxColumn.HeaderText = "AVAILABILITY"
        Me.AVAILABILITYDataGridViewTextBoxColumn.Name = "AVAILABILITYDataGridViewTextBoxColumn"
        Me.AVAILABILITYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'COUNTDataGridViewTextBoxColumn
        '
        Me.COUNTDataGridViewTextBoxColumn.DataPropertyName = "COUNT"
        Me.COUNTDataGridViewTextBoxColumn.HeaderText = "COUNT"
        Me.COUNTDataGridViewTextBoxColumn.Name = "COUNTDataGridViewTextBoxColumn"
        Me.COUNTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BOOKSBindingSource2
        '
        Me.BOOKSBindingSource2.DataMember = "BOOKS"
        Me.BOOKSBindingSource2.DataSource = Me.USDATADataSet14
        '
        'USDATADataSet14
        '
        Me.USDATADataSet14.DataSetName = "USDATADataSet14"
        Me.USDATADataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BOOKSTableAdapter1
        '
        Me.BOOKSTableAdapter1.ClearBeforeFill = True
        '
        'FillBy2ToolStrip
        '
        Me.FillBy2ToolStrip.BackColor = System.Drawing.Color.Wheat
        Me.FillBy2ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillBy2ToolStripButton})
        Me.FillBy2ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBy2ToolStrip.Name = "FillBy2ToolStrip"
        Me.FillBy2ToolStrip.Size = New System.Drawing.Size(949, 25)
        Me.FillBy2ToolStrip.TabIndex = 1
        Me.FillBy2ToolStrip.Text = "FillBy2ToolStrip"
        '
        'FillBy2ToolStripButton
        '
        Me.FillBy2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy2ToolStripButton.Name = "FillBy2ToolStripButton"
        Me.FillBy2ToolStripButton.Size = New System.Drawing.Size(46, 22)
        Me.FillBy2ToolStripButton.Text = "SHOW"
        '
        'TOP_BOOKS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 500)
        Me.Controls.Add(Me.FillBy2ToolStrip)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "TOP_BOOKS"
        Me.Text = "TOP_BOOKS"
        CType(Me.USDATADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKSBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USDATADataSet14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy2ToolStrip.ResumeLayout(False)
        Me.FillBy2ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents USDATADataSet As DB_LIBRARY.USDATADataSet
    Friend WithEvents BOOKSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BOOKSTableAdapter As DB_LIBRARY.USDATADataSetTableAdapters.BOOKSTableAdapter
    Friend WithEvents BOOKSBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents USDATADataSet14 As DB_LIBRARY.USDATADataSet14
    Friend WithEvents BOOKSBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents BOOKSTableAdapter1 As DB_LIBRARY.USDATADataSet14TableAdapters.BOOKSTableAdapter
    Friend WithEvents BOOKIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ISBNDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TITLEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AUTHORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PUBLISHERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PUBLICATIONDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LIBRARYBRANCHDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AVAILABILITYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COUNTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FillBy2ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillBy2ToolStripButton As System.Windows.Forms.ToolStripButton
End Class
