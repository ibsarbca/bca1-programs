﻿Imports System.Diagnostics

Public Class Form1

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        If Not IsValidUserName(UsernameTextBox.Text) Then
            UsernameErrorProvider.SetError(UsernameTextBox, "Username is invalid")
        Else
            UsernameErrorProvider.Clear()
        End If

        If Not IsValidPassword(PasswordTextBox.Text) Then
            PasswordErrorProvider.SetError(PasswordTextBox, "Password is invalid")
        Else
            PasswordErrorProvider.Clear()
        End If

        If Not IsValidEmail(EmailTextBox.Text) Then
            EmailErrorProvider.SetError(EmailTextBox, "Email is invalid")
        Else
            EmailErrorProvider.Clear()
        End If

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

        ' Note:
        ' Theoretically this is the wrong way of doing this. Technically speaking the proper way to do this is to use
        ' regular expressions. However, since using regular expressions is outside the scope of this source file,
        ' the following statements are used. However, it should be noted that the validation is not complete for the sake of time
        ' and complexity. The code to do proper, complete  email validation would be too large anyway, in which case regular expressions 
        ' would make more sense.
        For Each ch In email.ToCharArray()

            Debug.WriteLine("ch = " & ch)

            If ch = "@"c And containsAt = False Then
                containsAt = True ' We found an @ symbol, ignore this
                Continue For ' Go to next character
                Debug.WriteLine("@ found")
            End If

            If ch = "."c And containsDot = False Then
                containsDot = True
                Continue For
                Debug.WriteLine("dot found")
            End If

            ' Theoretically it will only get here if the other two conditions are not being checked
            If Char.IsLetterOrDigit(ch) Then
                containsLettersAndDigitsOnly = True
                Continue For
            Else
                containsLettersAndDigitsOnly = False
            End If

        Next

        If containsAt And containsDot And containsLettersAndDigitsOnly Then
            Debug.WriteLine("AT = " & containsAt & " DOT = " & containsDot & "L&D = " & containsLettersAndDigitsOnly)
            Return True
        Else
            Debug.WriteLine("AT = " & containsAt & " DOT = " & containsDot & "L&D = " & containsLettersAndDigitsOnly)
            Return False
        End If
        Return True
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


