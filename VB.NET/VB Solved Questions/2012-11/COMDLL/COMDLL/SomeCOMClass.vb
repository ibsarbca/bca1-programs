<ComClass(SomeCOMClass.ClassId, SomeCOMClass.InterfaceId, SomeCOMClass.EventsId)> _
Public Class SomeCOMClass

#Region "COM GUIDs"
    ' These  GUIDs provide the COM identity for this class 
    ' and its COM interfaces. If you change them, existing 
    ' clients will no longer be able to access the class.
    Public Const ClassId As String = "bdaac6ff-3604-48d9-be39-449c6c10e110"
    Public Const InterfaceId As String = "700b7880-5b55-4924-9c03-cda04a421551"
    Public Const EventsId As String = "567804d1-14fc-4303-bd18-21035af0a49a"
#End Region

    ' A creatable COM class must have a Public Sub New() 
    ' with no parameters, otherwise, the class will not be 
    ' registered in the COM registry and cannot be created 
    ' via CreateObject.
    Public Sub New()
        MyBase.New()
    End Sub

    Public Shared Function Add(ByVal x As Integer, ByVal y As Integer)
        Return x + y
    End Function

End Class


