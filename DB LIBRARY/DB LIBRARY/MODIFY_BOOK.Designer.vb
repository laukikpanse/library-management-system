<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MODIFY_BOOK
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
        Me.BOOKIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TITLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AUTHORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUBLISHERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUBLICATIONDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LIBRARYBRANCHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AVAILABILITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BOOKSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USDATADataSet = New DB_LIBRARY.USDATADataSet()
        Me.BOOKSTableAdapter = New DB_LIBRARY.USDATADataSetTableAdapters.BOOKSTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USDATADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BOOKIDDataGridViewTextBoxColumn, Me.ISBNDataGridViewTextBoxColumn, Me.TITLEDataGridViewTextBoxColumn, Me.AUTHORDataGridViewTextBoxColumn, Me.PUBLISHERDataGridViewTextBoxColumn, Me.PUBLICATIONDATEDataGridViewTextBoxColumn, Me.LIBRARYBRANCHDataGridViewTextBoxColumn, Me.AVAILABILITYDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BOOKSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(107, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(849, 130)
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
        'BOOKSBindingSource
        '
        Me.BOOKSBindingSource.DataMember = "BOOKS"
        Me.BOOKSBindingSource.DataSource = Me.USDATADataSet
        '
        'USDATADataSet
        '
        Me.USDATADataSet.DataSetName = "USDATADataSet"
        Me.USDATADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BOOKSTableAdapter
        '
        Me.BOOKSTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(224, 261)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(224, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(171, 20)
        Me.TextBox1.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(224, 58)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(171, 20)
        Me.TextBox2.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(224, 83)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(171, 20)
        Me.TextBox3.TabIndex = 12
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(224, 109)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(171, 20)
        Me.TextBox4.TabIndex = 13
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(224, 135)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(171, 20)
        Me.TextBox5.TabIndex = 14
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(224, 161)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(171, 20)
        Me.TextBox6.TabIndex = 15
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(224, 187)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(171, 20)
        Me.TextBox7.TabIndex = 16
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.Wheat
        Me.TextBox8.Location = New System.Drawing.Point(224, 213)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(171, 20)
        Me.TextBox8.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "BOOK ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ISBN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "TITLE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "AUTHOR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(56, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "PUBLISHER"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(56, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "PUBLICATION DATE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(56, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "LIBRARY BRANCH"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(56, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "AVAILABILITY"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(141, 196)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 298)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BOOK DETAILS"
        '
        'MODIFY_BOOK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1034, 597)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "MODIFY_BOOK"
        Me.Text = "MODIFY_BOOK"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USDATADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents USDATADataSet As DB_LIBRARY.USDATADataSet
    Friend WithEvents BOOKSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BOOKSTableAdapter As DB_LIBRARY.USDATADataSetTableAdapters.BOOKSTableAdapter
    Friend WithEvents BOOKIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ISBNDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TITLEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AUTHORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PUBLISHERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PUBLICATIONDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LIBRARYBRANCHDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AVAILABILITYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
