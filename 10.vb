' Question 12: Explain the IF THEN statement used in VB.NET
Imports System

Module Program
    Sub Main(args As String())

        Dim age As Integer

        Console.Write("Enter your age: ")
        age = CInt(Console.ReadLine())

        If age >= 18 Then
            Console.WriteLine("You are eligible to vote")
        End If

        Console.ReadLine()

    End Sub
End Module
