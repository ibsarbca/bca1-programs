Imports System.IO
Imports System.Diagnostics


Public Class Form1

    Private Sub SourceTextBox_Click(sender As Object, e As EventArgs) Handles SourceTextBox.Click
        OpenFileDialog1.ShowDialog()
        SourceTextBox.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DestTextBox_TextChanged(sender As Object, e As EventArgs) Handles DestTextBox.TextChanged

    End Sub

    Private Sub DestTextBox_Click(sender As Object, e As EventArgs) Handles DestTextBox.Click
        OpenFileDialog1.ShowDialog()
        DestTextBox.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim sreader = New StreamReader(SourceTextBox.Text)
        Dim swriter = New StreamWriter(DestTextBox.Text)

        swriter.Write(sreader.ReadToEnd())

        swriter.Close()
        sreader.Close()
    End Sub

    Private Sub ShowFilesButton_Click(sender As Object, e As EventArgs) Handles ShowFilesButton.Click
        Process.Start("notepad.exe", SourceTextBox.Text)
        Process.Start("notepad.exe", DestTextBox.Text)
    End Sub
End Class
