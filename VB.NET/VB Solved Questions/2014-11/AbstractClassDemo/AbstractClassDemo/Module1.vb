Module Module1

    Public MustInherit Class Shape
        Public MustOverride Sub Area()
    End Class

    Public Class Circle
        Inherits Shape
        Public Overrides Sub Area()
            Console.WriteLine("Enter Radius: ")
            Dim radius = Console.ReadLine()
            Console.WriteLine(3.14 * radius * radius)
        End Sub
    End Class

    Public Class Square
        Inherits Shape

        Public Overrides Sub Area()
            Console.WriteLine("Enter Length of side: ")
            Dim len = Console.ReadLine()
            Console.WriteLine(len * len)
        End Sub
    End Class

    Sub Main()
        Dim c = New Circle()
        c.Area()

        Dim s = New Square
        s.Area()

        Console.ReadLine()

    End Sub

End Module
