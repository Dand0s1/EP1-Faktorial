Imports System

Module Program
  Sub Main(args As String())
        Dim cislo As Integer
        Dim vypocet As Integer = 1

        Console.WriteLine("Zadej cel� ��slo: ")
        cislo = Console.ReadLine

        For i = 1 To cislo
            vypocet = vypocet * i
        Next
        Console.WriteLine($"Faktori�l {cislo} je {vypocet}")
        Console.ReadKey()
    End Sub
End Module
