REM  D. French
REM  October 18, 2014
REM  Project Euler Problem #1

Public Class Form1
    Private Sub btnMultiples_Click(sender As Object, e As EventArgs) Handles btnMultiples.Click
        Dim num As Integer
        Dim total As Integer
        num = 1
        Do While num < 1000
            If (num Mod 3 = 0) Or (num Mod 5 = 0) Then
                total += num
            End If
            num += 1
        Loop
        MsgBox(total)
    End Sub
End Class
