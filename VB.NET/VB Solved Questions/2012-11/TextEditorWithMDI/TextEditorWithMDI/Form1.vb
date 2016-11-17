Imports System.IO
Imports System.Diagnostics

' Technically speaking this specific question does not require MDI forms but others do
' So an MDI container is used here.
Public Class Form1
    Public Shared currentFileName As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal)
        DateLabel.Text = DateTime.Now().ToLongDateString & ", " & DateTime.Now().ToLongTimeString()
    End Sub

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


    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        Dim dialog = New ColorDialog()
        dialog.ShowDialog()
        RichTextBox1.ForeColor = dialog.Color
    End Sub

 
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If Control.IsKeyLocked(Keys.CapsLock) Then
            CapsLockLabel.Text = "Caps lock is ON"
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    
    Private Sub RichTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles RichTextBox1.KeyDown
        If Control.IsKeyLocked(Keys.CapsLock) Then
            CapsLockLabel.Text = "Caps lock is ON"
        Else
            CapsLockLabel.Text = "Caps lock is OFF"
        End If
    End Sub

    Private Sub FontSizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontSizeToolStripMenuItem.Click
        Dim dialog = New FontDialog()
        dialog.ShowDialog()
        RichTextBox1.Font = dialog.Font
    End Sub
End Class
