Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text


Public Class FINE_DETAILS
    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
    Dim DataAdapter = New SqlDataAdapter()
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer
    Dim cs As String = "Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True"
    Private Sub FINE_DETAILS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'USDATADataSet7.FINE' table. You can move, or remove it, as needed.
        Me.FINETableAdapter.Fill(Me.USDATADataSet7.FINE)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Decimal = 0
        For i As Decimal = 0 To DataGridView1.RowCount - 1
            total += DataGridView1.Rows(i).Cells(3).Value

        Next
        TextBox2.Text = total


        Dim AVERAGE As Decimal
        For i As Decimal = 0 To DataGridView1.RowCount - 1
            AVERAGE = total / (DataGridView1.RowCount - 1)
        Next
        TextBox3.Text = AVERAGE



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            myconnection = New SqlConnection(cs)
            myconnection.Open()
            mycommand = New SqlCommand("SELECT TRANSACTION_ID as [TRANSACTION_ID], READER_ID as [READER_ID], USERNAME as [USERNAME], FINE as [FINE] from FINE where READER_ID like '" & TextBox1.Text & "%' order by READER_ID", myconnection)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(mycommand)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "FINE")
            DataGridView1.DataSource = myDataSet.Tables("FINE").DefaultView
            myconnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class