Structure myStu
Dim ERP As Integer
<VBFixedString(20)> Dim stuNme As String
<VBFixedString(4)> Dim stuClass As String
Dim stuFee As Decimal
Dim IsFeePaid As Boolean
End Structure
Dim dummy As myStu
Dim records As Integer
Dim clcount As Integer
Sub Main()
Call Menu()
End Sub

Sub Menu()
Dim choice As Integer
Do
Console.Write("Enter 1 to Write, 2 to Read, 3 to Append, 4 to Delete, 0 to Exit: ")
choice = Console.ReadLine
Select Case choice
Case 1 : Call Write()
Case 2 : Call Read()
Case 3 : Call Append()
Case 4 : Call Delete()
Case 0
End Select
Loop Until choice = 0
Console.Clear()
End Sub

Sub Write()
Console.Clear()
FileOpen(1, "d:StudentFile.rdm", OpenMode.Random, OpenAccess.ReadWrite, , Len(dummy))
Dim Stu As myStu
Console.Write("Enter the number of students in class: ")
clcount = Console.ReadLine
For count = 1 To clcount
Stu.ERP = count
Console.Write("Enter student's name: ")
Stu.stuNme = Console.ReadLine
Console.Write("Enter student's class: ")
Stu.stuClass = Console.ReadLine
Console.Write("Enter student's fee: ")
Stu.stuFee = Console.ReadLine
Console.Write("Is fee paid? Y/N: ")
If Console.ReadLine = "Y" Then
Stu.IsFeePaid = True
Else : Stu.IsFeePaid = False
End If
FilePut(1, Stu, count)
Next
FileClose(1)
Console.Clear()
End Sub

Sub Read()
Console.Clear()
FileOpen(1, "d:StudentFile.rdm", OpenMode.Random, OpenAccess.ReadWrite, , Len(dummy))
records = (LOF(1) / Len(dummy))
Dim Stu As myStu
For count = 1 To records
FileGet(1, Stu, count)
Console.WriteLine("Roll Number: " & Stu.ERP)
Console.WriteLine("Name: " & Stu.stuNme)
Console.WriteLine("Class: " & Stu.stuClass)
Console.WriteLine("Fee: " & Stu.stuFee)
Console.WriteLine("Is Fee Paid?: " & Stu.IsFeePaid)
Console.WriteLine()
Next
FileClose(1)
End Sub

Sub Append()
Console.Clear()
FileOpen(1, "d:StudentFile.rdm", OpenMode.Random, OpenAccess.ReadWrite, , Len(dummy))
records = (LOF(1) / Len(dummy))
Dim Stu As myStu
Console.Write("How many more students?: ")
clcount = Console.ReadLine
For count = records + 1 To records + clcount
Stu.ERP = count
Console.Write("Enter student's name: ")
Stu.stuNme = Console.ReadLine
Console.Write("Enter student's class: ")
Stu.stuClass = Console.ReadLine
Console.Write("Enter student's fee: ")
Stu.stuFee = Console.ReadLine
Console.Write("Is fee paid? Y/N: ")
If Console.ReadLine = "Y" Then
Stu.IsFeePaid = True
Else : Stu.IsFeePaid = False
End If
FilePut(1, Stu, count)
Next
FileClose(1)
Console.Clear()
End Sub

Sub Delete()
Console.Clear()
My.Computer.FileSystem.DeleteFile("d:StudentFile.rdm")

Console.Clear()
End Sub
