' Question 16: Explain the Nested Select Case statements used in VB.NET
Imports System

Module Program
    Sub Main(args As String())

        Dim category As Integer
        Dim item As Integer

        Console.Write("Enter Category (1=Food, 2=Drink): ")
        category = CInt(Console.ReadLine())

        Select Case category

            Case 1
                Console.Write("Enter Item (1=Pizza, 2=Burger): ")
                item = CInt(Console.ReadLine())

                Select Case item
                    Case 1
                        Console.WriteLine("Pizza Selected")
                    Case 2
                        Console.WriteLine("Burger Selected")
                    Case Else
                        Console.WriteLine("Invalid Food Item")
                End Select

            Case 2
                Console.Write("Enter Item (1=Tea, 2=Coffee): ")
                item = CInt(Console.ReadLine())

                Select Case item
                    Case 1
                        Console.WriteLine("Tea Selected")
                    Case 2
                        Console.WriteLine("Coffee Selected")
                    Case Else
                        Console.WriteLine("Invalid Drink Item")
                End Select

            Case Else
                Console.WriteLine("Invalid Category")

        End Select

        Console.ReadLine()

    End Sub
End Module
