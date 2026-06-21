' Question 42: Accept marks for five subjects and calculate Total, Percentage, and Grade
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim m1, m2, m3, m4, m5 As Integer
        Dim total As Integer
        Dim per As Double
        Dim grade As String

        m1 = CInt(TextBox1.Text)
        m2 = CInt(TextBox2.Text)
        m3 = CInt(TextBox3.Text)
        m4 = CInt(TextBox4.Text)
        m5 = CInt(TextBox5.Text)

        total = m1 + m2 + m3 + m4 + m5
        per = total / 5

        If per >= 80 Then
            grade = "A"
        ElseIf per >= 60 Then
            grade = "B"
        ElseIf per >= 40 Then
            grade = "C"
        Else
            grade = "Fail"
        End If

        Label1.Text = "Total = " & total
        Label2.Text = "Percentage = " & per & "%"
        Label3.Text = "Grade = " & grade

    End Sub

End Class
