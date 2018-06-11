Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class USER_REGISTRATION

    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
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

    Private Sub REGRESET_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGRESET.Click
        TextBox2.Text = ""
        TextBox3.Text = ""
        CMBREGADD.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        USERNAME.Text = ""
        TextBox7.Text = ""

    End Sub

    Private Sub REGSUBMIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGSUBMIT.Click
        If Len(Trim(TextBox2.Text)) = 0 Then


            MessageBox.Show("Please enter FIRST NAME", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox2.Focus()
            Exit Sub
        End If
        If Len(Trim(TextBox3.Text)) = 0 Then
            MessageBox.Show("Please enter LAST NAME", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox3.Focus()
            Exit Sub
        End If


        If Len(Trim(CMBREGADD.Text)) = 0 Then
            MessageBox.Show("Please enter ADDRESS", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CMBREGADD.Focus()
            Exit Sub
        End If
        If Len(Trim(USERNAME.Text)) = 0 Then
            MessageBox.Show("Please enter USER_NAME", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            USERNAME.Focus()
            Exit Sub
        End If


        If Len(Trim(TextBox4.Text)) = 0 Then
            MessageBox.Show("Please enter user PHONE NO.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox4.Focus()
            Exit Sub
        End If

        If Len(Trim(TextBox5.Text)) = 0 Then
            MessageBox.Show("Please enter EMAIL ADDRESS", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox5.Focus()
            Exit Sub
        End If

        If Len(Trim(TextBox7.Text)) = 0 Then
            MessageBox.Show("Please enter PASSWORD", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox7.Focus()
            Exit Sub
        End If
        myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")
        myconnection.Open()
        Dim mycommand As New SqlCommand(("SELECT * FROM READER WHERE USERNAME= '" & USERNAME.Text & "'"), myconnection)
        Dim dap As New SqlDataAdapter
        Dim ds As New Data.DataSet
        dap.SelectCommand = mycommand
        mycommand.ExecuteNonQuery()
        ds.Clear()
        dap.Fill(ds, "READER")


        If ds.Tables(0).Rows.Count > 0 Then
            MessageBox.Show("USERNAME NOT AVAILABLE")

        ElseIf Len(Trim(TextBox4.Text)) = 10 Then

            myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")
            TextBox1.Text = "" & GetUniqueKey(7)
            myconnection.Open()
            Dim cb As String = ("insert into READER([READER_ID],[FIRST_NAME],[LAST_NAME],[ADDRESS],[PHONE_NO],[EMAIL_ID],[USERNAME],[PASSWORD]) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & CMBREGADD.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & USERNAME.Text & "','" & TextBox7.Text & "')")
            mycommand = New SqlCommand(cb)
            mycommand.Connection = myconnection
            mycommand.ExecuteNonQuery()
            myconnection.Close()

            myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")
            myconnection.Open()
            Dim cb3 As String = ("insert into TOP_BORROWERS ([READER_ID],[BOOKS_BORROWED]) values ('" & TextBox1.Text & "','0')")
            mycommand = New SqlCommand(cb3)
            mycommand.Connection = myconnection
            mycommand.ExecuteNonQuery()
            myconnection.Close()
            MessageBox.Show("THANKYOU USER ADDED SUCCESSFULLY" & ra)
            myconnection.Close()
            Me.Hide()
            USER_LOGIN.Show()
        Else
            MessageBox.Show("PLEASE ENTER A VALID CONTACT")





        End If
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class