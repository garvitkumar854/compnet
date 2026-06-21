' Question 25: What are sub procedures? Difference between passing parameter by value and by reference
Imports System

Module Program

    Sub ChangeByValue(ByVal x As Integer)
        x = 100
    End Sub

    Sub ChangeByReference(ByRef x As Integer)
        x = 100
    End Sub

    Sub Main(args As String())

        Dim num1 As Integer = 10
        Dim num2 As Integer = 10

        ChangeByValue(num1)
        ChangeByReference(num2)

        Console.WriteLine("ByVal Result = " & num1)
        Console.WriteLine("ByRef Result = " & num2)

        Console.ReadLine()

    End Sub
End Module
