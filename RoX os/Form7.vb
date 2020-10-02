Public Class Form7

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If TextBox1.Text = "sos" And TextBox2.Text = "1234" Then
            Form3.Label1.Text = "Administrator"
        Else
            MsgBox("You Entered wrong Password or ID", 16, "Incorrect Fields")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        Form4.PictureBox12.BackColor = Color.Transparent
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class