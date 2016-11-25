'Use of system.array class to perform copy,sort,clear,reverse
Imports System.Array
Module ArrayClass
    Sub main()
        Dim arrInt(5) As Integer
        Dim arrcpy(5) As Integer
        Dim arrString(5) As String
        Dim i As Integer
        Console.WriteLine("Enter elements in array:")
        For i = 0 To 4
            arrInt(i) = Console.ReadLine
        Next
        Array.Copy(arrInt, arrcpy, arrcpy.Length)
        Console.WriteLine("Copy:")
        For i = 0 To 4
            Console.WriteLine(arrcpy(i))
        Next
        Console.WriteLine("sort:")
        Array.Sort(arrInt)
        For i = 1 To 5
            Console.WriteLine(arrInt(i))
        Next
        Console.WriteLine("Clear:")
        Array.Clear(arrInt, 1, 5)
        For i = 1 To 5
            Console.WriteLine(arrInt(i))
        Next
        Console.WriteLine("Reverse:")
        Array.Reverse(arrcpy)
        For i = 1 To 5
            Console.WriteLine(arrcpy(i))
        Next
        Console.ReadLine()
    End Sub
End Module