Imports System.Data
Imports System.Data.SqlClient

Public Class SELECT_USER

    Dim myconnection As SqlConnection
    Dim mycommand As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ra As Integer
    Dim cs As String = "Data Source= ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True"
    Private Function RESET()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Function

    Private Sub SELECT_USER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'USDATADataSet.READER' table. You can move, or remove it, as needed.
        Me.READERTableAdapter.Fill(Me.USDATADataSet.READER)
        TextBox3.Text = USER_HOME.Label17.Text

    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
      
        USER_HOME.Show()
  
            Try
                Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
                Me.Hide()
                Me.Show()
            Me.TextBox2.Text = dr.Cells(0).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        myconnection = New SqlConnection("Data Source=ethanhunt-pc\;Initial Catalog=USDATA;Integrated Security=True")
        mycommand = New SqlCommand(" Select * from READER where READER_ID= @READER_ID AND PASSWORD = @PASSWORD", myconnection)

        mycommand.Parameters.Add("@READER_ID", SqlDbType.VarChar).Value = TextBox2.Text
        mycommand.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = TextBox1.Text

        Dim adapter As New SqlDataAdapter(mycommand)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then
            MessageBox.Show("Username or Password are invalid")
        Else
            MessageBox.Show("AUTHORIZATION SUCCESSFUL")



            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            Me.Show()
            USER_HOME.TextBox4.Text = dr.Cells(0).Value.ToString()
            USER_HOME.TextBox5.Text = dr.Cells(1).Value.ToString()
            USER_HOME.TextBox6.Text = dr.Cells(2).Value.ToString()
            USER_HOME.TextBox10.Text = dr.Cells(3).Value.ToString()
            Me.Close()
            USER_HOME.Show()
        End If
    End Sub


  
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Try
            myconnection = New SqlConnection(cs)
            myconnection.Open()
            mycommand = New SqlCommand("SELECT READER_ID as [READER_ID], FIRST_NAME as [FIRST_NAME], LAST_NAME as [LAST_NAME], USERNAME as [USERNAME] from READER where USERNAME like '" & TextBox3.Text & "%' order by USERNAME ", myconnection)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(mycommand)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "READER")
            DataGridView1.DataSource = myDataSet.Tables("READER").DefaultView
            myconnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class