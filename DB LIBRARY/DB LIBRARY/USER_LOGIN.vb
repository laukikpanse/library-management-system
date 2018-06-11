Imports System.Data
Imports System.Data.SqlClient

Public Class USER_LOGIN
    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer
    Private Sub usrloginsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usrloginsubmit.Click
        myconnection = New SqlConnection("Data Source=ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")

        mycommand = New SqlCommand(" Select * from READER where USERNAME= @USERNAME AND PASSWORD = @PASSWORD", myconnection)


        mycommand.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = usrlogintxt.Text
        mycommand.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = usrpasstxt.Text

        Dim adapter As New SqlDataAdapter(mycommand)
        Dim table As New DataTable()
        adapter.Fill(table)
        If Len(Trim(usrlogintxt.Text)) = 0 Then
            MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            usrlogintxt.Focus()
            Exit Sub
        End If
        If Len(Trim(usrpasstxt.Text)) = 0 Then
            MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            usrpasstxt.Focus()
            Exit Sub
        End If

        If table.Rows.Count() <= 0 Then
            MessageBox.Show("Username or Password are invalid")
        Else
            MessageBox.Show("Login Successfull")

            Me.Hide()
            USER_HOME.Show()
        End If


        



    End Sub


    Private Sub usrloginreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usrloginreset.Click
        usrlogintxt.Text = ""
        usrpasstxt.Text = ""
    End Sub

    Private Sub USER_LOGIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub usrlogintxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usrlogintxt.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()

    End Sub
End Class