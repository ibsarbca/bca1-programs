Class Student
    Private c As Integer
    Public Property MyRoll() As Integer
        Get
            Return c
        End Get
        Set(ByVal value As Integer)
            c = value
        End Set
    End Property
End Class
Module Module1
    Sub Main()
        Dim e As New Student()
        ' Set property.
        Console.WriteLine("Assign value for the property:")
        e.MyRoll = Console.ReadLine()

        ' Get property.
        Console.WriteLine("Value of property:")
        Console.WriteLine(e.MyRoll)
        Console.ReadLine()
    End Sub
End Module