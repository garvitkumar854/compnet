' Question 24: What are dynamic arrays? Insert a new element at a specified position
Imports System

Module Program
    Sub Main(args As String())

        Dim arr() As Integer = {10, 20, 30, 40, 50}
        Dim pos As Integer = 2
        Dim newElement As Integer = 25

        ReDim Preserve arr(arr.Length)

        For i As Integer = arr.Length - 1 To pos + 1 Step -1
            arr(i) = arr(i - 1)
        Next

        arr(pos) = newElement

        Console.WriteLine("Updated Array:")
        For Each n As Integer In arr
            Console.Write(n & " ")
        Next

        Console.ReadLine()

    End Sub
End Module
