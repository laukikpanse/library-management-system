Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text




Public Class MODIFY_USER
    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim gender As String
    Dim cs As String = "Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True"


    Private Sub MODIFY_USER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'USDATADataSet.READER' table. You can move, or remove it, as needed.
        Me.READERTableAdapter.Fill(Me.USDATADataSet.READER)
        'TODO: This line of code loads data into the 'USDATADataSet.BOOKS' table. You can move, or remove it, as needed.
        Me.BOOKSTableAdapter.Fill(Me.USDATADataSet.BOOKS)

    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            Me.Show()
            Me.TextBox1.Text = dr.Cells(0).Value.ToString()
            Me.TextBox2.Text = dr.Cells(1).Value.ToString()
            Me.TextBox3.Text = dr.Cells(2).Value.ToString()
            Me.CMBREGADD.Text = dr.Cells(3).Value.ToString()
            Me.TextBox4.Text = dr.Cells(4).Value.ToString()
            Me.TextBox5.Text = dr.Cells(5).Value.ToString()
            Me.TextBox6.Text = dr.Cells(6).Value.ToString()
            Me.TextBox7.Text = dr.Cells(7).Value.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")
        myconnection.Open()
        myconnection = New SqlConnection(cs)
        myconnection.Open()
        Dim cb1 As String = ("UPDATE READER SET [FIRST_NAME]='" & TextBox2.Text & "', [LAST_NAME]='" & TextBox3.Text & "', [ADDRESS]='" & CMBREGADD.Text & "', [PHONE_NO]='" & TextBox4.Text & "', [EMAIL_ID]='" & TextBox5.Text & "', [USERNAME]='" & TextBox6.Text & "', [PASSWORD]='" & TextBox7.Text & "' WHERE [READER_ID]= '" & TextBox1.Text & "'")
        mycommand = New SqlCommand(cb1)
        mycommand.Connection = myconnection
        mycommand.ExecuteNonQuery()
        myconnection.Close()

        MessageBox.Show("DETAILS SUCCESSFULLY UPDATED")
        Me.Close()

    End Sub
End Class
