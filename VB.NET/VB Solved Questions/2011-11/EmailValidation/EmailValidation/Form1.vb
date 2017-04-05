Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Assume it doesn't contain anything at first.
        Dim containsAt = False, containsDot = False, containsLettersAndDigitsOnly = False

        For Each ch In TextBox1.Text.ToCharArray()
            Debug.WriteLine("ch = " & ch)

            If ch = "@"c And containsAt = False Then
                containsAt = True
                ' We found an @ symbol, ignore this
                Continue For
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
            Debug.WriteLine("AT = " & containsAt & " DOT = " & containsDot & " L&D = " & containsLettersAndDigitsOnly)
        End If

        If containsAt And containsDot And containsLettersAndDigitsOnly Then
            MsgBox("Email is valid")
        End If
    End Sub
End Class
