Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim str = ""

        Dim arr() As Integer = {1, 2, 3, 4}
        For Each n In arr
            str &= " " & n
        Next

        MsgBox(str)


        Me.Close()
    End Sub
End Class
