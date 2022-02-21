Public Class Form7
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = Format(Now(), "HH:mm:ss")

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form4.Show()
        Form9.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "07:56:00" Then
            TellNum = 1
            FormTell.Show()
        ElseIf TextBox1.Text = "13:58:40" Then
            TellNum = 2
            FormTell.Show()
        ElseIf TextBox1.Text = "07:17:40" Then
            Form8.Close()
            Form8.Show()
            TellNum = 3
            FormTell.Show()
        ElseIf TextBox1.Text = "12:29:00" Then
            TellNum = 4
            FormTell.Show()
        ElseIf TextBox1.Text = "18:09:30" Then
            TellNum = 5
            FormTell.Show()
        End If
    End Sub
End Class