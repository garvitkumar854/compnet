' Question 9: WAP of Bit Shift Operators in VB.NET
Imports System

Module Program
    Sub Main(args As String())

        Dim num As Integer = 8

        Console.WriteLine("Original = " & num)
        Console.WriteLine("Left Shift (num << 1) = " & (num << 1))
        Console.WriteLine("Right Shift (num >> 1) = " & (num >> 1))

        Console.ReadLine()

    End Sub
End Module
