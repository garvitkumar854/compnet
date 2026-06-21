' Question 23: What are arrays in VB.NET explain the type of arrays?
Imports System

Module Program
    Sub Main(args As String())

        Dim singleArr() As Integer = {10, 20, 30}
        Console.WriteLine("Single Dimensional Array:")
        For Each n As Integer In singleArr
            Console.Write(n & " ")
        Next
        Console.WriteLine()

        Dim multi(1, 1) As Integer
        multi(0, 0) = 10
        multi(0, 1) = 20
        multi(1, 0) = 30
        multi(1, 1) = 40

        Console.WriteLine("Multidimensional Array:")
        For i As Integer = 0 To 1
            For j As Integer = 0 To 1
                Console.Write(multi(i, j) & " ")
            Next
            Console.WriteLine()
        Next

        Dim jagged()() As Integer = {
            New Integer() {1, 2},
            New Integer() {3, 4, 5}
        }

        Console.WriteLine("Jagged Array:")
        For Each row As Integer() In jagged
            For Each value As Integer In row
                Console.Write(value & " ")
            Next
            Console.WriteLine()
        Next

        Dim dyn() As Integer
        ReDim dyn(2)
        dyn(0) = 100
        dyn(1) = 200
        dyn(2) = 300

        Console.WriteLine("Dynamic Array:")
        For Each n As Integer In dyn
            Console.Write(n & " ")
        Next
        Console.WriteLine()

        Console.ReadLine()

    End Sub
End Module
