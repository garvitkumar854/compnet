' Question 40: Develop a form with Previous and Next buttons to display different images in a PictureBox
Public Class Form1

    Private images() As String = {
        "Images\img1.jpg",
        "Images\img2.jpg",
        "Images\img3.jpg"
    }

    Private index As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = Image.FromFile(images(index))
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        If index < images.Length - 1 Then
            index += 1
            PictureBox1.Image = Image.FromFile(images(index))
        End If
    End Sub

    Private Sub ButtonPrevious_Click(sender As Object, e As EventArgs) Handles ButtonPrevious.Click
        If index > 0 Then
            index -= 1
            PictureBox1.Image = Image.FromFile(images(index))
        End If
    End Sub

End Class
