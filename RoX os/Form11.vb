Public Class Form11

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Hide()
        PictureBox11.Hide()
        PictureBox10.Hide()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        WebBrowser1.Show()
        Dim url As String = "c:\"
        WebBrowser1.Navigate(url)
        PictureBox11.Show()
        PictureBox10.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        WebBrowser1.Show()
        Dim url As String = "D:\"
        WebBrowser1.Navigate(url)
        PictureBox11.Show()
        PictureBox10.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        WebBrowser1.Show()
        Dim url As String = "F:\apps"

        WebBrowser1.Navigate(url)
        PictureBox11.Show()
        PictureBox10.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        WebBrowser1.Show()
        Dim url As String = "F:\songs"

        WebBrowser1.Navigate(url)
        PictureBox11.Show()
        PictureBox10.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        WebBrowser1.Show()
        Dim url As String = "F:\videos"

        WebBrowser1.Navigate(url)
        PictureBox11.Show()
        PictureBox10.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        WebBrowser1.Show()
        Dim url As String = "F:\photos"

        WebBrowser1.Navigate(url)
        PictureBox11.Show()
        PictureBox10.Show()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        WebBrowser1.Show()
        Dim url As String = "F:\games"

        WebBrowser1.Navigate(url)
        PictureBox11.Show()
        PictureBox10.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        WebBrowser1.Show()
        Dim url As String = "E:\"

        WebBrowser1.Navigate(url)
        PictureBox11.Show()
        PictureBox10.Show()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        WebBrowser1.Hide()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Me.Close()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        WebBrowser1.Show()
        Dim url As String = "F:\"

        WebBrowser1.Navigate(url)
        PictureBox11.Show()
        PictureBox10.Show()
    End Sub

   
    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class