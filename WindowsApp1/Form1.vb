Option Explicit Off

Imports SpeechLib
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Form7.Show()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ws.Run("%windir%\explorer G:\")
        Call spoke(GetINI("Welcome", "Chinese", ""))
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Ws.Run("%windir%\explorer G:\")
        Call spoke(GetINI("Welcome", "Math", ""))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Ws.Run("%windir%\explorer G:\")
        Call spoke(GetINI("Welcome", "English", ""))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Ws.Run("%windir%\explorer G:\")
        Call spoke(GetINI("Welcome", "Politics", ""))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Ws.Run("%windir%\explorer G:\")
        Call spoke(GetINI("Welcome", "History", ""))
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Ws.Run("%windir%\explorer G:\")
        Call spoke(GetINI("Welcome", "Geography", ""))
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Ws.Run("%windir%\explorer G:\")
        Call spoke(GetINI("Welcome", "Common", ""))
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Ws.Run("USBDeview.exe /stop_by_drive /showmsg G:")
        Call SS("老师再见！")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form8.Close()
        Form8.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Ws.Run("""C:\Windows\System32\PhotoScreensaver.scr""")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Ws.Run("""C:\Program Files\Microsoft\Edge\Application\msedge.exe""")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Ws.Run("""C:\Program Files (x86)\Seewo\EasiCamera\sweclauncher\sweclauncher.exe""")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Ws.Run("""C:\Program Files (x86)\Seewo\EasiNote5\swenlauncher\swenlauncher.exe""")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Ws.Run("""C:\Program Files (x86)\QQMusic\QQMusic.exe""")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Ws.Run("https://www.ewt360.com/")
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Ws.Run("""C:\Program Files (x86)\Tencent\WeChat\WeChat.exe""")
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Ws.Run("%windir%\system32\calc.exe")
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Ws.Run("""C:\Program Files\QQ\Bin\QQScLauncher.exe""")

    End Sub

    Public Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Randomize()
        A = Int((9 - 1 + 1) * Rnd() + 1)
        B = Int((6 - 1 + 1) * Rnd() + 1)
        C = "请第" & A & "组第" & B & "号回答!"
        Call SS(C)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Call spp()
        Call SS(C)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim A As Integer
        Randomize()
        A = Int((9 - 1 + 1) * Rnd() + 1)
        Call sppp(A)
        Call SS(C)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Form5.Show()
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        v = MsgBox("搜索点是，朗读点否，退出点取消"， MsgBoxStyle.YesNoCancel, "")
        If v = vbYes Then
            If TextBox1.Text = "" Then
                Ws.Run("taskkill /f /im 点名.exe")
            Else
                Ws.Run("https://www.bing.com/search?q=" & TextBox1.Text)
            End If
            TextBox1.Text = ""
            TextBox1.Focus()
        ElseIf v = vbNo Then
            Call spoke(TextBox1.Text)
        End If
    End Sub
    Public Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        R = Int((9 - 1 + 1) * Rnd() + 1)
        Select Case R
            Case Is = 1
                My.Computer.Audio.Play(My.Resources.Resource1.听我说谢谢你, AudioPlayMode.Background)
            Case Is = 2
                My.Computer.Audio.Play(My.Resources.Resource1.恋爱循环, AudioPlayMode.Background)
            Case Is = 3
                My.Computer.Audio.Play(My.Resources.Resource1.trouble, AudioPlayMode.Background)
            Case Is = 4
                My.Computer.Audio.Play(My.Resources.Resource1.江南, AudioPlayMode.Background)
            Case Is = 5
                My.Computer.Audio.Play(My.Resources.Resource1.上一个圣诞节, AudioPlayMode.Background)
            Case Is = 6
                My.Computer.Audio.Play(My.Resources.Resource1.下山, AudioPlayMode.Background)
            Case Is = 7
                My.Computer.Audio.Play(My.Resources.Resource1.晴天, AudioPlayMode.Background)
            Case Is = 8
                My.Computer.Audio.Play(My.Resources.Resource1.桥边姑娘, AudioPlayMode.Background)
            Case Is = 9
                My.Computer.Audio.Play(My.Resources.Resource1.落, AudioPlayMode.Background)
        End Select
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Randomize()
        D = Int((GetINI("Words", "Number", 89) - 1 + 1) * Rnd() + 1)
        TextBox2.Text = GetINI("Words", "Word" & D, "")
    End Sub


    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Call spoke(TextBox2.Text)
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Ws.Run("notepad.exe D:\教学辅助系统.ini")
    End Sub

    Private Sub Label10_DoubleClick(sender As Object, e As EventArgs) Handles Label10.DoubleClick
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 1800000
        Button16_Click(Nothing, Nothing)
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Randomize()
        D = Int((GetINI("Words", "Number", 89) - 1 + 1) * Rnd() + 1)
        TextBox2.Text = GetINI("Words", "Word" & D, "")
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Form3.Show()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TellNum = 3
        FormTell.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Ws.Run("""C:\Program Files (x86)\Tencent\WeChat\WeChat.exe""")
    End Sub
End Class