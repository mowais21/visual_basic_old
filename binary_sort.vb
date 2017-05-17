Sub Main()
Dim thisArr(10), Count As Integer
For Count = 1 To 10
Console.Write("Enter " & Count & " value: ")
thisArr(Count) = Console.ReadLine
Next
Bubblesort(thisArr, 10)
For Count = 1 To 10
Console.WriteLine(thisArr(Count))
Next
Console.ReadKey()
End Sub

Sub Bubblesort(ByVal Array() As Integer, ByVal Length As Integer)
Dim I, J, Temp As Integer
For I = Length To 1 Step -1
For J = 0 To I 
If Array(J) > Array(J + 1) Then 
Temp = Array(J)
Array(J) = Array(J + 1)
Array(J + 1) = Temp
End If
Next
Next
End Sub
