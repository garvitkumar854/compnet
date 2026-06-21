' Question 5: Explain the type conversion functions in VB.NET
Imports System

Module Program
    Sub Main(args As String())

        Dim s As String = "25"
        Dim i As Integer = CInt(s)
        Dim d As Double = CDbl(s)
        Dim st As String = CStr(i)

        Console.WriteLine("CInt = " & i)
        Console.WriteLine("CDbl = " & d)
        Console.WriteLine("CStr = " & st)

        Console.ReadLine()

    End Sub
End Module
