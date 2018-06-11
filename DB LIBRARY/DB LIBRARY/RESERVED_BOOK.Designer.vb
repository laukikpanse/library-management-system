<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RESERVED_BOOK
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
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LIBR = New System.Windows.Forms.TextBox()
        Me.AUT = New System.Windows.Forms.TextBox()
        Me.TITL = New System.Windows.Forms.TextBox()
        Me.ISB = New System.Windows.Forms.TextBox()
        Me.BID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RESVBOOKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USDATADataSet5 = New DB_LIBRARY.USDATADataSet5()
        Me.RESV_BOOKTableAdapter = New DB_LIBRARY.USDATADataSet5TableAdapters.RESV_BOOKTableAdapter()
        Me.RESVBOOKBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TRANSACTIONIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.READERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BOOKIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TITLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AUTHORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LIBRARYBRANCHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESVDTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESVBOOKBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.USDATADataSet6 = New DB_LIBRARY.USDATADataSet6()
        Me.RESV_BOOKTableAdapter1 = New DB_LIBRARY.USDATADataSet6TableAdapters.RESV_BOOKTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.RESVBOOKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USDATADataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RESVBOOKBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RESVBOOKBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USDATADataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(533, 132)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(137, 20)
        Me.TextBox10.TabIndex = 71
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(443, 139)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 13)
        Me.Label18.TabIndex = 70
        Me.Label18.Text = "USERNAME"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(428, 518)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(173, 23)
        Me.Button3.TabIndex = 67
        Me.Button3.Text = "DELETE RESERVATION"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.Enabled = False
        Me.TextBox8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(538, 206)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(168, 26)
        Me.TextBox8.TabIndex = 66
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(443, 209)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 13)
        Me.Label15.TabIndex = 65
        Me.Label15.Text = "RETURN DATE"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(443, 174)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 13)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "BORROW DATE"
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(538, 171)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(168, 26)
        Me.TextBox7.TabIndex = 63
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(303, 518)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 23)
        Me.Button2.TabIndex = 62
        Me.Button2.Text = "BORROW"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(533, 98)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(137, 20)
        Me.TextBox6.TabIndex = 61
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(533, 67)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(137, 20)
        Me.TextBox5.TabIndex = 60
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(533, 31)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(137, 20)
        Me.TextBox4.TabIndex = 59
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(443, 105)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "LAST NAME"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(443, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "FIRST NAME"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(443, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "READER ID"
        '
        'LIBR
        '
        Me.LIBR.Location = New System.Drawing.Point(202, 215)
        Me.LIBR.Name = "LIBR"
        Me.LIBR.ReadOnly = True
        Me.LIBR.Size = New System.Drawing.Size(189, 20)
        Me.LIBR.TabIndex = 55
        '
        'AUT
        '
        Me.AUT.Location = New System.Drawing.Point(202, 174)
        Me.AUT.Name = "AUT"
        Me.AUT.ReadOnly = True
        Me.AUT.Size = New System.Drawing.Size(189, 20)
        Me.AUT.TabIndex = 54
        '
        'TITL
        '
        Me.TITL.Location = New System.Drawing.Point(202, 139)
        Me.TITL.Name = "TITL"
        Me.TITL.ReadOnly = True
        Me.TITL.Size = New System.Drawing.Size(189, 20)
        Me.TITL.TabIndex = 53
        '
        'ISB
        '
        Me.ISB.Location = New System.Drawing.Point(202, 105)
        Me.ISB.Name = "ISB"
        Me.ISB.ReadOnly = True
        Me.ISB.Size = New System.Drawing.Size(189, 20)
        Me.ISB.TabIndex = 52
        '
        'BID
        '
        Me.BID.Location = New System.Drawing.Point(202, 70)
        Me.BID.Name = "BID"
        Me.BID.ReadOnly = True
        Me.BID.Size = New System.Drawing.Size(189, 20)
        Me.BID.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "LIBRARY BRANCH"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "AUTHOR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "TRANSACTION ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "TITLE"
        '
        'TID
        '
        Me.TID.Location = New System.Drawing.Point(200, 31)
        Me.TID.Name = "TID"
        Me.TID.ReadOnly = True
        Me.TID.Size = New System.Drawing.Size(189, 20)
        Me.TID.TabIndex = 44
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "ISBN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "BOOK_ID"
        '
        'RESVBOOKBindingSource
        '
        Me.RESVBOOKBindingSource.DataMember = "RESV_BOOK"
        Me.RESVBOOKBindingSource.DataSource = Me.USDATADataSet5
        '
        'USDATADataSet5
        '
        Me.USDATADataSet5.DataSetName = "USDATADataSet5"
        Me.USDATADataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RESV_BOOKTableAdapter
        '
        Me.RESV_BOOKTableAdapter.ClearBeforeFill = True
        '
        'RESVBOOKBindingSource1
        '
        Me.RESVBOOKBindingSource1.DataMember = "RESV_BOOK"
        Me.RESVBOOKBindingSource1.DataSource = Me.USDATADataSet5
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TRANSACTIONIDDataGridViewTextBoxColumn, Me.READERIDDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.BOOKIDDataGridViewTextBoxColumn, Me.TITLEDataGridViewTextBoxColumn, Me.AUTHORDataGridViewTextBoxColumn, Me.LIBRARYBRANCHDataGridViewTextBoxColumn, Me.RESVDTDataGridViewTextBoxColumn, Me.ISBNDataGridViewTextBoxColumn, Me.USERNAMEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RESVBOOKBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(26, 55)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(769, 197)
        Me.DataGridView1.TabIndex = 72
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
        'RESVDTDataGridViewTextBoxColumn
        '
        Me.RESVDTDataGridViewTextBoxColumn.DataPropertyName = "RESV_D_T"
        Me.RESVDTDataGridViewTextBoxColumn.HeaderText = "RESV_D_T"
        Me.RESVDTDataGridViewTextBoxColumn.Name = "RESVDTDataGridViewTextBoxColumn"
        Me.RESVDTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ISBNDataGridViewTextBoxColumn
        '
        Me.ISBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.HeaderText = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.Name = "ISBNDataGridViewTextBoxColumn"
        Me.ISBNDataGridViewTextBoxColumn.ReadOnly = True
        '
        'USERNAMEDataGridViewTextBoxColumn
        '
        Me.USERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME"
        Me.USERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME"
        Me.USERNAMEDataGridViewTextBoxColumn.Name = "USERNAMEDataGridViewTextBoxColumn"
        Me.USERNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RESVBOOKBindingSource2
        '
        Me.RESVBOOKBindingSource2.DataMember = "RESV_BOOK"
        Me.RESVBOOKBindingSource2.DataSource = Me.USDATADataSet6
        '
        'USDATADataSet6
        '
        Me.USDATADataSet6.DataSetName = "USDATADataSet6"
        Me.USDATADataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RESV_BOOKTableAdapter1
        '
        Me.RESV_BOOKTableAdapter1.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(145, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 20)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "CHECK YOUR RESERVED BOOKS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(26, 26)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.ReadOnly = True
        Me.TextBox13.Size = New System.Drawing.Size(100, 20)
        Me.TextBox13.TabIndex = 73
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(840, 25)
        Me.FillByToolStrip.TabIndex = 75
        Me.FillByToolStrip.Text = "FillByToolStrip"
        Me.FillByToolStrip.Visible = False
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        Me.FillByToolStripButton.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.LIBR)
        Me.GroupBox1.Controls.Add(Me.AUT)
        Me.GroupBox1.Controls.Add(Me.TITL)
        Me.GroupBox1.Controls.Add(Me.ISB)
        Me.GroupBox1.Controls.Add(Me.BID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TID)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 255)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 257)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RESERVATION DETAILS"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(383, 28)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 21)
        Me.Button4.TabIndex = 72
        Me.Button4.Text = "PRINT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'RESERVED_BOOK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(840, 572)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Name = "RESERVED_BOOK"
        Me.Text = "RESERVED_BOOK"
        CType(Me.RESVBOOKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USDATADataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RESVBOOKBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RESVBOOKBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USDATADataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LIBR As System.Windows.Forms.TextBox
    Friend WithEvents AUT As System.Windows.Forms.TextBox
    Friend WithEvents TITL As System.Windows.Forms.TextBox
    Friend WithEvents ISB As System.Windows.Forms.TextBox
    Friend WithEvents BID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents USDATADataSet5 As DB_LIBRARY.USDATADataSet5
    Friend WithEvents RESVBOOKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RESV_BOOKTableAdapter As DB_LIBRARY.USDATADataSet5TableAdapters.RESV_BOOKTableAdapter
    Friend WithEvents RESVBOOKBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents USDATADataSet6 As DB_LIBRARY.USDATADataSet6
    Friend WithEvents RESVBOOKBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents RESV_BOOKTableAdapter1 As DB_LIBRARY.USDATADataSet6TableAdapters.RESV_BOOKTableAdapter
    Friend WithEvents TRANSACTIONIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents READERIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BOOKIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TITLEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AUTHORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LIBRARYBRANCHDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESVDTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ISBNDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USERNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
