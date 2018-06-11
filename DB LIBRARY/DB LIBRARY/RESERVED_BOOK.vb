Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class RESERVED_BOOK
    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
    Dim dap = New SqlDataAdapter()
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer
    Dim cs As String = "Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True"

    Private Sub RESERVED_BOOK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        TextBox8.Text = Date.Now.AddDays(20).ToString("yyyy-MM-dd H:mm:ss")

        TextBox13.Text = USER_HOME.Label17.Text

     
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")

        myconnection.Open()

        myconnection = New SqlConnection(cs)
        myconnection.Open()

        Dim cb As String = ("insert into BORROW_BOOK([TRANSACTION_ID],[READER_ID],[FIRST_NAME],[LAST_NAME],[BOOK_ID],[TITLE],[AUTHOR],[LIBRARY_BRANCH],[BORROW_D_T],[ISBN],[RETURN_D_T],[USERNAME]) values ('" & TID.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & BID.Text & "','" & TITL.Text & "','" & AUT.Text & "','" & LIBR.Text & "','" & TextBox7.Text & "','" & ISB.Text & "','" & TextBox8.Text & "','" & TextBox10.Text & "')")
        mycommand = New SqlCommand(cb)
        mycommand.Connection = myconnection
        mycommand.ExecuteNonQuery()
        myconnection.Close()
        myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")

        myconnection.Open()

        myconnection = New SqlConnection(cs)
        myconnection.Open()
        Dim cb1 As String = ("DELETE FROM RESV_BOOK WHERE TRANSACTION_ID= '" & TID.Text & "'")
        mycommand = New SqlCommand(cb1)
        mycommand.Connection = myconnection
        mycommand.ExecuteNonQuery()
        myconnection.Close()

        MessageBox.Show("Thankyou BOOK BORROWED successfully")


        myconnection.Close()
        myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")

        myconnection.Open()

        myconnection = New SqlConnection(cs)
        myconnection.Open()
        Dim cb2 As String = ("UPDATE BOOKS SET [AVAILABILITY]='ISSUED' WHERE [BOOK_ID]= '" & BID.Text & "'")
        mycommand = New SqlCommand(cb1)
        mycommand.Connection = myconnection
        mycommand.ExecuteNonQuery()
        myconnection.Close()
        Me.Close()

    End Sub



    Private Sub DataGridView1_RowHeaderMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            Me.Show()
            Me.TID.Text = dr.Cells(0).Value.ToString()
            Me.TextBox4.Text = dr.Cells(1).Value.ToString()
            Me.TextBox5.Text = dr.Cells(2).Value.ToString()
            Me.TextBox6.Text = dr.Cells(3).Value.ToString()
            Me.BID.Text = dr.Cells(4).Value.ToString()
            Me.TITL.Text = dr.Cells(5).Value.ToString()
            Me.AUT.Text = dr.Cells(6).Value.ToString()
            Me.LIBR.Text = dr.Cells(7).Value.ToString()
            Me.TextBox7.Text = dr.Cells(8).Value.ToString()
            Me.ISB.Text = dr.Cells(9).Value.ToString()
            Me.TextBox10.Text = dr.Cells(10).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")
        myconnection.Open()
        myconnection = New SqlConnection(cs)
        myconnection.Open()
        Dim cb1 As String = ("DELETE FROM RESV_BOOK WHERE [TRANSACTION_ID]= '" & TID.Text & "'")
        mycommand = New SqlCommand(cb1)
        mycommand.Connection = myconnection
        mycommand.ExecuteNonQuery()
        myconnection.Close()


        myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")
        myconnection.Open()
        myconnection = New SqlConnection(cs)
        myconnection.Open()
        Dim cb2 As String = ("UPDATE BOOKS SET [AVAILABILITY]='AVAILABLE' WHERE [BOOK_ID]= '" & BID.Text & "'")
        mycommand = New SqlCommand(cb2)
        mycommand.Connection = myconnection
        mycommand.ExecuteNonQuery()
        myconnection.Close()
        MessageBox.Show("Thankyou RESERVATION CANCELLED successfully")


       
        Me.Close()




    End Sub


  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'TODO: This line of code loads data into the 'USDATADataSet6.RESV_BOOK' table. You can move, or remove it, as needed.
        Me.RESV_BOOKTableAdapter1.Fill(Me.USDATADataSet6.RESV_BOOK)
        'TODO: This line of code loads data into the 'USDATADataSet5.RESV_BOOK' table. You can move, or remove it, as needed.
        Me.RESV_BOOKTableAdapter.Fill(Me.USDATADataSet5.RESV_BOOK)
        Try
            myconnection = New SqlConnection(cs)
            myconnection.Open()
            mycommand = New SqlCommand("SELECT TRANSACTION_ID as [TRANSACTION_ID], READER_ID as [READER_ID], FIRST_NAME as [FIRST_NAME], LAST_NAME as [LAST_NAME],BOOK_ID as [BOOK_ID],TITLE AS [TITLE],AUTHOR AS [AUTHOR], LIBRARY_BRANCH AS [LIBRARY_BRANCH], RESV_D_T AS [RESV_D_T],ISBN AS [ISBN], USERNAME AS [USERNAME] from RESV_BOOK where USERNAME='" & TextBox13.Text & "%' order by USERNAME ", myconnection)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(mycommand)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "RESV_BOOK")
            DataGridView1.DataSource = myDataSet.Tables("RESV_BOOK").DefaultView
            myconnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Try
            myconnection = New SqlConnection(cs)
            myconnection.Open()
            mycommand = New SqlCommand("SELECT TRANSACTION_ID as [TRANSACTION_ID], READER_ID as [READER_ID], FIRST_NAME as [FIRST_NAME], LAST_NAME as [LAST_NAME],BOOK_ID as [BOOK_ID],TITLE AS [TITLE],AUTHOR AS [AUTHOR], LIBRARY_BRANCH AS [LIBRARY_BRANCH], RESV_D_T AS [RESV_D_T], ISBN AS [ISBN], USERNAME AS [USERNAME] from RESV_BOOK where USERNAME like '" & TextBox13.Text & "%' order by USERNAME ", myconnection)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(mycommand)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "RESV_BOOK")
            DataGridView1.DataSource = myDataSet.Tables("RESV_BOOK").DefaultView
            myconnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

 


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim myconnection As New SqlConnection(cs)
        myconnection.Open()
        mycommand = New SqlCommand("SELECT TRANSACTION_ID as [TRANSACTION_ID], READER_ID as [READER_ID], FIRST_NAME as [FIRST_NAME], LAST_NAME as [LAST_NAME],BOOK_ID as [BOOK_ID],TITLE AS [TITLE],AUTHOR AS [AUTHOR], LIBRARY_BRANCH AS [LIBRARY_BRANCH], RESV_D_T AS [RESV_D_T], ISBN AS [ISBN], USERNAME AS [USERNAME] from RESV_BOOK where USERNAME like '" & TextBox13.Text & "%' order by USERNAME ", myconnection)
        Dim myDA As SqlDataAdapter = New SqlDataAdapter(mycommand)
        Dim myDataSet As DataSet = New DataSet()
        myDA.SelectCommand = mycommand
        myDA.Fill(myDataSet, "RESV_BOOK")

        DataGridView1.DataSource = myDataSet.Tables("RESV_BOOK").DefaultView
        myconnection.Close()

        PrintDocument1.Print()


    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub
End Class