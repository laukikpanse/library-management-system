Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Form1

    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer

    Dim cs As String = "Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True"



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label2.Text = TimeOfDay.ToString("H:mm:ss")

        Dim myCompareTime As DateTime = DateTime.Parse("18:00:00")
        Dim myCompareTime1 As DateTime = DateTime.Parse("10:00:00")
        If myCompareTime.TimeOfDay.ToString < Me.Label2.Text Then

            myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")
            myconnection.Open()
            myconnection = New SqlConnection(cs)
            myconnection.Open()
            Dim cb3 As String = ("UPDATE BOOKS SET [AVAILABILITY]='AVAILABLE' WHERE [AVAILABILITY]='RESERVED'")
            mycommand = New SqlCommand(cb3)
            mycommand.Connection = myconnection
            mycommand.ExecuteNonQuery()
            myconnection.Close()
            myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")
            myconnection.Open()
            myconnection = New SqlConnection(cs)
            myconnection.Open()
            Dim cb1 As String = ("DELETE FROM RESV_BOOK")
            mycommand = New SqlCommand(cb1)
            mycommand.Connection = myconnection
            mycommand.ExecuteNonQuery()
            myconnection.Close()

        ElseIf myCompareTime1.TimeOfDay.ToString > Me.Label2.Text Then

            myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")
            myconnection.Open()
            myconnection = New SqlConnection(cs)
            myconnection.Open()
            Dim cb3 As String = ("UPDATE BOOKS SET [AVAILABILITY]='AVAILABLE' WHERE[AVAILABILITY]='RESERVED'")
            mycommand = New SqlCommand(cb3)
            mycommand.Connection = myconnection
            mycommand.ExecuteNonQuery()
            myconnection.Close()

            myconnection = New SqlConnection("Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")
            myconnection.Open()
            myconnection = New SqlConnection(cs)
            myconnection.Open()
            Dim cb2 As String = ("DELETE FROM RESV_BOOK")
            mycommand = New SqlCommand(cb2)
            mycommand.Connection = myconnection
            mycommand.ExecuteNonQuery()
            myconnection.Close()



        End If

        If ComboBox1.Text = "REGISTERED USER LOGIN" Then
            Me.Hide()
            USER_LOGIN.Show()
        ElseIf ComboBox1.Text = "USER REGISTRATION" Then
            Me.Hide()
            USER_REGISTRATION.Show()
        ElseIf ComboBox1.Text = "ADMIN LOGIN" Then
            Me.Hide()
            ADMIN_LOGIN.Show()
        Else
            MessageBox.Show("SELECT OPTION TO PROCEED...")

        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

   
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
   
        Label2.Text = TimeOfDay.ToString("H:mm:ss")
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        USER_HOME.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ADMIN_HOME.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
End Class
