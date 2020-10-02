Public Class Form15

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            Dim dlg As OpenFileDialog = New OpenFileDialog
            dlg.Title = "Open"
            dlg.Filter = "Rich Text Files (*.rtf)|*.rtf"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.LoadFile(dlg.FileName)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            Dim dlg As SaveFileDialog = New SaveFileDialog
            dlg.Title = "Save"
            dlg.Filter = "Rich Text Files (*.rtf)|*.rtf"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()

    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()

    End Sub

    Private Sub ColourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColourToolStripMenuItem.Click
        Try
            Dim dlg As ColorDialog = New ColorDialog
            dlg.Color = RichTextBox1.ForeColor
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.ForeColor = dlg.Color
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Try
            Dim dlg As FontDialog = New FontDialog
            dlg.Font = RichTextBox1.Font
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.Font = dlg.Font
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BlackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlackToolStripMenuItem.Click
        RichTextBox1.BackColor = Color.DarkGray
        RichTextBox1.ForeColor = Color.White


    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        RichTextBox1.BackColor = Color.White
        RichTextBox1.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class