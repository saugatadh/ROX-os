Public Class Form13

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Hide()
        Timer1.Start()
        ProgressBar1.Hide()
        PictureBox10.Hide()
        PictureBox11.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 100 Then
            WebBrowser1.Show()
            PictureBox10.Show()
            PictureBox11.Show()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        WebBrowser1.GoForward()
    End Sub
End Class