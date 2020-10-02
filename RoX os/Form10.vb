Public Class Form10

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Hide()
        If Label1.Text = "Shutting down" Then
            Timer1.Start()
        ElseIf Label1.Text = "   Restarting" Then
            Timer2.Start()
        ElseIf Label1.Text = "  Signing Out" Then
            Timer3.Start()
        End If
        Cursor.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 100 Then
            Form1.Close()
            Form2.Close()
            Form3.Close()
            Me.Close()
            form5.Close()
            Form7.Close()
            Form8.Close()
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 100 Then
            Form4.Close()
            Form3.Close()
            Form2.Close()
            Me.Close()
            Form1.Timer1.Start()
            Form1.Show()
        End If
    End Sub

    
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 100 Then
            Form4.Close()
            Form8.Close()
            Me.Close()
            Form3.Show()
        End If
    End Sub
End Class