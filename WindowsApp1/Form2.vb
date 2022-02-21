Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Text = c
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class