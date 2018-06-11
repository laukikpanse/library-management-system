Public Class TOP_BOOKS

    Private Sub TOP_BOOKS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'USDATADataSet14.BOOKS' table. You can move, or remove it, as needed.
        Me.BOOKSTableAdapter1.Fill(Me.USDATADataSet14.BOOKS)
        'TODO: This line of code loads data into the 'USDATADataSet.BOOKS' table. You can move, or remove it, as needed.
        Me.BOOKSTableAdapter.Fill(Me.USDATADataSet.BOOKS)

    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.BOOKSTableAdapter1.FillBy(Me.USDATADataSet14.BOOKS)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.BOOKSTableAdapter1.FillBy1(Me.USDATADataSet14.BOOKS)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy2ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillBy2ToolStripButton.Click
        Try
            Me.BOOKSTableAdapter1.FillBy2(Me.USDATADataSet14.BOOKS)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class