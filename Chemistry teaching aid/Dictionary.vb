Public Class Dictionary
    Structure DictionaryStructure
        Public Term As String ' Stores the terms in the dictionary e.g. Element, Atom, Group Number
        Public Definition As String ' Stores the defintion of the term in the dictionary
    End Structure
    Private WordDictionary() As DictionaryStructure ' Unsorted dictionary. Items are ordered in the way they appear in the Dictionary.txt file
    Private SortedDictionary() As DictionaryStructure ' Dictionary where items are sorted by term
    Private IsSorted As Boolean ' Tracks which constructor is called. Set to true if 'Alphabetical' is selected
    ' Overloading
    Public Sub New() ' Constructor for unsorted (standard) dictionary
        IsSorted = False ' Set to false as unsorted dictionary is wanted
        Me.LoadFile("C:\Users\fabih.FABIHAS-LAPTOP\Documents\School Work\Year 13\Computer Science\NEA\Dictionary.txt")
        Me.FillTable()
    End Sub
    Public Sub New(ByVal IsSorted As Boolean) ' Constructor for sorted dictionary
        IsSorted = True ' Set to true as sorted dictionary is wanted
        Me.LoadFile("C:\Users\fabih.FABIHAS-LAPTOP\Documents\School Work\Year 13\Computer Science\NEA\Dictionary.txt")
        Me.MergeSortDictionary(SortedDictionary, 0, 21) ' Merge sorts dictionary 
        Me.FillTable()
    End Sub
    Private Sub LoadFile(ByVal FilePath As String) ' Loads Dictionary file into dictionary array

        Dim TempArray As String() ' For each line in the file, temporarily stores the term and definition
        Dim Counter As Integer ' Keeps track of which line of the file 

        FileOpen(1, FilePath, OpenMode.Input)

        While Not EOF(1) ' Loops until the end of the file is reached
            TempArray = Split(LineInput(1), ";") ' Splits information at the commas 
            ' Term is stored the TempArray index 0
            ' Definition is stored in the TempArray index 1
            ReDim Preserve WordDictionary(Counter) ' Resizes array
            ' Adds information into WordDictionary array
            WordDictionary(Counter).Term = TempArray(0)
            WordDictionary(Counter).Definition = TempArray(1)
            Counter += 1 ' Increments counter to get ready for the next line
        End While

        SortedDictionary = WordDictionary ' Intially SortedDictionary is the same as WordDictionary
        ' SortedDictionary will then undergo a merge sort

        FileClose(1) ' Close the file

    End Sub
    Private Sub FillTable()

        DictionaryForm.DataGridView1.Rows.Clear()

        If IsSorted = True Then ' If the constructor for sorted dictionary is called
            ' Fill table with data in alphabetical order
            For i = 0 To SortedDictionary.Length - 1 ' Loop until all the items in SortedDictionary are added
                DictionaryForm.DataGridView1.Rows.Add() ' Add a row to the data grid

                DictionaryForm.DataGridView1.Item(0, i).Value = SortedDictionary(i).Term ' Adds the terms to the first column
                DictionaryForm.DataGridView1.Item(1, i).Value = SortedDictionary(i).Definition ' Adds the definitions to the second column
            Next
        Else ' If constructor for unsorted dictionary is called
            ' Fills table with data in the order presented in the file 
            For i = 0 To WordDictionary.Length - 1 ' Loop until all the items in WordDictionary are added
                DictionaryForm.DataGridView1.Rows.Add() ' Add a row to the data grid

                DictionaryForm.DataGridView1.Item(0, i).Value = WordDictionary(i).Term ' Adds the terms to the first column
                DictionaryForm.DataGridView1.Item(1, i).Value = WordDictionary(i).Definition ' Adds the definitions to the second column
            Next
        End If

    End Sub
    ' Merge sort on dictionary
    Private Sub MergeSortDictionary(ByRef SortedDictionary() As DictionaryStructure, Left As Integer, Right As Integer)

        If Left < Right Then
            Dim Mid As Integer = (Left + Right) \ 2 ' Finds the mid point
            ' Recursion
            MergeSortDictionary(SortedDictionary, Left, Mid) ' Splits left array
            MergeSortDictionary(SortedDictionary, Mid + 1, Right) ' Splits right array
            ' Keeps recursively splitting the two array until they are single elements
            MergeDictionary(SortedDictionary, Left, Mid, Right) ' Merges and sorts
        End If

    End Sub
    Private Sub MergeDictionary(ByRef SortedDictionary() As DictionaryStructure, Left As Integer, Mid As Integer, Right As Integer)

        Dim SizeA As Integer = Mid - Left + 1
        Dim SizeB As Integer = Right - Mid
        Dim LeftArray(SizeA) As DictionaryStructure ' Sets size of left array
        Dim RightArray(SizeB) As DictionaryStructure ' Sets size of right array
        Dim LP As Integer ' Left pointer
        Dim RP As Integer ' Right pointer
        ' Pointers are used to keep track to the elements in the array

        For LP = 0 To SizeA - 1
            LeftArray(LP) = SortedDictionary(Left + LP) ' Assign 0 index of original array to left hand array 
        Next

        For RP = 0 To SizeB - 1
            RightArray(RP) = SortedDictionary(Mid + 1 + RP) ' Assign 1 index of original array to right hand array 
        Next

        ' Reset pointers
        LP = 0
        RP = 0
        Dim i = Left ' Set a pointer for the original array

        ' Swap elements if need be:
        While LP < SizeA And RP < SizeB
            If LeftArray(LP).Term <= RightArray(RP).Term Then ' If element in left array is smaller that the one in the right
                SortedDictionary(i) = LeftArray(LP) ' Assign the left value to the original array
                LP += 1 ' Increment the left array's pointer
            Else
                SortedDictionary(i) = RightArray(RP) ' Otherwise the original array gets the right element
                RP += 1 ' Increment the right array's pointer
            End If
            i += 1 ' Increment the counter for our new array
        End While

        ' If there are still elements in the left array
        While LP < SizeA
            SortedDictionary(i) = LeftArray(LP) ' Assign these elements to the new array
            LP += 1 ' Increment the left pointer
            i += 1 ' Increment the new array's pointer
        End While

        ' What if there are still elements in the right array
        While RP < SizeB
            SortedDictionary(i) = RightArray(RP) ' Assign these elements to the new array
            RP += 1 ' Increment the right pointer
            i += 1 ' Increment the new array's pointer
        End While

    End Sub
    Public Sub SearchDictionary(ByVal Word As String) ' Word entered by the user is passed in

        ' Linear search on items in WordDictionary
        For Each Item In WordDictionary ' Loops through each item in WordDictionary
            If Item.Term.ToUpper = Word.ToUpper Then ' Compares user entered word with word in dictionary
                ' If is a match, data grid is cleared and shows only that term
                DictionaryForm.DataGridView1.Rows.Clear() ' Clears data grid
                DictionaryForm.DataGridView1.Rows.Add() ' Adds a new row

                DictionaryForm.DataGridView1.Item(0, 0).Value = Item.Term ' Adds term to the first column
                DictionaryForm.DataGridView1.Item(1, 0).Value = Item.Definition ' Adds definition to the second column
            End If
        Next

    End Sub
End Class
