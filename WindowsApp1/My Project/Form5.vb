Option Explicit Off

Public Class Form6

    Dim TextboxArray As New ArrayList '定义一个数组例表
    Dim i As Integer
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BiuldTextBoxArray()
    End Sub
    Private Sub BiuldTextBoxArray() '过程用来将Form上的三个TextBox加入到数组例表中
        TextboxArray.Add(TextBox1)
        TextboxArray.Add(TextBox2)
        TextboxArray.Add(TextBox3)
        TextboxArray.Add(TextBox4)
        TextboxArray.Add(TextBox5)
        TextboxArray.Add(TextBox6)
        TextboxArray.Add(TextBox7)
        TextboxArray.Add(TextBox8)
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Visible = False
        Timer1.Enabled = Ture
        i = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Randomize()
        D = Int((48 - 1 + 1) * Rnd() + 1)
        B = Int((3 - 1 + 1) * Rnd() + 1)
        c = Int((2 - 1 + 1) * Rnd() + 1)
        A = D + B - c
        TextboxArray(0).Text = ""
        TextboxArray(i).BackColor = Red
        If i = 8 Then Timer1.Enabled = False
        i += 1
    End Sub
End Class