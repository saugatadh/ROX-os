Public Class Form8

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        If Form3.Label1.Text = "       Guest" Then
            MsgBox("Please login with administrator to open the file")
            Form7.Show()
        End If
        If Form3.Label1.Text = "Administrator" Then
            Form18.Show()
        End If
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form11.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If Form3.Label1.Text = "       Guest" Then
            MsgBox("Please login with administrator to open the file")
            Form7.Show()
        End If
        If Form3.Label1.Text = "Administrator" Then
            form9.Show()
        End If
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If Form3.Label1.Text = "       Guest" Then
            MsgBox("Please login with administrator to open the file")
            Form7.Show()
        End If
        If Form3.Label1.Text = "Administrator" Then
            calculator.Show()
        End If
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form15.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If Form3.Label1.Text = "       Guest" Then
            MsgBox("Please login with administrator to open the file")
            Form7.Show()
        End If
        If Form3.Label1.Text = "Administrator" Then
            Form13.Show()
        End If
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If Form3.Label1.Text = "       Guest" Then
            MsgBox("Please login with administrator to open the file")
            Form7.Show()
        End If
        If Form3.Label1.Text = "Administrator" Then
            Form14.Show()
        End If
        Me.Close()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If Form3.Label1.Text = "       Guest" Then
            MsgBox("Please login with administrator to open the file")
            Form7.Show()
        End If
        If Form3.Label1.Text = "Administrator" Then
            Form16.Show()
        End If
        Me.Close()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Form17.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Form19.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If Form3.Label1.Text = "       Guest" Then
            MsgBox("Please login with administrator to open the file")
            Form7.Show()
        End If
        If Form3.Label1.Text = "Administrator" Then
            Form20.Show()
        End If
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Form10.Show()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox13.Hide()
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        PictureBox15.Hide()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        PictureBox13.Show()
        Label1.Show()
        Label2.Show()
        Label3.Show()
        PictureBox15.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
        Form10.Label1.Text = "  Signing Out"
        Form10.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Form10.Label1.Text = "   Restarting"
        Form10.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        PictureBox13.Hide()
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        PictureBox15.Hide()
    End Sub
End Class