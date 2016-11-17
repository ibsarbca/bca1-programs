Imports System.IO
Imports System.Diagnostics

' Technically speaking this specific question does not require MDI forms but others do
' So an MDI container is used here.
Public Class Form1
    Public Shared currentFileName As String
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        RichTextBox1.Text = ""
        currentFileName = ""
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim ofd = New OpenFileDialog()
        ofd.ShowDialog()
        currentFileName = ofd.FileName
        Using sreader = New StreamReader(currentFileName)
            RichTextBox1.Text = sreader.ReadToEnd()
        End Using
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If currentFileName = "" Or currentFileName = Nothing Then
            SaveAsToolStripMenuItem_Click(sender, e)
            ' This would set the currentFileName as required
        Else
            Using swriter = New StreamWriter(currentFileName)
                swriter.Write(RichTextBox1.Text)
            End Using
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim saveAsDialog = New SaveFileDialog()
        saveAsDialog.ShowDialog()
        currentFileName = saveAsDialog.FileName
        SaveToolStripMenuItem_Click(sender, e) ' This would directly go and write the file, technically.
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End ' the program
    End Sub
End Class
