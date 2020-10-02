Public Class Form16

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If Label2.BackColor = Color.LightCoral Then
            Form4.BackgroundImage = System.Drawing.Image.FromFile("F:\Apps\RoX os\RoX os\Resources\2.PNG")
        Else
            Form3.BackgroundImage = System.Drawing.Image.FromFile("F:\Apps\RoX os\RoX os\Resources\start\1.png")
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Label2.BackColor = Color.LightCoral Then
            Form4.BackgroundImage = System.Drawing.Image.FromFile("F:\Apps\RoX os\RoX os\Resources\4.PNG")
        Else
            Form3.BackgroundImage = System.Drawing.Image.FromFile("F:\Apps\RoX os\RoX os\Resources\start\5.png")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Label2.BackColor = Color.LightCoral Then
            Form4.BackgroundImage = System.Drawing.Image.FromFile("F:\Apps\RoX os\RoX os\Resources\5.PNG")
        Else
            Form3.BackgroundImage = System.Drawing.Image.FromFile("F:\Apps\RoX os\RoX os\Resources\start\3.png")
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label1.BackColor = Color.Silver
        Label2.BackColor = Color.LightCoral
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.BackColor = Color.LightCoral
        Label2.BackColor = Color.Silver
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If Label2.BackColor = Color.LightCoral Then
            Form4.BackgroundImage = System.Drawing.Image.FromFile("F:\Apps\RoX os\RoX os\Resources\3.PNG")
        Else
            Form3.BackgroundImage = System.Drawing.Image.FromFile("F:\Apps\RoX os\RoX os\Resources\start\4.png")
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If Label2.BackColor = Color.LightCoral Then
            Form4.BackgroundImage = System.Drawing.Image.FromFile("F:\Apps\RoX os\RoX os\Resources\6.PNG")
        Else
            Form3.BackgroundImage = System.Drawing.Image.FromFile("F:\Apps\RoX os\RoX os\Resources\start\2.png")
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If Label2.BackColor = Color.LightCoral Then
            Form4.BackgroundImage = System.Drawing.Image.FromFile("F:\Apps\RoX os\RoX os\Resources\7.PNG")
        Else
            Form3.BackgroundImage = System.Drawing.Image.FromFile("F:\Apps\RoX os\RoX os\Resources\start\6.png")
        End If
    End Sub
End Class