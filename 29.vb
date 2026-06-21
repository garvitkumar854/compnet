' Question 31: Develop a Calculator using TextBoxes and Buttons
Public Class Form1

    Private Function GetNumbers(ByRef a As Double, ByRef b As Double) As Boolean
        If Double.TryParse(TextBox1.Text, a) AndAlso Double.TryParse(TextBox2.Text, b) Then
            Return True
        End If

        MessageBox.Show("Enter valid numbers")
        Return False
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double, b As Double
        If GetNumbers(a, b) Then
            Label1.Text = "Result = " & (a + b)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As Double, b As Double
        If GetNumbers(a, b) Then
            Label1.Text = "Result = " & (a - b)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As Double, b As Double
        If GetNumbers(a, b) Then
            Label1.Text = "Result = " & (a * b)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As Double, b As Double
        If GetNumbers(a, b) Then
            If b <> 0 Then
                Label1.Text = "Result = " & (a / b)
            Else
                MessageBox.Show("Division by zero is not allowed")
            End If
        End If
    End Sub

End Class
