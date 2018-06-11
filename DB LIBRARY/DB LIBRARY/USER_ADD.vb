
Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class USER_ADD
    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer
    Dim gender As String
    Dim cs As String = "Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True"

    Public Shared Function GetUniqueKey(ByVal maxSize As Integer) As String
        Dim chars As Char() = New Char(61) {}
        chars = "LAV123456789".ToCharArray()
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
    Private Sub REGSUBMIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGSUBMIT.Click
        If Len(Trim(TextBox2.Text)) = 0 Then
            MessageBox.Show("Please enter FIRST NAME", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox2.Focus()
            Exit Sub

            If Len(Trim(TextBox3.Text)) = 0 Then
                MessageBox.Show("Please enter LAST NAME", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox3.Focus()
                Exit Sub
            End If
        End If

        If Len(Trim(CMBREGADD.Text)) = 0 Then
            MessageBox.Show("Please enter ADDRESS", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CMBREGADD.Focus()
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
        If Len(Trim(TextBox6.Text)) = 0 Then
            MessageBox.Show("Please enter USERNAME", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox6.Focus()
            Exit Sub
        End If
        If Len(Trim(TextBox7.Text)) = 0 Then
            MessageBox.Show("Please enter PASSWORD", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox7.Focus()
            Exit Sub
        End If



        myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")
        TextBox1.Text = "LIBID-" & GetUniqueKey(7)
        myconnection.Open()
        Dim cb As String = ("insert into READER([READER_ID],[FIRST_NAME],[LAST_NAME],[ADDRESS],[PHONE_NO],[EMAIL_ID],[USERNAME],[PASSWORD]) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & CMBREGADD.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')")
        mycommand = New SqlCommand(cb)
        mycommand.Connection = myconnection
        mycommand.ExecuteNonQuery()
        myconnection.Close()


        MessageBox.Show("Thankyou User added successfully" & ra)


        myconnection.Close()
        Me.Hide()
        USER_LOGIN.Show()

    End Sub


    Private Sub REGRESET_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGRESET.Click
        TextBox2.Text = ""
        TextBox3.Text = ""
        CMBREGADD.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

   
End Class