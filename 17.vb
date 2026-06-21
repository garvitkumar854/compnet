' Question 19: Explain the FOR EACH NEXT statement used in VB.NET
Imports System

Module Program
    Sub Main(args As String())

        Dim numbers() As Integer = {10, 20, 30, 40, 50}

        For Each n As Integer In numbers
            Console.WriteLine(n)
        Next

        Console.ReadLine()

    End Sub
End Module
