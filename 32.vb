' Question 34: Create a ComboBox containing different programming languages. Display the selected language in a Label
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("VB.NET")
        ComboBox1.Items.Add("C#")
        ComboBox1.Items.Add("Java")
        ComboBox1.Items.Add("Python")
        ComboBox1.Items.Add("PHP")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex <> -1 Then
            Label1.Text = "Selected Language: " & ComboBox1.SelectedItem
        Else
            Label1.Text = "Please Select a Language"
        End If
    End Sub

End Class
