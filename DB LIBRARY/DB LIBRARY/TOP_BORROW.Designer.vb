<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TOP_BORROW
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
        Me.BOOKSBORROWEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOPBORROWERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USDATADataSet12 = New DB_LIBRARY.USDATADataSet12()
        Me.TOP_BORROWERSTableAdapter = New DB_LIBRARY.USDATADataSet12TableAdapters.TOP_BORROWERSTableAdapter()
        Me.FillBy3ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillBy3ToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TOPBORROWERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USDATADataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy3ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.READERIDDataGridViewTextBoxColumn, Me.BOOKSBORROWEDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TOPBORROWERSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(206, 57)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(243, 351)
        Me.DataGridView1.TabIndex = 0
        '
        'READERIDDataGridViewTextBoxColumn
        '
        Me.READERIDDataGridViewTextBoxColumn.DataPropertyName = "READER_ID"
        Me.READERIDDataGridViewTextBoxColumn.HeaderText = "READER_ID"
        Me.READERIDDataGridViewTextBoxColumn.Name = "READERIDDataGridViewTextBoxColumn"
        Me.READERIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BOOKSBORROWEDDataGridViewTextBoxColumn
        '
        Me.BOOKSBORROWEDDataGridViewTextBoxColumn.DataPropertyName = "BOOKS_BORROWED"
        Me.BOOKSBORROWEDDataGridViewTextBoxColumn.HeaderText = "BOOKS_BORROWED"
        Me.BOOKSBORROWEDDataGridViewTextBoxColumn.Name = "BOOKSBORROWEDDataGridViewTextBoxColumn"
        Me.BOOKSBORROWEDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TOPBORROWERSBindingSource
        '
        Me.TOPBORROWERSBindingSource.DataMember = "TOP_BORROWERS"
        Me.TOPBORROWERSBindingSource.DataSource = Me.USDATADataSet12
        '
        'USDATADataSet12
        '
        Me.USDATADataSet12.DataSetName = "USDATADataSet12"
        Me.USDATADataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TOP_BORROWERSTableAdapter
        '
        Me.TOP_BORROWERSTableAdapter.ClearBeforeFill = True
        '
        'FillBy3ToolStrip
        '
        Me.FillBy3ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillBy3ToolStripButton})
        Me.FillBy3ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBy3ToolStrip.Name = "FillBy3ToolStrip"
        Me.FillBy3ToolStrip.Size = New System.Drawing.Size(692, 25)
        Me.FillBy3ToolStrip.TabIndex = 1
        Me.FillBy3ToolStrip.Text = "FillBy3ToolStrip"
        '
        'FillBy3ToolStripButton
        '
        Me.FillBy3ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy3ToolStripButton.Name = "FillBy3ToolStripButton"
        Me.FillBy3ToolStripButton.Size = New System.Drawing.Size(46, 22)
        Me.FillBy3ToolStripButton.Text = "SHOW"
        '
        'TOP_BORROW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(692, 450)
        Me.Controls.Add(Me.FillBy3ToolStrip)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "TOP_BORROW"
        Me.Text = "TOP_BORROW"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TOPBORROWERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USDATADataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy3ToolStrip.ResumeLayout(False)
        Me.FillBy3ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents USDATADataSet12 As USDATADataSet12
    Friend WithEvents TOPBORROWERSBindingSource As BindingSource
    Friend WithEvents TOP_BORROWERSTableAdapter As USDATADataSet12TableAdapters.TOP_BORROWERSTableAdapter
    Friend WithEvents READERIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BOOKSBORROWEDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FillBy3ToolStrip As ToolStrip
    Friend WithEvents FillBy3ToolStripButton As ToolStripButton
End Class
