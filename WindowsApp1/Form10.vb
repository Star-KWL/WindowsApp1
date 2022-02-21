Public Class FormTell
    Private Sub FormTell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TellNum = 1 Then
            Call SS("上午好，今天上午的课程是，" & Form8.TextBox1.Text & "、" & Form8.TextBox2.Text & "、" & Form8.TextBox3.Text & "、" & Form8.TextBox4.Text & "。")
        ElseIf TellNum = 2 Then
            Call SS("下午好，今天下午的课程是，" & Form8.TextBox5.Text & "、" & Form8.TextBox6.Text & "、" & Form8.TextBox7.Text & "、" & Form8.TextBox8.Text & "。")
        ElseIf TellNum = 3 Then
            Call spoke("早上好，今天是" & Year(Today) & "年" & Month(Today) & "月" & DateAndTime.Day(Today) & "日" & " 星期" & Weekday(Today, FirstDayOfWeek.Monday) & "。" & "距离高考还有" & DateDiff("d", Today, #6/07/2022#) & "天！" & "。今天白天的课程是，" & Form8.TextBox1.Text & "、" & Form8.TextBox2.Text & "、" & Form8.TextBox3.Text & "、" & Form8.TextBox4.Text & "、" & Form8.TextBox5.Text & "、" & Form8.TextBox6.Text & "、" & Form8.TextBox7.Text & "、" & Form8.TextBox8.Text & "，今天晚上的课程是，" & Form8.TextBox13.Text & "、" & Form8.TextBox14.Text & "。午测科目是" & Form8.TextBox9.Text & "，晚测科目是" & Form8.TextBox10.Text & "。" & Form8.Label7.Text & C)
            If PlayBir = True Then My.Computer.Audio.Play(My.Resources.Resource3.生日快乐, AudioPlayMode.Background)
        ElseIf TellNum = 4 Then
                Call spoke("即将开始" & Form8.TextBox9.Text & "午测，请" & Form8.TextBox11.Text & "登记迟到同学。")
            ElseIf TellNum = 5 Then
                Call spoke("即将开始晚读，请" & Form8.TextBox11.Text & "登记迟到同学。" & "今天晚上的课程是，" & Form8.TextBox13.Text & "、" & Form8.TextBox14.Text & "。晚测科目是" & Form8.TextBox10.Text)
        End If
        Me.Close()
    End Sub
End Class