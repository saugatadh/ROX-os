Public Class calculator

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        TextBox3.Text = TextBox1.Text - -TextBox2.Text
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TextBox3.Text = TextBox1.Text * TextBox2.Text
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        TextBox3.Text = TextBox1.Text ^ TextBox2.Text
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        TextBox3.Text = TextBox1.Text - TextBox2.Text
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        TextBox3.Text = TextBox1.Text / TextBox2.Text
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class