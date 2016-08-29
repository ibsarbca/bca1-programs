''' <summary>
''' This file explains how the scope of a variable affects its visibility. If a variable is declared in a specific scope, 
''' it is not available outside of it. 
''' </summary>
''' <remarks></remarks>
Module Module1

    Dim GLOBALCOUNT As Integer = 2000

    Sub Main()
        FirstFunction()
        Console.WriteLine()

        SecondFunction()
        Console.WriteLine()

        OtherModule.ThirdFunction()

        Console.ReadLine()
    End Sub


    Function FirstFunction()
        ' this function does not know what the "SecondFunctionCount" is
        Console.WriteLine("I am the first function. I know what GLOBALCOUNT is. GLOBALCOUNT = " & GLOBALCOUNT)
        Dim Count = 1

        While Count < 10
            Count += 1
        End While

        Console.WriteLine("I say the count variable is " & Count)

    End Function

    Function SecondFunction()
        ' this function does not know what the "FirstFunctionCount" is
        Console.WriteLine("I am the second function. I know what GLOBALCOUNT is. GLOBALCOUNT = " & GLOBALCOUNT)
        Dim Count = 20

        While Count < 30
            Count += 1
        End While

        Console.WriteLine("I say the count variable is " & Count)

    End Function

    Sub ScopeInABlock()
        Dim x = 10
        If x = 10 Then
            Dim y = 20
        End If

        ' y does not exist, not outside the If block above. Therefore this code does not compile
        'If y = 20 Then
        '    Console.WriteLine("y = " & y)
        'End If
    End Sub

End Module


Module OtherModule
    Dim GLOBALCOUNT = 3000

    Sub ThirdFunction()
        Console.WriteLine("I am the third function. I know what GLOBALCOUNT is. GLOBALCOUNT = " & GLOBALCOUNT)
        Console.WriteLine("There is no count variable")

        ' This function has no idea what is happening in Module1
        ' To use the functions in Module1, we use the "Dot" (.) operator

        ' Dot means "in that". 
        ' This means that this statement translates to:
        ' Module1, IN THAT, ScopeInABlock()
        ' This function is completely different from the function defined above.
        ' Because we are referencing the function INSIDE Module1
        Module1.ScopeInABlock()
    End Sub

    Sub ScopeInABlock()
        Dim x = 100
        For x = 100 To 1000
            x += 1
        Next
    End Sub
End Module