Imports ComDLL
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim com = New ComDLL.ComClass1()
        MsgBox(com.FREE())
    End Sub
End Class
