Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class AVERAGE_FINE
    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer
    Dim cs As String = "Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True"
    Private Sub AVERAGE_FINE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'USDATADataSet7.FINE' table. You can move, or remove it, as needed.
        Me.FINETableAdapter.Fill(Me.USDATADataSet7.FINE)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            myconnection = New SqlConnection(cs)
            myconnection.Open()
            mycommand = New SqlCommand("SELECT TRANSACTION_ID as [TRANSACTION_ID], READER_ID as [READER_ID], USERNAME AS [USERNAME], FINE AS [FINE] from FINE order by USERNAME ", myconnection)
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