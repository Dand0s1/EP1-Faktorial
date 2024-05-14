Imports System

Module Program
  Sub Main(args As String())
        Dim cislo As Integer
        Dim vypocet As Integer = 1

        Console.WriteLine("Zadej celé èíslo: ")
        cislo = Console.ReadLine
        If cislo < 0 Then
            Console.WriteLine("Musíš zadat celé kladné èíslo")
        Else For i = 1 To cislo
                vypocet = vypocet * i
            Next
            Console.WriteLine($"Faktoriál {cislo} je {vypocet}")
            Console.ReadKey()
        End If



    End Sub
End Module
