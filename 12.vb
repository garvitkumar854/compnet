' Question 14: Explain the Nested IF statement used in VB.NET
Imports System

Module Program
    Sub Main(args As String())

        Dim username As String
        Dim password As String

        Console.Write("Enter Username: ")
        username = Console.ReadLine()

        Console.Write("Enter Password: ")
        password = Console.ReadLine()

        If username = "admin" Then
            If password = "1234" Then
                Console.WriteLine("Login Successful")
            Else
                Console.WriteLine("Wrong Password")
            End If
        Else
            Console.WriteLine("Wrong Username")
        End If

        Console.ReadLine()

    End Sub
End Module
