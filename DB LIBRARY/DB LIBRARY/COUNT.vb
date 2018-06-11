Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class COUNT
    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer
    Dim adp As SqlDataAdapter

    Dim cs As String = "Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True"

    Private Sub COUNT_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'USDATADataSet.BOOKS' table. You can move, or remove it, as needed.
        Me.BOOKSTableAdapter.Fill(Me.USDATADataSet.BOOKS)

       
    End Sub

    
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "NEW YORK" Then
            Dim cs As String = "Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True"
            Dim conn As New SqlConnection(cs)
            conn.Open()
            Dim cb As New SqlCommand("SELECT COUNT(BOOK_ID) AS COUNT FROM BOOKS WHERE LIBRARY_BRANCH='NEW YORK'", conn)
            Dim reader As SqlDataReader = cb.ExecuteReader
            Dim dt As New DataTable
            dt.Load(reader)
            ListBox1.DataSource = dt
            ListBox1.DisplayMember = "COUNT"
            conn.Close()
        ElseIf ComboBox1.SelectedItem = "NEW JERSEY" Then
            Dim cs As String = "Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True"
            Dim conn As New SqlConnection(cs)
            conn.Open()
            Dim cb As New SqlCommand("SELECT COUNT(BOOK_ID) AS COUNT FROM BOOKS WHERE LIBRARY_BRANCH='NEW JERSEY'", conn)
            Dim reader As SqlDataReader = cb.ExecuteReader
            Dim dt As New DataTable
            dt.Load(reader)
            ListBox1.DataSource = dt
            ListBox1.DisplayMember = "COUNT"
            conn.Close()

        ElseIf ComboBox1.SelectedItem = "CONNECTICUT" Then
            Dim cs As String = "Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True"
            Dim conn As New SqlConnection(cs)
            conn.Open()
            Dim cb As New SqlCommand("SELECT COUNT(BOOK_ID) AS COUNT FROM BOOKS WHERE LIBRARY_BRANCH='CONNECTICUT'", conn)
            Dim reader As SqlDataReader = cb.ExecuteReader
            Dim dt As New DataTable
            dt.Load(reader)
            ListBox1.DataSource = dt
            ListBox1.DisplayMember = "COUNT"
            conn.Close()

        End If
    End Sub
End Class

