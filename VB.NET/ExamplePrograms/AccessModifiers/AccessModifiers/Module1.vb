' This assembly demonstrates the use of access specifiers as they would apply to real world situations.
' The student information module contiains information about a particular student along with certain properties of that would be
' public, private, protected or of Friend Level depending on what it is, and whether or not a student would want to share with with the 
' outside world.
' Suppose we have two places where we can get data. 
' 1. Main Data -- this would contain the main student data that you would get if you ask about it in the college.
' 2. Attendance Data -- this would contain attendance information only available (or visible) if you see the attendance register.

''' This class represents all the Main Student Data that is available to the college. It includes marks, course,
''' attendance, everything.
''' Since the marks are private to that particular student and should not really be revealed to the Public, it is Private.
Public Class MainStudentData
    Private marks As Integer

    Public course As String
    Public name As String
    Public age As String

    ' Not available to the public
    Protected daysAttended As Integer

    ''' The college name is public, even to other colleges. Therefore it is a Friend. This means that it is available to any Module, any class, 
    ''' any Namespace, anything in this Project (or rather, assembly)
    Friend collegeName As String

    ' Constructor. Initializes the values to some specific ones.
    Public Sub New()
        marks = 200
        course = "BCA"
        name = "ABC"
        age = 22
        daysAttended = 90
        collegeName = "SOMETHING INSTITUTE OF MANAGEMENT"
    End Sub
End Class

''' This class represents only Attendance Data. Since Attendance data is a kind of (or a type of) Student Data
''' Therefore this, class inherits from MainStudentData. It only deals with attendance.
Public Class AttendanceData
    Inherits MainStudentData

    Public attendance As Integer
    Public Sub New()
        attendance = daysAttended
    End Sub
End Class

Module Module1
    Sub Main()
        Dim info = New MainStudentData()
        ' Show public student info (available to everyone)
        Console.WriteLine("MAIN STUDENT INFO: ")
        Console.WriteLine("  NAME: " & info.name)
        Console.WriteLine("  AGE: " & info.age)
        Console.WriteLine("  COLLEGE: " & info.collegeName)
        Console.WriteLine("  COURSE: " & info.course)
        Console.WriteLine("--------------------------")

        Dim register = New AttendanceData()

        ' Show info available if you use the register (not available to everyone)
        Console.WriteLine("STUDENT ATTENDANCE INFO: ")
        Console.WriteLine("  According to the current register, student attendance = " & register.attendance)
        Console.WriteLine("--------------------------")

        Console.ReadLine()
    End Sub
End Module
