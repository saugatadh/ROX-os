Public Class Form3

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cursor.Show()
        Button2.Hide()
        Timer1.Start()
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "sos" And TextBox2.Text = "1234" Then
            Form5.Show()
            TextBox2.Text = ""
        Else
            MsgBox("You Entered wrong Password or ID", 16, "Incorrect Fields")
            TextBox1.Text = ""
            TextBox2.Text = ""

        End If


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Label1.Text = "Administrator"
        Label4.BackColor = Color.LightCoral
        Label5.BackColor = Color.Silver
        Label3.Show()
        Button1.Show()
        TextBox2.Show()
        TextBox1.Show()
        Label2.Show()
        Button2.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Label1.Text = "       Guest"
        Label5.BackColor = Color.LightCoral
        Label4.BackColor = Color.Silver
        Label3.Hide()
        Button1.Hide()
        TextBox2.Hide()
        TextBox1.Hide()
        Label2.Hide()
        Button2.Show()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Text = TimeOfDay


    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class