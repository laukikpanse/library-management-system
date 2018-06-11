Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class DELETE_USER
    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer
    Dim adp As SqlDataAdapter

    Dim cs As String = "Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True"
    Private Sub DELETE_USER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'USDATADataSet.READER' table. You can move, or remove it, as needed.
        Me.READERTableAdapter.Fill(Me.USDATADataSet.READER)



    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            myconnection = New SqlConnection(cs)
            myconnection.Open()
            mycommand = New SqlCommand("SELECT READER_ID as [READER_ID], FIRST_NAME as [FIRST_NAME], LAST_NAME as [LAST_NAME], ADDRESS as [ADDRESS],PHONE_NO as [PHONE_NO],EMAIL_ID AS [EMAIL_ID],USERNAME AS [USERNAME], PASSWORD AS [PASSWORD] from READER where READER_ID like '" & TextBox1.Text & "%' order by READER_ID ", myconnection)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(mycommand)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "BOOKS")
            DataGridView1.DataSource = myDataSet.Tables("BOOKS").DefaultView
            myconnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
    Private Sub DataGridView1_RowHeaderMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            Me.Show()
            TextBox2.Text = dr.Cells(0).Value.ToString()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")
        myconnection.Open()
        myconnection = New SqlConnection(cs)
        myconnection.Open()
        Dim cb2 As String = ("DELETE FROM READER WHERE [READER_ID]= '" & TextBox2.Text & "'")
        mycommand = New SqlCommand(cb2)
        mycommand.Connection = myconnection
        mycommand.ExecuteNonQuery()
        myconnection.Close()
        MessageBox.Show("READER DELETED SUCCESSFULLY")
        Me.Close()
        ADMIN_HOME.Show()

    End Sub


End Class