Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text


Public Class ALL_USERS
    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer
    Dim adp As SqlDataAdapter

    Dim cs As String = "Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True"
    Private Sub ALL_USERS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub ALL_USERS_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'USDATADataSet.READER' table. You can move, or remove it, as needed.
        Me.READERTableAdapter2.Fill(Me.USDATADataSet.READER)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
        Dim connection As New SqlConnection(cs)
        Dim dap As New SqlDataAdapter
        Dim ds As New DataSet()
        connection.Open()
        dap.Fill(ds, "USERS")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "USERS"
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

End Class