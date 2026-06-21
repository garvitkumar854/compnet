' Question 21: Explain the WITH END WITH statement used in VB.NET
Imports System

Module Program

    Class Student
        Public Property Name As String
        Public Property Age As Integer
    End Class

    Sub Main(args As String())

        Dim s As New Student()

        With s
            .Name = "Garvit"
            .Age = 20
        End With

        Console.WriteLine("Name: " & s.Name)
        Console.WriteLine("Age: " & s.Age)

        Console.ReadLine()

    End Sub
End Module
