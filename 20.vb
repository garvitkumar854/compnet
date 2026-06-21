' Question 22: Explain the NESTED LOOP statement used in VB.NET
Imports System

Module Program
    Sub Main(args As String())

        For i As Integer = 1 To 3
            For j As Integer = 1 To 3
                Console.Write(j & " ")
            Next
            Console.WriteLine()
        Next

        Console.ReadLine()

    End Sub
End Module
