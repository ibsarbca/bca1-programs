
Public Class Form1

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click

    End Sub

    ' Technically we should use regex here, but for the sake of simplicity...

    Function IsValidUserName(ByVal uname As String) As Boolean
        ' For each character in the string
        For Each ch In uname.ToCharArray()
            If Not Char.IsLetter(ch) Then
                Return False
            End If
        Next
        Return True
    End Function

    Function IsValidPassword(ByVal pass As String) As Boolean
        For Each ch In pass.ToCharArray()
            If Not Char.IsLetterOrDigit(ch) Then
                Return False
            End If

        Next
        Return True
    End Function

    Function IsValidEmail(ByVal email As String) As Boolean
        ' Assume it doesn't contain anything at first
        Dim containsAt = False, containsDot = False, containsLettersAndDigitsOnly = False

        For Each ch In email.ToCharArray
            If ch = "@"c And containsAt = False Then
                containsAt = True ' We found an @ symbol, ignore this
                Continue For
            End If

            If ch = "."c And containsDot = False Then
                containsDot = True
                Continue For
            End If

            ' Theoretically it will only get here if the other two conditions are not being checked
            If Char.IsLetterOrDigit(ch) Then
                containsLettersAndDigitsOnly = True
                Continue For
            End If

            If containsAt And containsDot And containsLettersAndDigitsOnly Then
                Return True
            Else
                Return False
            End If
            
        Next

        Return True
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


