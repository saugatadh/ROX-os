Public Class Form20

    Private Sub Form20_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Hide()
        Timer1.Start()
        ProgressBar1.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            WebBrowser1.Show()
        End If
    End Sub
End Class