' Question 39: Use RadioButtons to select different colors and change the background color of a Label
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton1.Checked Then
            Label1.BackColor = Color.Red
        ElseIf RadioButton2.Checked Then
            Label1.BackColor = Color.Green
        ElseIf RadioButton3.Checked Then
            Label1.BackColor = Color.Blue
        Else
            MessageBox.Show("Please Select a Color")
        End If

    End Sub

End Class
