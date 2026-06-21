' Question 17: Explain the DO LOOP statement used in VB.NET
Imports System

Module Program
    Sub Main(args As String())

        Dim i As Integer = 1

        Do
            Console.WriteLine("Value of i = " & i)
            i += 1
        Loop While i <= 5

        Console.ReadLine()

    End Sub
End Module
