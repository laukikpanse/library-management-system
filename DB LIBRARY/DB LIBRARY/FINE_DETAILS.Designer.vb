<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FINE_DETAILS
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USDATADataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FINEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TRANSACTIONIDDataGridViewTextBoxColumn, Me.READERIDDataGridViewTextBoxColumn, Me.USERNAMEDataGridViewTextBoxColumn, Me.FINEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FINEBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(152, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(444, 124)
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
        '
        'READERIDDataGridViewTextBoxColumn
        '
        Me.READERIDDataGridViewTextBoxColumn.DataPropertyName = "READER_ID"
        Me.READERIDDataGridViewTextBoxColumn.HeaderText = "READER_ID"
        Me.READERIDDataGridViewTextBoxColumn.Name = "READERIDDataGridViewTextBoxColumn"
        '
        'USERNAMEDataGridViewTextBoxColumn
        '
        Me.USERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME"
        Me.USERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME"
        Me.USERNAMEDataGridViewTextBoxColumn.Name = "USERNAMEDataGridViewTextBoxColumn"
        '
        'FINEDataGridViewTextBoxColumn
        '
        Me.FINEDataGridViewTextBoxColumn.DataPropertyName = "FINE"
        Me.FINEDataGridViewTextBoxColumn.HeaderText = "FINE"
        Me.FINEDataGridViewTextBoxColumn.Name = "FINEDataGridViewTextBoxColumn"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(140, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "CALCULATE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.Location = New System.Drawing.Point(153, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.Location = New System.Drawing.Point(272, 42)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "TOTAL FINE RECEIVED"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ENTER READER ID"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox3.Location = New System.Drawing.Point(272, 69)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "AVERAGE FINE RECEIVED FINE RECEIVED"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(333, 229)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(429, 160)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FINE DETAILS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 235)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(282, 153)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "USER DETAILS"
        '
        'FINE_DETAILS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(787, 542)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FINE_DETAILS"
        Me.Text = "FINE_DETAILS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USDATADataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FINEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents USDATADataSet7 As USDATADataSet7
    Friend WithEvents FINEBindingSource As BindingSource
    Friend WithEvents FINETableAdapter As USDATADataSet7TableAdapters.FINETableAdapter
    Friend WithEvents TRANSACTIONIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents READERIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents USERNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FINEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
