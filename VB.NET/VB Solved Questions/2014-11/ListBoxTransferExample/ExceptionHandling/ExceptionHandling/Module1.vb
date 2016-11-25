Module Module1

    Sub Main()

        Console.WriteLine("EXAMPLE 1")
        Console.WriteLine("---------------------------")

        Dim coordinator As String = "XYZ"

        ' Let's say the coordinator is absent.
        ' Therefore, there is no coordinator in the college.
        coordinator = Nothing ' nothing means null.

        Try
            ' Here we try calling the coordinator.
            coordinator.ToString()
        Catch ex As NullReferenceException
            ' Oh No. There is no coordinator, we cannot call them. So we go to a different faculty.
            Console.WriteLine("ERROR: Cannot call coordinator. Calling other Facutly...")
            Console.WriteLine("Excuse me, Sir")
        End Try


        Console.WriteLine("EXAMPLE 2")
        Console.WriteLine("---------------------------")

        ' Another example:
        ' Array of FIVE elements
        Dim someArray() As Integer = {10, 20, 30, 40, 50}

        ' Now we have some counter
        Dim count = 0
        Try
            While count < 10
                Console.WriteLine("Count = " & count & " Value = " & someArray(count))
                count += 1
            End While
        Catch ex As IndexOutOfRangeException
            Console.WriteLine("ERROR: Maximum length of array is " & someArray.Length)
        End Try

        CustomExceptionExample()

        Console.Read()
    End Sub

    Public Class CustomException
        Inherits Exception

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal message As String)
            MyBase.New(Message)
        End Sub

        Public Sub New(ByVal message As String, ByRef inner As Exception)
            MyBase.New(message, inner)
        End Sub
    End Class

    Public Sub CustomExceptionExample()
        Try
            Throw New CustomException("HELLO. I am a custom exception")
        Catch ex As CustomException
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Module


