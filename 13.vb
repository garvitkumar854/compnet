' Question 15: Explain the SELECT CASE statement used in VB.NET
Imports System

Module Program
    Sub Main(args As String())

        Dim day As Integer

        Console.Write("Enter day number: ")
        day = CInt(Console.ReadLine())

        Select Case day
            Case 1
                Console.WriteLine("Monday")
            Case 2
                Console.WriteLine("Tuesday")
            Case 3
                Console.WriteLine("Wednesday")
            Case Else
                Console.WriteLine("Invalid Day")
        End Select

        Console.ReadLine()

    End Sub
End Module
