' Question 20: Explain the WHILE loop statement used in VB.NET
Imports System

Module Program
    Sub Main(args As String())

        Dim i As Integer = 1

        While i <= 5
            Console.WriteLine("Value of i = " & i)
            i += 1
        End While

        Console.ReadLine()

    End Sub
End Module
