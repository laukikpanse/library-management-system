Imports System.Data.SqlClient

Public Class ALL_PUBLISHERS
    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
    Dim dap = New SqlDataAdapter()
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer
    Dim cs As String = "Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True"

    Private Sub ALL_PUBLISHERS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'USDATADataSet8.PUBLISHER' table. You can move, or remove it, as needed.
        Me.PUBLISHERTableAdapter1.Fill(Me.USDATADataSet8.PUBLISHER)
        'TODO: This line of code loads data into the 'USDATADataSet1.PUBLISHER' table. You can move, or remove it, as needed.
        Me.PUBLISHERTableAdapter.Fill(Me.USDATADataSet1.PUBLISHER)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim connection As New SqlConnection(cs)
        Dim dap As New SqlDataAdapter
        Dim ds As New DataSet()
        connection.Open()
        dap.Fill(ds, "PUBLISHER")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "PUBLISHER_ID"
    End Sub

End Class