Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class ALL_AUTHORS
    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer
    Dim adp As SqlDataAdapter

    Dim cs As String = "Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True"
    Private Sub ALL_AUTHORS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'USDATADataSet.BOOKS' table. You can move, or remove it, as needed.
        Me.BOOKSTableAdapter.Fill(Me.USDATADataSet.BOOKS)
        'TODO: This line of code loads data into the 'USDATADataSet1.PUBLISHER' table. You can move, or remove it, as needed.
        Me.PUBLISHERTableAdapter.Fill(Me.USDATADataSet1.PUBLISHER)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim connection As New SqlConnection(cs)
        Dim dap As New SqlDataAdapter
        Dim ds As New DataSet()
        connection.Open()
        dap.Fill(ds, "BOOKS")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "BOOKS"
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub
End Class