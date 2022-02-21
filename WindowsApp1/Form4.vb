Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()

        Form1.Show()
    End Sub

    Private Sub Form4_Click(sender As Object, e As EventArgs) Handles Me.Click
        Form1.Hide()
        Form1.Show()
    End Sub
End Class