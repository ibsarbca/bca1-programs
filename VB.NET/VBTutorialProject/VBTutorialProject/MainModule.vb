
Module MainModule

    Sub Main()
        LogicalOperators()
        Console.ReadLine()
    End Sub

    Sub LogicalOperators()
        Dim A, B As Integer
        A = 10
        B = 20

        If A > 15 And Foo() Then
            Console.WriteLine("OKAY")
        End If
    End Sub

    Function Foo()
        Console.WriteLine("Hello! I'm Foo!")
        Return True
    End Function
End Module
