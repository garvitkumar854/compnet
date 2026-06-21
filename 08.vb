' Question 10: WAP of Assignment Operators in VB.NET
Imports System

Module Program
    Sub Main(args As String())

        Dim a As Integer = 10

        a += 5
        Console.WriteLine("After += 5 : " & a)

        a -= 3
        Console.WriteLine("After -= 3 : " & a)

        a *= 2
        Console.WriteLine("After *= 2 : " & a)

        a /= 4
        Console.WriteLine("After /= 4 : " & a)

        Console.ReadLine()

    End Sub
End Module
