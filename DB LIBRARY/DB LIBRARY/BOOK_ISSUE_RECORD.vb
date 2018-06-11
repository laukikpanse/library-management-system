Public Class BOOK_ISSUE_RECORD

    Private Sub BOOK_ISSUE_RECORD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'USDATADataSet2.BORROW_BOOK' table. You can move, or remove it, as needed.
        Me.BORROW_BOOKTableAdapter.Fill(Me.USDATADataSet2.BORROW_BOOK)

    End Sub
End Class