Structure Record
Dim Name As String
Dim Pointer As Integer
End Structure
Dim FreePointer As Integer
Dim NewNodePointer As Integer
Dim HeadPointer As Integer
Dim CurrentPointer As Integer
Dim PreviousPointer As Integer
Dim NewName As String
Dim TBD As String
Dim NameList(50) As Record

Sub Main()
Call Menu()
Console.ReadKey()
End Sub
Sub Menu()
Dim choice As Integer
Do
Console.Write("Enter choice: ")
choice = Console.ReadLine
If choice = 1 Then Call CreateLinkedList()
If choice = 2 Then Call AddName()
If choice = 3 Then Call RemoveName()
If choice = 4 Then Call PrintList()
Loop Until choice = 5
End Sub

Sub CreateLinkedList()
For count = 1 To 49
NameList(count).Name = " "
NameList(count).Pointer = count + 1
Next
HeadPointer = 0
FreePointer = 1
End Sub

Sub AddName()
Console.Write("Enter a name: ")
NewName = Console.ReadLine
NameList(FreePointer).Name = NewName
NewNodePointer = FreePointer
FreePointer = NameList(FreePointer).Pointer
CurrentPointer = HeadPointer
If HeadPointer > 0 Then
While NameList(CurrentPointer).Name < NewName
PreviousPointer = CurrentPointer
CurrentPointer = NameList(CurrentPointer).Pointer
End While
End If
If CurrentPointer = HeadPointer Then
NameList(NewNodePointer).Pointer = HeadPointer
HeadPointer = NewNodePointer
Else
NameList(NewNodePointer).Pointer = NameList(PreviousPointer).Pointer
NameList(PreviousPointer).Pointer = NewNodePointer
End If
Console.ReadKey()

End Sub
Sub RemoveName()
Console.Write("Enter a name: ")
TBD = Console.ReadLine
If HeadPointer > 0 Then
For count = 1 To 50
If NameList(count).Name = TBD Then
CurrentPointer = count
End If
Next
If CurrentPointer = HeadPointer Then
HeadPointer = NameList(CurrentPointer).Pointer
Else
NameList(PreviousPointer).Pointer = NameList(CurrentPointer).Pointer
End If
NameList(CurrentPointer).Pointer = FreePointer
End If
Console.ReadKey()
End Sub

Sub PrintList()
For count = 1 To 50
Console.WriteLine(NameList(count).Name & " , " & NameList(count).Pointer)
Next
Console.ReadKey()
End Sub
