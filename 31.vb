' Question 33: Populate the ComboBox with colors and display the selected color in the ListBox
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Red")
        ComboBox1.Items.Add("Green")
        ComboBox1.Items.Add("Blue")
        ComboBox1.Items.Add("Yellow")
        ComboBox1.Items.Add("Black")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex <> -1 Then
            ListBox1.Items.Add(ComboBox1.SelectedItem)
        Else
            MessageBox.Show("Please select a color")
        End If
    End Sub

End Class
