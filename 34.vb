' Question 36: Design a form with RadioButtons for selecting gender
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton1.Checked Then
            Label1.Text = "Selected Gender: Male"
        ElseIf RadioButton2.Checked Then
            Label1.Text = "Selected Gender: Female"
        Else
            Label1.Text = "Please Select a Gender"
        End If

    End Sub

End Class
