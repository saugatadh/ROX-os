Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Hide()
        Label4.Hide()
        Label5.Hide()
        PictureBox7.Hide()
        PictureBox6.Hide()

        TrackBar1.Hide()
        PictureBox1.Hide()
        PictureBox3.Hide()
        PictureBox4.Hide()

        Label6.Text = TimeString
        Label7.Text = DateString
        Label3.Hide()
        Timer1.Start()

        WebBrowser2.Hide()
        Label2.Hide()
        PictureBox20.Hide()
        PictureBox21.Hide()
        TextBox2.Hide()
        TextBox3.Hide()
        Button2.Hide()
        Button3.Hide()
        PictureBox19.Hide()

    End Sub

   

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If Form3.Label1.Text = "       Guest" Then
            MsgBox("Please login with administrator to open the file")
            Form7.Show()
        End If
        If Form3.Label1.Text = "Administrator" Then
            form9.Show()
        End If
    End Sub



    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Form15.Show()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click

        If Form3.Label1.Text = "       Guest" Then
            MsgBox("Please login with administrator to open the file")
            Form7.Show()
        End If
        If Form3.Label1.Text = "Administrator" Then
            calculator.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        Label6.Text = TimeString
        Label2.Text = TimeOfDay()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Form11.Show()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        If Form3.Label1.Text = "       Guest" Then
            MsgBox("Please login with administrator to open the file")
            Form7.Show()
        End If
        If Form3.Label1.Text = "Administrator" Then
            Form16.Show()
        End If
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Label1.Show()
        Label4.Show()
        Label5.Show()
        PictureBox7.Show()
        PictureBox6.Show()

    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Form17.Show()
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Form8.Show()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Form8.Show()
    End Sub



    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Form3.Label1.Text = "       Guest" Then
            MsgBox("Please login with administrator to open the file")
            Form7.Show()
        End If
        If Form3.Label1.Text = "Administrator" Then
            form9.Show()
            form9.WebBrowser1.Navigate("http://www.google.com/search?q=" + TextBox2.Text)
            form9.TextBox1.Text = "http://www.google.com/search?q=" + TextBox2.Text
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub



    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Form3.Label1.Text = "       Guest" Then
            MsgBox("Please login with administrator to open the file")
            Form7.Show()
        End If
        If Form3.Label1.Text = "Administrator" Then
            form9.Show()
            form9.WebBrowser1.Navigate("https://www.bing.com/search?q=" + TextBox3.Text)
            form9.TextBox1.Text = "https://www.bing.com/search?q=" + TextBox3.Text
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub WebBrowser2_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted

    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click

    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click

        WebBrowser2.Show()
        Label2.Show()
        PictureBox20.Show()
        PictureBox21.Show()
        TextBox2.Show()
        TextBox3.Show()
        Button2.Show()
        Button3.Show()
        PictureBox19.Show()
        Label3.Show()

    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click
        WebBrowser2.Hide()
        Label2.Hide()
        PictureBox20.Hide()
        PictureBox21.Hide()
        TextBox2.Hide()
        TextBox3.Hide()
        Button2.Hide()
        Button3.Hide()
        PictureBox19.Hide()
        Label3.Hide()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Text = TimeOfDay
        Label2.Text = TimeOfDay
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)
        form9.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Form19.Show()
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        TrackBar1.Show()
        PictureBox1.Show()
    End Sub
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
       
    End Sub

   

   
    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TrackBar1.Hide()
        PictureBox1.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PictureBox3.Hide()
        PictureBox4.Hide()
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        PictureBox3.Show()
        PictureBox4.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Form10.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Form10.Label1.Text = "   Restarting"
        Form10.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Label1.Hide()
        Label4.Hide()
        Label5.Hide()
        PictureBox7.Hide()
        PictureBox6.Hide()
    End Sub
End Class




