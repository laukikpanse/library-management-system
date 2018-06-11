Public Class BRANCH_INFO
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "NEW YORK" Then
            TextBox1.Text = "LIB-153351"
            TextBox2.Text = "NY LIBRARY"
            TextBox3.Text = "156 MADISON AVE 06929"
            TextBox4.Text = "(663)-258-9898"

        ElseIf ComboBox1.Text = "NEW JERSEY" Then
            TextBox1.Text = "LIB-989651"
            TextBox2.Text = "NJ LIBRARY"
            TextBox3.Text = "152 BOWERS STREET 07307"
            TextBox4.Text = "(929)-372-2727"

        ElseIf ComboBox1.Text = "CONNECTICUT" Then
            TextBox1.Text = "LIB-056325"
            TextBox2.Text = "CN LIBRARY"
            TextBox3.Text = "16 BLEECKERS STREET 98486"
            TextBox4.Text = "(210)-610-0756"
        End If
    End Sub
End Class