Sub Main()
FileOpen(1, "d:TESTFILE.txt", OpenMode.Output)
WriteLine(1, 12, "Owais")
WriteLine(1, 13, "Ahmed")
FileClose(1)
Dim s As String
Dim i As Integer
FileOpen(1, "d:TESTFILE.txt", OpenMode.Input)
While Not EOF(1)
Input(1, i)
Input(1, s)
Console.WriteLine(i)
Console.WriteLine(s)
End While
FileClose(1)
Console.ReadKey()
End Sub
