' Question 11: WAP of Concatenation Operators in VB.NET
Imports System

Module Program
    Sub Main(args As String())

        Dim firstName As String = "Garvit"
        Dim lastName As String = "Kumar"

        Console.WriteLine("Full Name = " & firstName & " " & lastName)
        Console.WriteLine("Using + operator = " + firstName + " " + lastName)

        Console.ReadLine()

    End Sub
End Module
