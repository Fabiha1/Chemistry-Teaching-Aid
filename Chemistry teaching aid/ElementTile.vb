Public Class ElementTile
    ' Creates the tile for each element on the periodic table and writes information to a form when clicked on
    Inherits Panel ' ElementTile is a panel
    Private WithEvents TempText As New Label ' Stores the symbol for the tile
    Private Element As Element ' Stores the element of the element tile
    Private ElementInfoForm As New Form ' New form containing information about element is created when a tile is clicked on
    Public Sub New(ByVal TheElement As Element, ByVal BackColour As Color)

        Element = TheElement ' Allows TheElement to be accessed by the rest of the class
        Dim TheAtom As New Atom(TheElement) ' Instantiates atom to add to ElementInfoForm
        TheAtom.Location = New Point(190, 120)

        Me.Size = New Size(80, 80) ' Sets the size of the element tile
        Me.BackColor = BackColour ' Sets colour of tile

        ElementInfoForm.Size = New Size(800, 800) ' Sets size of form
        ElementInfoForm.BackColor = Color.White ' Sets the background color of the form

        Me.WriteSymbol()
        Me.WriteInfoToForm()

        ElementInfoForm.Controls.Add(TheAtom) ' Adds the atom of the element to the form

    End Sub
    Private Sub WriteInfoToForm()
        Dim TempText As New Label ' Stores the text to be written to the form
        Dim IsNonMetal As String ' Stores 'Metal' or 'Non-Metal'

        ' Makes Element.GetIsMetal into a user friendly string
        If Element.GetIsMetal = True Then ' If element is a metal, IsNonMetal is set to 'Metal'
            IsNonMetal = "Metal"
        Else  ' If element is a non-metal, IsNonMetal is set to 'Non-Metal'
            IsNonMetal = "Non-metal"
        End If

        ' Writes the name of the element to the form
        TempText.SetBounds(0, 0, 800, 100) ' Sets the size and location of the label
        TempText.TextAlign = ContentAlignment.MiddleCenter ' Aligns the text on the middle of the form
        TempText.Font = New Font("Nirmala UI", 40, FontStyle.Bold) ' Sets the font and font size of the text
        TempText.Text = Element.GetName ' Sets label to the element's name
        ElementInfoForm.Controls.Add(TempText) ' Adds text to the form

        ' Writes the symbol of the element to the form
        TempText = New Label ' Instantiates a new label
        TempText.Text = Element.GetSymbol ' Sets label to the element's symbol
        TempText.Font = New Font("Nirmala UI", 30, FontStyle.Bold) ' Sets the font and font size of the text
        TempText.TextAlign = ContentAlignment.MiddleCenter ' Aligns the text on the middle of the form
        TempText.SetBounds(0, 80, 800, 50) ' Sets the size and location of the label
        ElementInfoForm.Controls.Add(TempText) ' Adds text to the form
        TempText.BringToFront()

        ' Writes other information to form
        TempText = New Label ' Instantiates a new label
        TempText.Text = "Mass number: " & Element.GetMassNo & vbCrLf & _
                        "Atomic number: " & Element.GetAtomicNo & vbCrLf & vbCrLf & _
                        "Number of protons: " & Element.GetAtomicNo & vbCrLf & _
                        "Number of neutrons: " & Element.GetMassNo - Element.GetAtomicNo & vbCrLf & _
                        "Number of electrons: " & Element.GetAtomicNo & vbCrLf & _
                        IsNonMetal
        TempText.SetBounds(0, 500, 800, 800) ' Sets the size and location of the label
        TempText.Font = New Font("Nirmala UI", 15, FontStyle.Bold) ' Sets the font and font size of the text
        TempText.TextAlign = ContentAlignment.TopCenter ' Aligns the text to the top center of the label
        ElementInfoForm.Controls.Add(TempText) ' Adds text to the form

    End Sub
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs) ' Draws outline around the tile
        MyBase.OnPaint(e)
        Dim TempPen As New Pen(Color.Black) ' Sets the colour of the outline to black

        TempPen.Width = 5 ' Changes the width of the outline
        e.Graphics.DrawRectangle(TempPen, 2, 2, Me.Width - 5, Me.Height - 5) ' Sets the size and the position of the outline

    End Sub
    Private Sub WriteSymbol() ' Write the symbol of the element to the element tile

        TempText.SetBounds(20, 30, 80, 100)  ' Sets the size and location of the label
        TempText.BackColor = Color.Transparent
        TempText.Text = Element.GetSymbol ' Sets the text of the label to the element's symbol
        TempText.Font = New Font("Nirmala UI", 20, FontStyle.Bold) ' Sets the font and font size of the text

        Me.Controls.Add(TempText) ' Adds the label to the panel, ElementTile

    End Sub
    ' Opens ElementInfoForm when the text is clicked
    Protected Sub TileClick() Handles TempText.Click
        ElementInfoForm.Show()
    End Sub
    ' Opens ElementInfoForm when the tile is clicked
    Protected Sub TileClick2() Handles Me.Click
        ElementInfoForm.Show()
    End Sub

End Class
