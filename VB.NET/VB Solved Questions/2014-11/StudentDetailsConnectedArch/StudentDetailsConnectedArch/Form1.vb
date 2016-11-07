Imports System.Data.SqlClient

Public Class Form1

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim form = New AddForm()
        form.Show()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim form = New UpdateForm()
        form.Show()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        End ' The program, that is.
    End Sub
End Class
