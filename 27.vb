' Question 29: Create a Login Form using TextBox controls for Username and Password
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "admin" And TextBox2.Text = "1234" Then
            MessageBox.Show("Login Successful")
        Else
            MessageBox.Show("Login Failed")
        End If

    End Sub

End Class
