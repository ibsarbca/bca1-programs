Imports System.IO
Module FileReadShow
    Class student
        Dim studentID As Integer
        Dim name As String
        Dim qualification As String
        Dim percentage As Integer
        Public Function GetData()
            Console.WriteLine("Enter the information for writing into file:")
            Using writer As StreamWriter = New StreamWriter("E:/myfile.txt")
                Console.WriteLine("Enter Name:")
                name = Console.ReadLine
                writer.WriteLine("Name=" & name)
                Console.WriteLine("Enter Id:")
                studentID = Console.ReadLine
                writer.WriteLine("Id=" & studentID)
                Console.WriteLine("Enter Qualification:")
                qualification = Console.ReadLine
                writer.WriteLine("Qualification=" & qualification)
                Console.WriteLine("Enter Percentage:")
                percentage = Console.ReadLine
                writer.WriteLine("Percentage=" & percentage)
            End Using
            Return 0
        End Function
        Public Function ShowData()
            Dim value As String = File.ReadAllText("E:\myfile.txt")
            Console.WriteLine(value)
            Return 0
        End Function

    End Class
    Sub Main()
        Dim obj As New student
        'obj.GetData()
        obj.ShowData()
        Console.ReadLine()
    End Sub

End Module
