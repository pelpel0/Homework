Public Class Form1
    Private Sub Textbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msg As New Form2
        msg.nam = TextBox1.Text
        msg.age = TextBox2.Text
        msg.add = TextBox3.Text
        msg.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim msg As New Form3
        msg.nam = TextBox1.Text
        msg.age = TextBox2.Text
        msg.add = TextBox3.Text
        msg.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim msg As New Form4
        msg.nam = TextBox1.Text
        msg.age = TextBox2.Text
        msg.add = TextBox3.Text
        msg.Show()
    End Sub
End Class
