Imports System

Module Program
  Sub Main(args As String())
        Dim cislo As Integer
        Dim vypocet As Integer = 1
        Do
            Console.WriteLine("Zadej cel� ��slo: ")
            cislo = Console.ReadLine
            If cislo < 0 Then
                Console.WriteLine("Mus� zadat cel� kladn� ��slo")
            ElseIf cislo >= 10 Then
                Console.WriteLine("Mus� zadat ��slo men�� ne� 10")
            Else For i = 1 To cislo
                    vypocet = vypocet * i
                Next
                Console.WriteLine($"Faktori�l {cislo} je {vypocet}")
                Console.ReadKey()
            End If
        Loop


    End Sub
End Module
