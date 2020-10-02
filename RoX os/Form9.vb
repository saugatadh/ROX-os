Public Class form9

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        WebBrowser2.Navigate(TextBox2.Text)
        Label3.Text = TextBox2.Text
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        WebBrowser1.Navigate(TextBox1.Text)
        Label1.Text = TextBox1.Text
    End Sub

    Private Sub WebBrowser2_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        PictureBox3.Show()
        Label2.Hide()
        WebBrowser2.Show()
        TextBox2.Show()
        TextBox1.Hide()
        PictureBox1.Hide()
        PictureBox2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Label7.Hide()
        WebBrowser1.Hide()
        WebBrowser2.Show()
        WebBrowser3.Hide()
        PictureBox1.Hide()
        PictureBox2.Show()
        TextBox2.Show()
        TextBox1.Hide()
        If PictureBox7.Visible = False Then
            Label4.Show()
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label7.Hide()
        WebBrowser1.Show()
        WebBrowser2.Hide()
        PictureBox2.Hide()
        PictureBox1.Show()
        TextBox1.Show()
        TextBox2.Hide()
        Label4.Hide()
        WebBrowser3.Hide()
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Hide()
        Label6.Hide()
        Label4.Hide()
        PictureBox3.Hide()
        WebBrowser1.Show()
        WebBrowser2.Hide()
        WebBrowser3.Hide()
        Label3.Hide()
        PictureBox2.Hide()
        PictureBox1.Show()
        PictureBox7.Hide()
        TextBox3.Hide()
        PictureBox8.Hide()
        Label5.Hide()
        TextBox3.Hide()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If WebBrowser1.Visible = True Then
            WebBrowser1.GoBack()
        ElseIf WebBrowser2.Visible = True Then
            WebBrowser2.GoBack()
        ElseIf WebBrowser3.Visible = True Then
            WebBrowser3.GoBack()
        End If

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If WebBrowser1.Visible = True Then
            WebBrowser1.GoForward()
        ElseIf WebBrowser2.Visible = True Then
            WebBrowser2.GoForward()
        ElseIf WebBrowser3.Visible = True Then
            WebBrowser2.GoForward()
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If WebBrowser1.Visible = True Then
            WebBrowser1.Refresh()
        ElseIf WebBrowser2.Visible = True Then
            WebBrowser2.Refresh()
        ElseIf WebBrowser2.Visible = True Then
            WebBrowser2.Refresh()
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        PictureBox3.Hide()
        Label2.Show()
        WebBrowser2.Hide()
        TextBox2.Hide()
        TextBox1.Show()
        PictureBox1.Show()
        PictureBox2.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        WebBrowser3.Show()
        WebBrowser1.Hide()
        WebBrowser2.Hide()
        PictureBox7.Show()
        Label6.Show()
        Label7.Show()
        PictureBox8.Show()
        TextBox3.Show()
        Label4.Hide()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        WebBrowser3.Show()
        WebBrowser1.Hide()
        WebBrowser2.Hide()
        PictureBox7.Show()
        Label6.Show()
        PictureBox8.Show()
        Label4.Hide()
        Label7.Show()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        WebBrowser3.Navigate(TextBox3.Text)
        Label6.Text = TextBox3.Text
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        WebBrowser3.Hide()
        WebBrowser1.Hide()
        WebBrowser2.Show()
        PictureBox7.Hide()
        Label6.Hide()
        PictureBox8.Hide()
        Label7.Hide()
    End Sub
End Class