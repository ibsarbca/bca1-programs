Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fs = New FileStream("hello-world.txt", FileMode.Create, FileAccess.Write)
        Dim swriter = New StreamWriter(fs)

        swriter.WriteLine("Hello World")

        swriter.Close()
    End Sub

    Private Sub ReadButton_Click(sender As Object, e As EventArgs) Handles ReadButton.Click
        Dim fs = New FileStream("hello-world.txt", FileMode.Open, FileAccess.Read)
        Dim sread = New StreamReader(fs)

        RichTextBox1.Text = sread.ReadToEnd()

        sread.Close()
    End Sub
End Class
