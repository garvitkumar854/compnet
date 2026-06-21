' Question 7: WAP of Comparison Operators in VB.NET
Imports System

Module Program
    Sub Main(args As String())

        Dim a As Integer = 10
        Dim b As Integer = 20

        Console.WriteLine("a = b : " & (a = b))
        Console.WriteLine("a <> b : " & (a <> b))
        Console.WriteLine("a > b : " & (a > b))
        Console.WriteLine("a < b : " & (a < b))
        Console.WriteLine("a >= b : " & (a >= b))
        Console.WriteLine("a <= b : " & (a <= b))

        Console.ReadLine()

    End Sub
End Module
