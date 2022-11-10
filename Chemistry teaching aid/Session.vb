Public Class Session
    Private Elements As New List(Of Element) ' Stores all elements and its properties from the Elements.txt file

    Sub New() ' Constructor
        Me.LoadFile("C:\Users\fabih.FABIHAS-LAPTOP\Documents\School Work\Year 13\Computer Science\NEA\Elements.txt")
    End Sub

    Private Sub LoadFile(ByVal FilePath As String)

        ' Loads file with the properties of the elements into a list of elements
        ' Information in file is separated by commas

        Dim TempArray As String() ' Temporarily stores information from the file of each element

        FileOpen(1, FilePath, OpenMode.Input) ' Read from Elements.txt

        While Not EOF(1) ' Loop until the end of the file is reached
            TempArray = Split(LineInput(1), ",") ' Splits information at the commas 
            ' TempArray(0) stores the name of the element from the file
            ' TempArray(1) stores the symbol of the element from the file
            ' TempArray(2) stores the group number of the element from the file
            ' TempArray(3) stores the period number of the element from the file
            ' TempArray(4) stores whether the element is a metal
            ' TempArray(5) stores the mass number of the element from the file
            ' TempArray(5) stores the atomic number of the element from the file
            Elements.Add(New Element(TempArray(0), TempArray(1), TempArray(2), CInt(TempArray(3)), TempArray(4), CInt(TempArray(5)), CInt(TempArray(6)))) ' Adds elements from file into list of elements
        End While

        FileClose(1) ' Closes the file

    End Sub
    Public Function GetElements() As List(Of Element) ' Public getter for list of elements
        Return Me.Elements
    End Function
End Class

