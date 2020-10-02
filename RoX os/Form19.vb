Public Class Form19

    Private Sub Form19_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Label2.Text = DateString
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay
    End Sub

  
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class