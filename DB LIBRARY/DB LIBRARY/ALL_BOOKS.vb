Public Class ALL_BOOKS

    Private Sub ALL_BOOKS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MYLIBRARYDataSet1.BOOKS' table. You can move, or remove it, as needed.
       

    End Sub

    Private Sub ALL_BOOKS_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'USDATADataSet.BOOKS' table. You can move, or remove it, as needed.
        Me.BOOKSTableAdapter2.Fill(Me.USDATADataSet.BOOKS)

    End Sub

   
    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.RowHeaderMouseClick
     
    End Sub
End Class