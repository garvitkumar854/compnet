' Question 8: WAP of Logical / Bitwise Operators in VB.NET
Imports System

Module Program
    Sub Main(args As String())

        Dim a As Boolean = True
        Dim b As Boolean = False

        Console.WriteLine("And = " & (a And b))
        Console.WriteLine("Or = " & (a Or b))
        Console.WriteLine("Not a = " & (Not a))
        Console.WriteLine("Xor = " & (a Xor b))

        Console.ReadLine()

    End Sub
End Module
