Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class PUBLISHER_DETAILS
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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Len(Trim(TextBox2.Text)) = 0 Then
            MessageBox.Show("Please enter NAME", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox2.Focus()
            Exit Sub
        End If
        If Len(Trim(TextBox3.Text)) = 0 Then
            MessageBox.Show("Please enter ADDRESS", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox3.Focus()
            Exit Sub
        End If
        If Len(Trim(TextBox4.Text)) = 0 Then
            MessageBox.Show("Please enter ISBN", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox4.Focus()
            Exit Sub
        End If

        If Len(Trim(TextBox5.Text)) = 0 Then
            MessageBox.Show("Please enter CONTACT", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox5.Focus()
            Exit Sub
        End If

   


        myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")
        TextBox1.Text = "PUBLISHER-" & GetUniqueKey(7)
        myconnection = New SqlConnection(cs)
        myconnection.Open()

        Dim cb As String = ("insert into PUBLISHER([PUBLISHER_ID],[PUBLISHER_NAME],[ADDRESS],[ISBN],[CONTACT]) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')")
        mycommand = New SqlCommand(cb)
        mycommand.Connection = myconnection
        mycommand.ExecuteNonQuery()
        myconnection.Close()


        MessageBox.Show("Thankyou PUBLISHER added successfully")

        myconnection.Close()
        Me.Hide()
        Form1.Show()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ALL_PUBLISHERS.Show()

    End Sub
End Class