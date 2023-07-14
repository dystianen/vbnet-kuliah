Imports System

Module Program
    Sub Main(args As String())
        Dim hari(6) As String
        hari(0) = "Senin"
        hari(1) = "Selasa"
        hari(2) = "Rabu"
        hari(3) = "Kamis"
        hari(4) = "Jumat"
        hari(5) = "Sabtu"
        hari(6) = "Minggu"
        Console.WriteLine("isi nilai array hari indeks 0 adalah = " & hari(0))
        Console.WriteLine("isi nilai array hari indeks 3 adalah = " & hari(3))
        Console.WriteLine("isi nilai array hari indeks 6 adalah = " & hari(6))
        Console.ReadLine()
    End Sub
End Module
