Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class RETURN_BOOK
    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer
    Dim cs As String = "Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True"

    Private Sub RETURN_BOOK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
        TextBox6.Text = Date.Now.ToString("yyyy-MM-dd H:mm:ss")
        TextBox13.Text = USER_HOME.Label17.Text

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
   

        If (TextBox14.Text > 20) Then
            MessageBox.Show("PLEASE PAY YOUR FINE FIRST")
    

        Else

            myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")

            myconnection.Open()
            myconnection = New SqlConnection(cs)
            myconnection.Open()
            Dim cb As String = ("insert into RETURN_BOOK([TRANSACTION_ID],[READER_ID],[FIRST_NAME],[LAST_NAME],[BOOK_ID],[ISBN],[TITLE],[BORROW_D_T],[LIBRARY_BRANCH],[RETURN_D_T]) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox11.Text & "','" & TextBox9.Text & "','" & TextBox5.Text & "','" & TextBox10.Text & "','" & TextBox12.Text & "','" & TextBox4.Text & "','" & TextBox6.Text & "')")
            mycommand = New SqlCommand(cb)
            mycommand.Connection = myconnection
            mycommand.ExecuteNonQuery()
            myconnection.Close()


            myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")
            myconnection.Open()
            myconnection = New SqlConnection(cs)
            myconnection.Open()
            Dim cb1 As String = ("UPDATE BOOKS SET [AVAILABILITY]='AVAILABLE' WHERE [BOOK_ID]= '" & TextBox9.Text & "'")
            mycommand = New SqlCommand(cb1)
            mycommand.Connection = myconnection
            mycommand.ExecuteNonQuery()
            myconnection.Close()


            myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")
            myconnection.Open()
            myconnection = New SqlConnection(cs)
            myconnection.Open()
            Dim cb2 As String = ("DELETE FROM BORROW_BOOK WHERE [BOOK_ID]= '" & TextBox9.Text & "'")
            mycommand = New SqlCommand(cb2)
            mycommand.Connection = myconnection
            mycommand.ExecuteNonQuery()
            myconnection.Close()


            MessageBox.Show("BOOK RETURNED SUCCESSFULLY")
            Me.Hide()
            USER_HOME.Show()
            USER_HOME.DataGridView1.Show()
        End If
    End Sub


    Private Sub DataGridView1_RowHeaderMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            Me.Show()
            Me.TextBox7.Text = dr.Cells(1).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        myconnection = New SqlConnection("Data Source=ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")
        mycommand = New SqlCommand(" Select * from READER where READER_ID= @READER_ID And PASSWORD = @PASSWORD", myconnection)

        mycommand.Parameters.Add("@READER_ID", SqlDbType.VarChar).Value = TextBox7.Text
        mycommand.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = TextBox8.Text

        Dim adapter As New SqlDataAdapter(mycommand)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then
            MessageBox.Show("Username Or Password are invalid")

        Else
            MessageBox.Show("AUTHORIZATION SUCCESSFUL")


            Try
                Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
                Me.Hide()
                Me.Show()
                Me.TextBox1.Text = dr.Cells(0).Value.ToString()
                Me.TextBox2.Text = dr.Cells(1).Value.ToString()
                Me.TextBox3.Text = dr.Cells(2).Value.ToString()
                Me.TextBox11.Text = dr.Cells(3).Value.ToString()
                Me.TextBox9.Text = dr.Cells(4).Value.ToString()
                Me.TextBox5.Text = dr.Cells(9).Value.ToString()
                Me.TextBox10.Text = dr.Cells(5).Value.ToString()
                Me.TextBox4.Text = dr.Cells(7).Value.ToString()
                Me.TextBox12.Text = dr.Cells(8).Value.ToString()
                Me.TextBox7.Text = dr.Cells(1).Value.ToString()

                Dim firstDate, msg As String
                Dim secondDate As Date
                firstDate = TextBox12.Text
                secondDate = CDate(firstDate)
                msg = "" & DateDiff(DateInterval.Day, secondDate, Now)
                TextBox14.Text = (msg)

                If (TextBox14.Text > 20) Then


                    TextBox15.Text = ((TextBox14.Text-20) * 0.2) & "$"
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End If

        


    End Sub

   



    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.BORROW_BOOKTableAdapter1.FillBy(Me.USDATADataSet3.BORROW_BOOK)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox13_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox13.Validated

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'TODO: This line of code loads data into the 'USDATADataSet2.BORROW_BOOK' table. You can move, or remove it, as needed.
        Me.BORROW_BOOKTableAdapter.Fill(Me.USDATADataSet2.BORROW_BOOK)

        Try
            myconnection = New SqlConnection(cs)
            myconnection.Open()
            mycommand = New SqlCommand("SELECT TRANSACTION_ID as [TRANSACTION_ID], READER_ID as [READER_ID], FIRST_NAME as [FIRST_NAME], LAST_NAME as [LAST_NAME],BOOK_ID as [BOOK_ID],TITLE AS [TITLE],AUTHOR AS [AUTHOR], LIBRARY_BRANCH AS [LIBRARY_BRANCH],BORROW_D_T AS [BORROW_D_T],ISBN AS [ISBN],RETURN_D_T AS [RETURN_D_T],USERNAME AS [USERNAME] from BORROW_BOOK where USERNAME='" & TextBox13.Text & "%' order by USERNAME ", myconnection)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(mycommand)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "BORROW_BOOK")
            DataGridView1.DataSource = myDataSet.Tables("BORROW_BOOK").DefaultView
            myconnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Try
            myconnection = New SqlConnection(cs)
            myconnection.Open()
            mycommand = New SqlCommand("SELECT TRANSACTION_ID as [TRANSACTION_ID], READER_ID as [READER_ID], FIRST_NAME as [FIRST_NAME], LAST_NAME as [LAST_NAME],BOOK_ID as [BOOK_ID],TITLE AS [TITLE],AUTHOR AS [AUTHOR], LIBRARY_BRANCH AS [LIBRARY_BRANCH], BORROW_D_T AS [BORROW_D_T], ISBN AS [ISBN], RETURN_D_T AS [RETURN_D_T], USERNAME AS [USERNAME] from BORROW_BOOK where USERNAME like '" & TextBox13.Text & "%' order by USERNAME ", myconnection)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(mycommand)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "BORROW_BOOK")
            DataGridView1.DataSource = myDataSet.Tables("BORROW_BOOK").DefaultView
            myconnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox16.Text = "SUPERUSER" And
                   TextBox17.Text = "SUPERUSER" Then

            myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")

            myconnection.Open()
            myconnection = New SqlConnection(cs)
            myconnection.Open()
            Dim cb As String = ("insert into RETURN_BOOK([TRANSACTION_ID],[READER_ID],[FIRST_NAME],[LAST_NAME],[BOOK_ID],[ISBN],[TITLE],[BORROW_D_T],[LIBRARY_BRANCH],[RETURN_D_T]) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox11.Text & "','" & TextBox9.Text & "','" & TextBox5.Text & "','" & TextBox10.Text & "','" & TextBox12.Text & "','" & TextBox4.Text & "','" & TextBox6.Text & "')")
            mycommand = New SqlCommand(cb)
            mycommand.Connection = myconnection
            mycommand.ExecuteNonQuery()
            myconnection.Close()


            myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")
            myconnection.Open()
            myconnection = New SqlConnection(cs)
            myconnection.Open()
            Dim cb1 As String = ("UPDATE BOOKS SET [AVAILABILITY]='AVAILABLE' WHERE [BOOK_ID]= '" & TextBox9.Text & "'")
            mycommand = New SqlCommand(cb1)
            mycommand.Connection = myconnection
            mycommand.ExecuteNonQuery()
            myconnection.Close()


            myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")
            myconnection.Open()
            myconnection = New SqlConnection(cs)
            myconnection.Open()
            Dim cb2 As String = ("DELETE FROM BORROW_BOOK WHERE [BOOK_ID]= '" & TextBox9.Text & "'")
            mycommand = New SqlCommand(cb2)
            mycommand.Connection = myconnection
            mycommand.ExecuteNonQuery()
            myconnection.Close()

            myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")

            myconnection.Open()
            myconnection = New SqlConnection(cs)
            myconnection.Open()
            Dim cb5 As String = ("insert into FINE([TRANSACTION_ID],[READER_ID],[USERNAME],[FINE]) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox13.Text & "','" & TextBox15.Text & "')")
            mycommand = New SqlCommand(cb5)
            mycommand.Connection = myconnection
            mycommand.ExecuteNonQuery()
            myconnection.Close()


            MessageBox.Show("BOOK RETURNED SUCCESSFULLY")
            Me.Hide()
            USER_HOME.Show()
            USER_HOME.DataGridView1.Show()


        Else
            MessageBox.Show("Access Denied")

        End If
    End Sub

End Class

