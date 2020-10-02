Public Class Form5

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Label1.Text = Form3.Label1.Text
        ProgressBar1.Hide()
        Cursor.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 100 Then
            Form4.Show()
            Me.Close()
            Cursor.Show()
        End If
    End Sub
End Class