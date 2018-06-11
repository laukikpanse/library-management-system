Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text


Public Class MODIFY_BOOK

    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim gender As String
    Dim cs As String = "Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True"

   

    Private Sub MODIFY_BOOK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'USDATADataSet.BOOKS' table. You can move, or remove it, as needed.
        Me.BOOKSTableAdapter.Fill(Me.USDATADataSet.BOOKS)

    
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")
        myconnection.Open()
        myconnection = New SqlConnection(cs)
        myconnection.Open()
        Dim cb1 As String = ("UPDATE BOOKS SET [ISBN]='" & TextBox2.Text & "', [TITLE]='" & TextBox3.Text & "', [AUTHOR]='" & TextBox4.Text & "', [PUBLISHER]='" & TextBox5.Text & "', [PUBLICATION_DATE]='" & TextBox6.Text & "', [LIBRARY_BRANCH]='" & TextBox7.Text & "', [AVAILABILITY]='" & TextBox8.Text & "' WHERE [BOOK_ID]= '" & TextBox1.Text & "'")
        mycommand = New SqlCommand(cb1)
        mycommand.Connection = myconnection
        mycommand.ExecuteNonQuery()
        myconnection.Close()

        MessageBox.Show("DETAILS SUCCESSFULLY UPDATED")



    End Sub


    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            Me.Show()
            Me.TextBox1.Text = dr.Cells(0).Value.ToString()
            Me.TextBox2.Text = dr.Cells(1).Value.ToString()
            Me.TextBox3.Text = dr.Cells(2).Value.ToString()
            Me.TextBox4.Text = dr.Cells(3).Value.ToString()
            Me.TextBox5.Text = dr.Cells(4).Value.ToString()
            Me.TextBox6.Text = dr.Cells(5).Value.ToString()
            Me.TextBox7.Text = dr.Cells(6).Value.ToString()
            Me.TextBox8.Text = dr.Cells(7).Value.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class