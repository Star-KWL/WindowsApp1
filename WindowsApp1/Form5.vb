Option Explicit Off

Public Class Form5
    Dim i As Integer
    Public Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Visible = False
        Timer1.Enabled = True
        Label9.Text = "8"
        My.Computer.Audio.Play(My.Resources.Resource1.好运来, AudioPlayMode.Background)
        i = 1
    End Sub
    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If i = 1 Then
            Label1.BackColor = Color.Red
            Label1.Text = spp()
            Label9.Text = "7"
            i = i + 1
        ElseIf i = 2 Then
            Label2.BackColor = Color.Red
            Label2.Text = spp()
            Label9.Text = "6"
            i = i + 1
        ElseIf i = 3 Then
            Label3.BackColor = Color.Red
            Label3.Text = spp()
            Label9.Text = "5"
            i = i + 1
        ElseIf i = 4 Then
            Label4.BackColor = Color.Red
            Label4.Text = spp()
            Label9.Text = "4"
            i = i + 1
        ElseIf i = 5 Then
            Label5.BackColor = Color.Red
            Label5.Text = spp()
            Label9.Text = "3"
            i = i + 1
        ElseIf i = 6 Then
            Label6.BackColor = Color.Red
            Label6.Text = spp()
            Label9.Text = "2"
            i = i + 1
        ElseIf i = 7 Then
            Label7.BackColor = Color.Red
            Label7.Text = spp()
            Label9.Text = "1"
            i = i + 1
        ElseIf i = 8 Then
            Label8.BackColor = Color.Red
            Label8.Text = spp()
            Label9.Text = "0"
            i = i + 1
        ElseIf i = 9 Then
            Timer1.Enabled = False
            Randomize()
            A = Int((8 - 1 + 1) * Rnd() + 1)
            If A = 1 Then Label9.Text = Label1.Text
            If A = 2 Then Label9.Text = Label2.Text
            If A = 3 Then Label9.Text = Label3.Text
            If A = 4 Then Label9.Text = Label4.Text
            If A = 5 Then Label9.Text = Label5.Text
            If A = 6 Then Label9.Text = Label6.Text
            If A = 7 Then Label9.Text = Label7.Text
            If A = 8 Then Label9.Text = Label8.Text
            c = "恭喜" & Label9.Text & "同学成为天选之人！"
            PictureBox2.Enabled = True
            Button1.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox2.Visible = False
        My.Computer.Audio.Play(My.Resources.Resource1.出场音乐, AudioPlayMode.Background)
        Call SS(c)
    End Sub
End Class