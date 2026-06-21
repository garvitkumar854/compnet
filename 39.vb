' Question 41: Create a form using TextBoxes, ComboBox, RadioButtons, and CheckBoxes to collect employee details and display them in a summary
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("HR")
        ComboBox1.Items.Add("IT")
        ComboBox1.Items.Add("Finance")
        ComboBox1.Items.Add("Marketing")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim gender As String = ""
        Dim skills As String = ""

        If RadioButton1.Checked Then
            gender = "Male"
        ElseIf RadioButton2.Checked Then
            gender = "Female"
        End If

        If CheckBox1.Checked Then skills &= "C# "
        If CheckBox2.Checked Then skills &= "Java "
        If CheckBox3.Checked Then skills &= "Python "

        Label4.Text =
            "Name : " & TextBox1.Text & vbCrLf &
            "ID : " & TextBox2.Text & vbCrLf &
            "Department : " & ComboBox1.Text & vbCrLf &
            "Gender : " & gender & vbCrLf &
            "Skills : " & skills

    End Sub

End Class
