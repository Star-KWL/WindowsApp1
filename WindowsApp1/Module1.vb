Option Explicit On
Imports System
Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices
Imports SpeechLib


Module Module1
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32
    Public Property iniFilePath As String
    Public A As Integer
    Public B As String
    Public C As String
    Public Ed As String
    Public D As Integer
    Public BDate As String
    Public BName As String
    Public TellNum As Integer
    Public Welcome As String
    Public PlayBir As Boolean
    Public Ws As Object = CreateObject("Wscript.Shell")

    Public Sub spoke(Name As String)
        Dim MyVoice As New SpeechLib.SpVoice
        MyVoice.Volume = 100
        MyVoice.Speak(Name, SpeechVoiceSpeakFlags.SVSFlagsAsync)
    End Sub

    Public Function spp()
        Randomize()
        If GetINI("Names", "NextName", "") = "" Then
         A = Int((GetINI("Names", "Number", "48") - 1 + 1) * Rnd() + 1)
         B = GetINI("Names", "Name" & A, "")
        Else
         B = GetINI("Names", "NextName", "")
         SetINI("Names", "NextName", "")
        End If
        C = "请" & B & "同学回答！"
        Return B
        SetINI("Names", "LastName", B)
    End Function

    Public Sub sppp(A As Integer)
        Select Case A
            Case Is = 1
                B = "Black Hole"
            Case Is = 2
                B = "只争朝夕"
            Case Is = 3
                B = "不负韶华"
            Case Is = 4
                B = "勇往直前"
            Case Is = 5
                B = "未来可期"
            Case Is = 6
                B = "MVP"
            Case Is = 7
                B = "忘了初心"
            Case Is = 8
                B = "砥砺前行"
            Case Is = 9
                B = "两极格局"
        End Select
        C = "请" & B & "组成员回答！"
    End Sub

    Public Function xingzuo()
        Select Case Int((12 - 1 + 1) * Rnd() + 1)
            Case Is = 1
                B = "白羊座"
            Case Is = 2
                B = "金牛座"
            Case Is = 3
                B = "双子座"
            Case Is = 4
                B = "巨蟹座"
            Case Is = 5
                B = "狮子座"
            Case Is = 6
                B = "处女座"
            Case Is = 7
                B = "天秤座"
            Case Is = 8
                B = "天蝎座"
            Case Is = 9
                B = "射手座"
            Case Is = 10
                B = "摩羯座"
            Case Is = 11
                B = "水瓶座"
            Case Is = 12
                B = "双鱼座"
        End Select
        Return B
    End Function

    Public Function GetBirthday()
        BDate = Format(Now(), "MM/dd")
        Dim i As Integer
        For i = 1 To 48
            If GetINI("Births", "Birthday" & i, "") = BDate Then

                BName = GetINI("Names", "Name" & i, "")
                Exit For
            End If
        Next
        C = "祝" & BName & "生日快乐！"
        Return C
    End Function

    Public Function GetINI(ByVal Section As String, ByVal AppName As String, Optional ByVal lpDefault As String = "") As String
        Dim Str As String = ""
        Str = LSet(Str, 256)
        GetPrivateProfileString(Section, AppName, lpDefault, Str, Len(Str), iniFilePath + "D:\教学辅助系统.ini")
        Return Microsoft.VisualBasic.Left(Str, InStr(Str, Chr(0)) - 1)
    End Function

    Public Function SetINI(ByVal Section As String, ByVal AppName As String, ByVal lpString As String) As Boolean
        Try
            WritePrivateProfileString(Section, AppName, lpString, iniFilePath + "D:\教学辅助系统.ini")
        Catch exception1 As Exception
            Return False
        End Try
        Return True
    End Function
    Public Sub Play_Music(ByVal Mname As String)

        Dim res As IO.Stream = Reflection.Assembly.GetEntryAssembly.GetManifestResourceStream("WindowsApp1." & Mname)

        Dim bytes(res.Length - 1) As Byte

        res.Read(bytes, 0, bytes.Length)

        My.Computer.Audio.Play(bytes, AudioPlayMode.Background)
    End Sub

    Public Sub ShowMsg(CC As String)
        C = CC
        Form2.Close()
        Form2.Show()
    End Sub

    Public Sub SS(c As String)
        Call ShowMsg(c)
        Call spoke(c)
    End Sub
End Module
