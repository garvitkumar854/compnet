' Question 38: Use CheckBoxes (Bold, Italic, Underline) to change the style of text displayed in a Label
Public Class Form1

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) _
        Handles CheckBox1.CheckedChanged, CheckBox2.CheckedChanged, CheckBox3.CheckedChanged

        Dim style As FontStyle = FontStyle.Regular

        If CheckBox1.Checked Then style = style Or FontStyle.Bold
        If CheckBox2.Checked Then style = style Or FontStyle.Italic
        If CheckBox3.Checked Then style = style Or FontStyle.Underline

        Label1.Font = New Font(Label1.Font, style)

    End Sub

End Class
