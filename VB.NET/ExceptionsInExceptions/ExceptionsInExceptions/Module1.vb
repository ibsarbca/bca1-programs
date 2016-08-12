Imports System.IO

Module Module1

    Sub Main()
        ExceptionWithExceptions.Execute()
        Console.Read()
    End Sub

End Module

Public Class ExceptionWithExceptions

    ''' <summary>
    ''' Function exists to simple execute code without messing up other code in the project
    ''' It's like a main function if you already have a Main() function and don't want to mess with it
    ''' </summary>
    ''' <returns>Nothing</returns>
    ''' <remarks></remarks>
    Public Shared Function Execute()
        NestedExceptionWithThrow()
    End Function

    ''' <summary>
    ''' This function does the same thing as NestedExceptionsUseCase(), only we do it manually by throwing the exception
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function NestedExceptionWithThrow()
        Try
            ' Some code that throws NRE
            Throw New NullReferenceException("CUSTOM EXCEPTION MESSAGE")
        Catch ex As NullReferenceException
            Console.WriteLine("NRE caught. Message: " + ex.Message)
            Try
                Throw ex
            Catch ex
                ' Different catch block. Here, ex will be bound to a new exception
                Console.WriteLine("Ex (our NRE) is rethrown. Message: " + ex.Message)
            End Try
        End Try
    End Function

    ''' <summary>
    ''' Here we'll try to access a file locally. If the file doesn't exist, or is not available, 
    ''' we will check a remote backup of the file.
    ''' If that doesn't exist either, then we say that the file is simply unavailable.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function NestedExceptionUseCase()
        Dim fs
        Try
            ' Try to access the file.
            fs = New FileStream("myfile.txt", System.IO.FileMode.Open)
        Catch myIOE As Exception
            ' print the value a unique member associated with that instance
            Console.WriteLine(myIOE.GetHashCode())

            ' If there's an exception, it means that the file is not available locally.
            ' We try to access it through some imaginary network share

            Try
                ' Assuming some mapped drive Z:\
                fs = New FileStream("Z:\myfile.txt", System.IO.FileMode.Open)
            Catch myIOE ' This is a different object because it's a new exception
                ' This means that the file is not available remotely either.
                ' So we let the user deal with it.
                Console.WriteLine(myIOE.GetHashCode)
                ' The HashCode is different because it is bound to a new Exception
                Console.WriteLine("All sources checked. The file is myfile.txt is missing")
            End Try
        End Try
    End Function
End Class

