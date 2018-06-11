Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class ADMIN_HOME
    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer
    Dim adp As SqlDataAdapter

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
    Private Sub ADMIN_HOME_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
  
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Len(Trim(TextBox2.Text)) = 0 Then
            MessageBox.Show("Please enter ISBN", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox2.Focus()
            Exit Sub
        End If
        If Len(Trim(TextBox3.Text)) = 0 Then
            MessageBox.Show("Please enter TITLE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox3.Focus()
            Exit Sub
        End If
        If Len(Trim(TextBox4.Text)) = 0 Then
            MessageBox.Show("Please enter AUTHOR", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox4.Focus()
            Exit Sub
        End If

        If Len(Trim(TextBox5.Text)) = 0 Then
            MessageBox.Show("Please enter PUBLISHER", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox5.Focus()
            Exit Sub
        End If

        If Len(Trim(datepicker.Text)) = 0 Then
            MessageBox.Show("Please enter PUBLICATION DATE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            datepicker.Focus()
            Exit Sub
        End If

        If Len(Trim(ComboBox1.Text)) = 0 Then
            MessageBox.Show("Please enter LIBRARY BRANCH", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox1.Focus()
            Exit Sub
        End If


        myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")
        TextBox1.Text = "" & GetUniqueKey(7)
        myconnection = New SqlConnection(cs)
        myconnection.Open()
        
        Dim cb As String = ("insert into BOOKS([BOOK_ID],[ISBN],[TITLE],[AUTHOR],[PUBLISHER],[PUBLICATION_DATE],[LIBRARY_BRANCH],[AVAILABILITY],[COUNT]) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "'," & datepicker.Text & ",'" & ComboBox1.Text & "','AVAILABLE','0')")
        mycommand = New SqlCommand(cb)
        mycommand.Connection = myconnection
        mycommand.ExecuteNonQuery()
        myconnection.Close()


        myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")
        TextBox6.Text = "" & GetUniqueKey(7)
        myconnection = New SqlConnection(cs)
        myconnection.Open()
        Dim cb1 As String = ("insert into PUBLISHER([PUBLISHER_ID],[PUBLISHER_NAME]) values ('" & TextBox6.Text & "','" & TextBox5.Text & "')")
        mycommand = New SqlCommand(cb1)
        mycommand.Connection = myconnection
        mycommand.ExecuteNonQuery()
        myconnection.Close()

        MessageBox.Show("THANKYOU BOOK ADDED SUCCESSFULLY")

        myconnection.Close()
        Me.ResetText()




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        datepicker.Text = ""
        ComboBox1.Text = ""
        
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ALL_BOOKS.Show()
    End Sub

    

  
    Private Sub datepicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datepicker.ValueChanged
        datepicker.Text = datepicker.Value
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub ADDUSERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDUSERToolStripMenuItem.Click
        USER_ADD.Show()
    End Sub



    Private Sub VIEWALLPUBLISHERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWALLPUBLISHERToolStripMenuItem.Click
        ALL_PUBLISHERS.SHOW()

    End Sub

    Private Sub VIEWALLAUTHORSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ALL_AUTHORS.Show()

    End Sub

    Private Sub BOOKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOOKToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub SHOWALLUSERSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHOWALLUSERSToolStripMenuItem.Click
        ALL_USERS.Show()
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MODIFY_BOOK.Show()

    End Sub

    Private Sub ALLUSERSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ALL_USERS.Show()

    End Sub

    Private Sub LOGOUTToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem1.Click

    End Sub

  

    Private Sub BookcountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookcountToolStripMenuItem.Click
        COUNT.Show()
    End Sub



    Private Sub BOOKISSUERECORDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOOKISSUERECORDToolStripMenuItem.Click
        BOOK_ISSUE_RECORD.Show()
    End Sub

    Private Sub AUTHORToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PUBLISHERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PUBLISHERToolStripMenuItem.Click

    End Sub

    Private Sub ALLBOOKSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALLBOOKSToolStripMenuItem.Click
        ALL_BOOKS.Show()
    End Sub

    Private Sub ALLAUTHORSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALLAUTHORSToolStripMenuItem.Click
        ALL_AUTHORS.Show()

    End Sub

    Private Sub ALLPUBLISHERSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALLPUBLISHERSToolStripMenuItem.Click
        ALL_PUBLISHERS.Show()

    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        MessageBox.Show("THANKYOU VISIT AGAIN")
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub DELETEUSERToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETEUSERToolStripMenuItem1.Click
        DELETE_USER.Show()
    End Sub

    Private Sub AVGFINEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AVERAGE_FINE.Show()

    End Sub

    Private Sub MODIFYUSERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MODIFYUSERToolStripMenuItem.Click
        MODIFY_USER.Show()

    End Sub

    Private Sub BRANCHINFOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BRANCHINFOToolStripMenuItem.Click
        BRANCH_INFO.Show()

    End Sub



    Private Sub FINEDETAILSToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles FINEDETAILSToolStripMenuItem.Click
        FINE_DETAILS.Show()
    End Sub

    Private Sub TOPMEMBERSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TOPMEMBERSToolStripMenuItem.Click
        TOP_BORROW.Show()
    End Sub

    Private Sub TOPBOOKSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOPBOOKSToolStripMenuItem.Click
        TOP_BOOKS.Show()

    End Sub
End Class