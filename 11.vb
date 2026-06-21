' Question 13: Explain the IF THEN ELSE statement used in VB.NET
Imports System

Module Program
    Sub Main(args As String())

        Dim num As Integer

        Console.Write("Enter a number: ")
        num = CInt(Console.ReadLine())

        If num Mod 2 = 0 Then
            Console.WriteLine("Even Number")
        Else
            Console.WriteLine("Odd Number")
        End If

        Console.ReadLine()

    End Sub
End Module
