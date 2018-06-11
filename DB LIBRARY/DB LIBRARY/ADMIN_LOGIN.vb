Public Class ADMIN_LOGIN

    Private Sub adminlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adminlogin.Click
        If adminunametxt.Text = "SUPERUSER" And
            adminpasstxt.Text = "SUPERUSER" Then
            Me.Hide()
            ADMIN_HOME.Show()

        End If
    End Sub

    Private Sub adminreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adminreset.Click
        adminunametxt.Text = ""
        adminpasstxt.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class