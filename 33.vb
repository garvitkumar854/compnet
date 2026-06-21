' Question 35: Create a form with CheckBoxes representing hobbies
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim hobbies As String = ""

        If CheckBox1.Checked Then hobbies &= "Reading "
        If CheckBox2.Checked Then hobbies &= "Music "
        If CheckBox3.Checked Then hobbies &= "Sports "
        If CheckBox4.Checked Then hobbies &= "Traveling "

        Label1.Text = "Selected Hobbies: " & hobbies

    End Sub

End Class
