Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class USER_HOME
    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
    Dim DataAdapter = New SqlDataAdapter()
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer
    Dim cs As String = "Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True"
    Public Shared Function GetUniqueKey(ByVal maxSize As Integer) As String
        Dim chars As Char() = New Char(61) {}
        chars = "123456789".ToCharArray()
        Dim data As Byte() = New Byte(0) {}
        Dim crypto As New RNGCryptoServiceProvider()
        crypto.GetNonZeroBytes(data)
        data = New Byte(maxSize - 1) {}
        crypto.GetNonZeroBytes(data)
        Dim result As New StringBuilder(maxSize)
        For Each b As Byte In data
            result.Append(chars(b Mod (chars.Length)))
        Next
        Return result.ToString()
    End Function
    Private Function RESET()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Function
    Private Function RESET1()
        Me.BID.Text = ""
        Me.ISB.Text = ""
        Me.TITL.Text = ""
        Me.AUT.Text = ""
        Me.LIBR.Text = ""
        Me.TextBox4.Text = ""
        Me.TextBox5.Text = ""
        Me.TextBox6.Text = ""
    End Function
    Private Sub ME_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        
        'TODO: This line of code loads data into the 'USDATADataSet.READER' table. You can move, or remove it, as needed.
        Me.READERTableAdapter.Fill(Me.USDATADataSet.READER)
        'TODO: This line of code loads data into the 'USDATADataSet1.BOOKS' table. You can move, or remove it, as needed.
        Me.BOOKSTableAdapter.Fill(Me.USDATADataSet1.BOOKS)
        'TODO: This line of code loads data into the 'USDATADataSet.BOOKS' table. You can move, or remove it, as needed.
        Me.BOOKSTableAdapter.Fill(Me.USDATADataSet.BOOKS)
        TextBox7.Text = Date.Now.ToString("yyyy-MM-dd H:mm:ss")
        TextBox8.Text = Date.Now.AddDays(20).ToString("yyyy-MM-dd H:mm:ss")
        Label17.Text = USER_LOGIN.usrlogintxt.Text
        Me.READERTableAdapter.Fill(Me.USDATADataSet.READER)

        Label20.Text = TimeOfDay.ToString("H:mm:ss")
    

    End Sub


    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.BOOKSTableAdapter.FillBy(Me.USDATADataSet.BOOKS)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.BOOKSTableAdapter.FillBy1(Me.USDATADataSet.BOOKS)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub BORROWBOOKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Show()

    End Sub

    Private Sub FillBy4ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillBy4ToolStripButton.Click
        Try
            Me.BOOKSTableAdapter.FillBy4(Me.USDATADataSet.BOOKS)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy5ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillBy5ToolStripButton.Click
        Try
            Me.BOOKSTableAdapter.FillBy5(Me.USDATADataSet.BOOKS)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy6ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillBy6ToolStripButton.Click
        Try
            Me.BOOKSTableAdapter.FillBy6(Me.USDATADataSet.BOOKS)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox1.Text = "" And TextBox3.Text = "" Then
            Try
                myconnection = New SqlConnection(cs)
                myconnection.Open()
                mycommand = New SqlCommand("SELECT BOOK_ID as [BOOK_ID], ISBN as [ISBN], TITLE as [TITLE], AUTHOR as [AUTHOR],PUBLISHER as [PUBLISHER],PUBLICATION_DATE AS [PUBLICATION_DATE],LIBRARY_BRANCH AS [LIBRARY_BRANCH], AVAILABILITY AS [AVAILABILITY]from BOOKS where PUBLISHER like '" & TextBox2.Text & "%' order by PUBLISHER ", myconnection)
                Dim myDA As SqlDataAdapter = New SqlDataAdapter(mycommand)
                Dim myDataSet As DataSet = New DataSet()
                myDA.Fill(myDataSet, "BOOKS")
                DataGridView1.DataSource = myDataSet.Tables("BOOKS").DefaultView
                myconnection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("PLEASE USE ANY ONE FILTER")
            RESET()
        End If
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox2.Text = "" And TextBox3.Text = "" Then
            Try
                myconnection = New SqlConnection(cs)
                myconnection.Open()
                mycommand = New SqlCommand("SELECT BOOK_ID as [BOOK_ID], ISBN as [ISBN], TITLE as [TITLE], AUTHOR as [AUTHOR],PUBLISHER as [PUBLISHER],PUBLICATION_DATE AS [PUBLICATION_DATE],LIBRARY_BRANCH AS [LIBRARY_BRANCH], AVAILABILITY AS [AVAILABILITY] from BOOKS where ISBN like '" & TextBox1.Text & "%' order by ISBN ", myconnection)
                Dim myDA As SqlDataAdapter = New SqlDataAdapter(mycommand)
                Dim myDataSet As DataSet = New DataSet()
                myDA.Fill(myDataSet, "BOOKS")
                DataGridView1.DataSource = myDataSet.Tables("BOOKS").DefaultView
                myconnection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("PLEASE USE ANY ONE FILTER")
            RESET()
        End If
    End Sub


    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox2.Text = "" And TextBox1.Text = "" Then
            Try
                myconnection = New SqlConnection(cs)
                myconnection.Open()
                mycommand = New SqlCommand("SELECT BOOK_ID as [BOOK_ID], ISBN as [ISBN], TITLE as [TITLE], AUTHOR as [AUTHOR],PUBLISHER as [PUBLISHER],PUBLICATION_DATE AS [PUBLICATION_DATE],LIBRARY_BRANCH AS [LIBRARY_BRANCH], AVAILABILITY AS [AVAILABILITY] from BOOKS where TITLE like '" & TextBox3.Text & "%' order by TITLE ", myconnection)
                Dim myDA As SqlDataAdapter = New SqlDataAdapter(mycommand)
                Dim myDataSet As DataSet = New DataSet()
                myDA.Fill(myDataSet, "BOOKS")
                DataGridView1.DataSource = myDataSet.Tables("BOOKS").DefaultView
                myconnection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("PLEASE USE ANY ONE FILTER")
            RESET()
        End If
    End Sub



    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick

      

        Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
        Me.Hide()
        Me.Show()
        Me.BID.Text = dr.Cells(0).Value.ToString()
        Me.ISB.Text = dr.Cells(1).Value.ToString()
        Me.TITL.Text = dr.Cells(2).Value.ToString()
        Me.AUT.Text = dr.Cells(3).Value.ToString()
        Me.LIBR.Text = dr.Cells(6).Value.ToString()
        Me.TextBox9.Text = dr.Cells(7).Value.ToString()

        Try
            Dim dr1 As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            Me.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        SELECT_USER.Show()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
       
        
        If Len(Trim(BID.Text)) = 0 Then
            MessageBox.Show("Please retrieve BOOK DETAILS", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BID.Focus()
            Exit Sub
        End If

        If Len(Trim(TextBox5.Text)) = 0 Then
            MessageBox.Show("Please retrieve USER DETAILS", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox5.Focus()
            Exit Sub
        End If

      

        If TextBox9.Text = "ISSUED" Then
            MessageBox.Show("BOOK NOT AVAILABLE")


        ElseIf TextBox9.Text = "RESERVED" Then

            MessageBox.Show("BOOK NOT AVAILABLE")

          

        Else
            myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")

            myconnection.Open()

            myconnection = New SqlConnection(cs)
            myconnection.Open()
            TID.Text = "" & GetUniqueKey(7)
            Dim cb As String = ("insert into BORROW_BOOK([TRANSACTION_ID],[READER_ID],[FIRST_NAME],[LAST_NAME],[BOOK_ID],[TITLE],[AUTHOR],[LIBRARY_BRANCH],[BORROW_D_T],[ISBN],[RETURN_D_T],[USERNAME]) values ('" & TID.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & BID.Text & "','" & TITL.Text & "','" & AUT.Text & "','" & LIBR.Text & "','" & TextBox7.Text & "','" & ISB.Text & "','" & TextBox8.Text & "','" & TextBox10.Text & "')")
            mycommand = New SqlCommand(cb)
            mycommand.Connection = myconnection
            mycommand.ExecuteNonQuery()
            myconnection.Close()
            myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")

            myconnection.Open()

            myconnection = New SqlConnection(cs)
            myconnection.Open()
            Dim cb1 As String = ("UPDATE BOOKS SET [AVAILABILITY]='ISSUED' WHERE [BOOK_ID]= '" & BID.Text & "'")
            mycommand = New SqlCommand(cb1)
            mycommand.Connection = myconnection
            mycommand.ExecuteNonQuery()
            myconnection.Close()

            myconnection = New SqlConnection(cs)
            myconnection.Open()
            Dim cb8 As String = ("UPDATE BOOKS SET [COUNT]=(COUNT + 1) WHERE [BOOK_ID]= '" & BID.Text & "'")
            mycommand = New SqlCommand(cb8)
            mycommand.Connection = myconnection
            mycommand.ExecuteNonQuery()
            myconnection.Close()

            myconnection = New SqlConnection(cs)
            myconnection.Open()
            Dim cb7 As String = ("UPDATE TOP_BORROWERS SET [BOOKS_BORROWED]=(BOOKS_BORROWED + 1) WHERE [READER_ID]= '" & TextBox4.Text & "'")
            mycommand = New SqlCommand(cb7)
            mycommand.Connection = myconnection
            mycommand.ExecuteNonQuery()
            myconnection.Close()


            MessageBox.Show("Thankyou BOOK BORROWED successfully")

            


            myconnection.Close()
            Me.Refresh()
        End If
    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim myCompareTime As DateTime = DateTime.Parse("18:00:00")
        Dim myCompareTime1 As DateTime = DateTime.Parse("10:00:00")

        If myCompareTime.TimeOfDay.ToString < Label20.Text Then

            MessageBox.Show("RESERVATION NOT AVAILABLE")

        ElseIf myCompareTime1.TimeOfDay.ToString > Label20.Text Then

            MessageBox.Show("RESERVATION NOT AVAILABLE")

        Else
            myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")

            myconnection.Open()

            myconnection = New SqlConnection(cs)
            myconnection.Open()
            TID.Text = "TRAN_ID-" & GetUniqueKey(7)
            Dim cb As String = ("insert into RESV_BOOK([TRANSACTION_ID],[READER_ID],[FIRST_NAME],[LAST_NAME],[BOOK_ID],[TITLE],[AUTHOR],[LIBRARY_BRANCH],[ISBN],[USERNAME],[RESV_D_T]) values ('" & TID.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & BID.Text & "','" & TITL.Text & "','" & AUT.Text & "','" & LIBR.Text & "','" & ISB.Text & "','" & TextBox10.Text & "','" & TextBox7.Text & "')")
            mycommand = New SqlCommand(cb)
            mycommand.Connection = myconnection
            mycommand.ExecuteNonQuery()
            myconnection.Close()

            myconnection.Close()
            myconnection.Open()

            myconnection = New SqlConnection(cs)
            myconnection.Open()
            Dim cb1 As String = ("UPDATE BOOKS SET [AVAILABILITY]='RESERVED' WHERE [BOOK_ID]= '" & BID.Text & "'")
            mycommand = New SqlCommand(cb1)
            mycommand.Connection = myconnection
            mycommand.ExecuteNonQuery()
            myconnection.Close()



            MessageBox.Show("Thankyou BOOK RESERVED successfully")
            RESET1()


        End If
    End Sub

    Private Sub RETURNBOOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RETURNBOOToolStripMenuItem.Click
        RETURN_BOOK.Show()
        Try
            myconnection = New SqlConnection(cs)
            myconnection.Open()
            mycommand = New SqlCommand("SELECT READER_ID as [READER_ID], FIRST_NAME as [FIRST_NAME], LAST_NAME as [LAST_NAME], USERNAME as [USERNAME],PASSWORD as [PASSWORD] from READER where USERNAME like '" & Me.Label17.Text & "%' order by USERNAME ", myconnection)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(mycommand)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "READER")
            DataGridView1.DataSource = myDataSet.Tables("READER").DefaultView
            myconnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub MYFINEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MYACCOUNTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub RESERVEBOOKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RESERVEBOOKToolStripMenuItem.Click
        RESERVED_BOOK.Show()

    End Sub

    Private Sub SEARCHBOOKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCHBOOKToolStripMenuItem.Click
        Me.Refresh()
    End Sub

    Private Sub LOGOUTToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem1.Click
        MessageBox.Show("THANKYOU VISIT AGAIN")
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub PUBLISHERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PUBLISHERToolStripMenuItem.Click
        ALL_PUBLISHERS.Show()

    End Sub

End Class