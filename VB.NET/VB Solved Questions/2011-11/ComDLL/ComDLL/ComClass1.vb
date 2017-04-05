<ComClass(ComClass1.ClassId, ComClass1.InterfaceId, ComClass1.EventsId)> _
Public Class ComClass1

#Region "COM GUIDs"
    ' These  GUIDs provide the COM identity for this class 
    ' and its COM interfaces. If you change them, existing 
    ' clients will no longer be able to access the class.
    Public Const ClassId As String = "8d7703e2-b285-41d1-9238-7a6831dd001b"
    Public Const InterfaceId As String = "7f769b7c-9143-424d-9a00-e5136b601fd4"
    Public Const EventsId As String = "a21d09f1-c395-416d-b32d-040251cfe8f0"
#End Region

    ' A creatable COM class must have a Public Sub New() 
    ' with no parameters, otherwise, the class will not be 
    ' registered in the COM registry and cannot be created 
    ' via CreateObject.
    Public Sub New()
        MyBase.New()

        Console.WriteLine("Join us now and share the software")
        Console.WriteLine("YOU'LL BE FREE HACKERS YOU'LL BE FREE")

    End Sub
    Public Function FREE()
        Return "Join us now and share the software YOU'LL BE FREE HACKERS YOU'LL BE FREE"

    End Function

End Class


