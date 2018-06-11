Public Class TOP_BORROW
    Private Sub TOP_BORROW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'USDATADataSet12.TOP_BORROWERS' table. You can move, or remove it, as needed.
        Me.TOP_BORROWERSTableAdapter.Fill(Me.USDATADataSet12.TOP_BORROWERS)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.TOP_BORROWERSTableAdapter.FillBy(Me.USDATADataSet12.TOP_BORROWERS)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.TOP_BORROWERSTableAdapter.FillBy1(Me.USDATADataSet12.TOP_BORROWERS)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy2ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.TOP_BORROWERSTableAdapter.FillBy2(Me.USDATADataSet12.TOP_BORROWERS)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy3ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy3ToolStripButton.Click
        Try
            Me.TOP_BORROWERSTableAdapter.FillBy3(Me.USDATADataSet12.TOP_BORROWERS)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class