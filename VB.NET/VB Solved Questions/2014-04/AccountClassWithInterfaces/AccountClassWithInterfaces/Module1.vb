Module Module1

    Interface IAccountable
        Sub updateAccountBalance(ByVal accountno As Integer, ByVal balance As Single)
        Sub printAccountBalance(ByVal accountno As Integer)
    End Interface

    Public Class Account
        Implements IAccountable

        Dim accountno As Integer
        Dim name As String
        Dim balance As Single

        Public Sub New(ByVal ano As Integer, ByVal n As String)
            accountno = ano
            name = n
            balance = 500.0F
        End Sub

        Public Sub New(ByVal ano As Integer, ByVal n As String, ByVal bal As Single)
            accountno = ano
            name = n
            balance = bal
        End Sub

        Public Sub printAccountBalance(accountno As Integer) Implements IAccountable.printAccountBalance
            Console.WriteLine("Account No: {0}", accountno)
            Console.WriteLine("Name: {0}", name)
            Console.WriteLine("Balance: {0}", balance)
        End Sub

        Public Sub updateAccountBalance(ByVal accountno As Integer, ByVal bal As Single) Implements IAccountable.updateAccountBalance
            Me.balance = bal
        End Sub
    End Class

    Sub Main()
        Dim acct1 = New Account(1, "Dhaval")
        acct1.printAccountBalance(1)
        Console.Read()
    End Sub

End Module
