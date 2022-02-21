Option Explicit On
Imports System
Imports System.Runtime.InteropServices
Public Class Form9
    Dim i As Integer
    Dim hd As Integer
    Dim Ws As Object = CreateObject("Wscript.Shell")
    Public Sub hideme(hd As Integer)
        If hd = 1 Then
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label10.Visible = True
            Label11.Visible = True
            Panel1.Visible = True
            i = 2
        ElseIf hd = 2 Then
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label10.Visible = False
            Label11.Visible = False
            Panel1.Visible = False
            i = 1
        End If
    End Sub

    Public Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Call hideme(i)
        Randomize()
        A = Int((9 - 1 + 1) * Rnd() + 1)
        B = Int((6 - 1 + 1) * Rnd() + 1)
        C = "请第" & A & "组第" & B & "号回答!"
        Call SS(C)
    End Sub

    Public Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Form5.Show()
        Call hideme(i)
    End Sub
    Public Sub Picture1_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim Url As String
        Call hideme(i)
        Ws.SendKeys("^+1")
        Ws.Run("""C:\Program Files\Common Files\microsoft shared\ink\TabTip.exe""")
        Url = InputBox("请输入想要搜索的关键词。")
        Ws.Run("https://www.bing.com/search?q=" & Url)
    End Sub

    Public Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Call hideme(i)
        Call spp()
        Call SS(C)
    End Sub

    Public Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Call hideme(i)
        Dim A As Integer
        Randomize()
        A = Int((9 - 1 + 1) * Rnd() + 1)
        Call sppp(A)
        Call SS(C)
    End Sub

    Public Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Call hideme(i)
        Ws.SendKeys("^+1")
        Ws.Run("""C:\Program Files\Common Files\microsoft shared\ink\TabTip.exe""")
    End Sub


    Public Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i = 1
        TrackBar1.Value = 50

        Form8.Show()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        For v = 1 To 50
            Ws.Sendkeys("棶")
        Next
        For v = 1 To TrackBar1.Value
            Ws.Sendkeys("棷")
        Next

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Call hideme(i)
    End Sub
End Class
