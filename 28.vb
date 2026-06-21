' Question 30: Accept student details and display entered details
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim msg As String

        msg = "Name : " & TextBox1.Text & vbCrLf &
              "Roll No : " & TextBox2.Text & vbCrLf &
              "Course : " & TextBox3.Text

        MessageBox.Show(msg, "Student Details")

    End Sub

End Class
