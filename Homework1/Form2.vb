Public Class Form2

    Public Property nam As String
    Public Property age As String
    Public Property add As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = nam
        Label2.Text = age
        Label3.Text = add
    End Sub
End Class