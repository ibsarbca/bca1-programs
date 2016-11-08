Module Module1

    Class Stud
        Dim _myroll As Integer

        Public Property MyRoll As Int16
            Get
                Return _myroll
            End Get
            Set(value As Int16)
                _myroll = value
            End Set
        End Property
    End Class

    Sub Main()
        Dim std As Stud = New Stud()
        std.MyRoll = 20
        Console.WriteLine(std.MyRoll)

        Console.Read()
    End Sub

End Module
