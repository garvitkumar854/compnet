' Question 32: Create an application that allows users to Add, Remove, and Clear ListBox items
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            ListBox1.Items.Add(TextBox1.Text)
            TextBox1.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex <> -1 Then
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        Else
            MessageBox.Show("Select an item first")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub

End Class
