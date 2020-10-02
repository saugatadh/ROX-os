Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Hide()
        ProgressBar1.Hide()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(10)
        If ProgressBar1.Value = 100 Then
            Form2.Show()
            ProgressBar1.Value = 0
            Timer1.Stop()
        End If
    End Sub
End Class
