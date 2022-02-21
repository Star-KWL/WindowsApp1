Option Explicit Off
Public Class Form8
    Dim Ws As Object = CreateObject("Wscript.Shell")

    Public Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Wek = Weekday(Today, FirstDayOfWeek.Monday)
        Wekk = "Day" & Wek
        Label1.Text = Today & "   星期" & Wek
        DJS = DateDiff("d", Today, #6/07/2022#)
        Randomize()
        Label4.Text = "高考倒计时:" & DJS & "天"
        Label5.Text = "幸运星座" & vbCrLf & xingzuo()
        Label6.Text = "幸运数字" & vbCrLf & Int((10 - 1 + 1) * Rnd() + 1)
        Label7.Text = "幸运儿" & vbCrLf & spp()
        TextBox1.Text = GetINI(Wekk, "Class1", "未知")
        TextBox2.Text = GetINI(Wekk, "Class2", "未知")
        TextBox3.Text = GetINI(Wekk, "Class3", "未知")
        TextBox4.Text = GetINI(Wekk, "Class4", "未知")
        TextBox5.Text = GetINI(Wekk, "Class5", "未知")
        TextBox6.Text = GetINI(Wekk, "Class6", "未知")
        TextBox7.Text = GetINI(Wekk, "Class7", "未知")
        TextBox8.Text = GetINI(Wekk, "Class8", "未知")
        TextBox13.Text = GetINI(Wekk, "Class9", "未知")
        TextBox14.Text = GetINI(Wekk, "Class10", "未知")
        TextBox9.Text = GetINI(Wekk, "NoonExam", "未知")
        TextBox10.Text = GetINI(Wekk, "NightExam", "未知")
        TextBox11.Text = GetINI(Wekk, "Master", "未知")
            SetINI("Settings", "Days", Wek)
        If Wek = 1 Then SetINI("Settings", "DoubleWeek", GetINI("Settings", "DoubleWeek", 0) + 1)
        If GetINI（"Settings", "DoubleWeek", "2") Mod 2 <> 0 Then
            If Wek = 6 Or Wek = 7 Then Call ChangeClass()
        End If
        BDate = Format(Now(), "MM/dd")
        Dim i As Integer
        BNmae = ""
        For i = 1 To 54
            If GetINI("Births", "Birthday" & i, "") = BDate Then
                BName = GetINI("Names", "Name" & i, "")
                Exit For
            End If
        Next
        If BName <> "" Then
            TextBox12.Text = BName
            C = "祝" & BName & "生日快乐！"
            PlayBir = True
            Form1.TextBox2.Text = C
            Form1.Timer1.Interval = 10800000
        Else
            Randomize()
            Form1.TextBox2.Text = GetINI("Words", "Word" & Int((GetINI("Words", "Number", 89) - 1 + 1) * Rnd() + 1), "")
            C = ""
            PlayBir = False
        End If
        Welcome = "您好，今天是" & Year(Today) & "年" & Month(Today) & "月" & DateAndTime.Day(Today) & "日" & " 星期" & Weekday(Today, FirstDayOfWeek.Monday) & "。" & C
    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Wek = Weekday(Today, FirstDayOfWeek.Monday)
        Wekk = "Day" & InputBox("在此输入修改值（阿拉伯数字）。")
        DJS = DateDiff("d", Today, #6/07/2022#)
        Label4.Text = "距离高考还有" & DJS & "天！"

        TextBox1.Text = GetINI(Wekk, "Class1", "未知")
        TextBox2.Text = GetINI(Wekk, "Class2", "未知")
        TextBox3.Text = GetINI(Wekk, "Class3", "未知")
        TextBox4.Text = GetINI(Wekk, "Class4", "未知")
        TextBox5.Text = GetINI(Wekk, "Class5", "未知")
        TextBox6.Text = GetINI(Wekk, "Class6", "未知")
        TextBox7.Text = GetINI(Wekk, "Class7", "未知")
        TextBox8.Text = GetINI(Wekk, "Class8", "未知")
        TextBox13.Text = GetINI(Wekk, "Class9", "未知")
        TextBox14.Text = GetINI(Wekk, "Class10", "未知")
        TextBox9.Text = GetINI(Wekk, "NoonExam", "未知")
        TextBox10.Text = GetINI(Wekk, "NightExam", "未知")
        TextBox11.Text = GetINI(Wekk, "Master", "未知")
    End Sub

    Private Sub ChangeClass()
        Wek = Weekday(Today, FirstDayOfWeek.Monday)
        Wekk = "Day" & Wek & "x"
        TextBox1.Text = GetINI(Wekk, "Class1", "未知")
        TextBox2.Text = GetINI(Wekk, "Class2", "未知")
        TextBox3.Text = GetINI(Wekk, "Class3", "未知")
        TextBox4.Text = GetINI(Wekk, "Class4", "未知")
        TextBox5.Text = GetINI(Wekk, "Class5", "未知")
        TextBox6.Text = GetINI(Wekk, "Class6", "未知")
        TextBox7.Text = GetINI(Wekk, "Class7", "未知")
        TextBox8.Text = GetINI(Wekk, "Class8", "未知")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Call spoke("即将开始" & TextBox9.Text & "午测！")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Ws.SendKeys("^+1")
        Ws.Run("""C:\Program Files\Common Files\microsoft shared\ink\TabTip.exe""")
        TextBox10.Focus()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        TellNum = 3
        FormTell.Show()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.Visible = True
        MsgBox("再次点击空白处即可隐藏。")
    End Sub

    Private Sub Form8_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown

    End Sub

    Private Sub Form8_Click(sender As Object, e As EventArgs) Handles Me.Click
        WebBrowser1.Visible = False
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Call spoke("请" & TextBox11.Text & "同学管好纪律！")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Call spoke("即将开始" & TextBox10.Text & "晚测！")

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Call spoke("祝" & TextBox12.Text & "生日快乐！")
        'My.Computer.Audio.Play(My.Resources.Resource3.生日快乐, AudioPlayMode.Background)
        If PlayBir = True Then My.Computer.Audio.Play(My.Resources.Resource3.生日快乐, AudioPlayMode.Background)
    End Sub
End Class