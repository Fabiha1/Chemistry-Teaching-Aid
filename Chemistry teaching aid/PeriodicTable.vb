Public Class PeriodicTable
    Private WithEvents ThePeriodicTable As Panel ' Panel that hold the periodic table made up of ElementTiles
    Private Elements As List(Of Element) ' List of all the elements needed to draw the periodic table
    Sub New(ByVal Elements As List(Of Element))
        ThePeriodicTable = New Panel ' Instantiates new panel for the periodic table
        ThePeriodicTable.Size = PeriodicTableForm.Size ' Sets the size of ThePeriodicTable panel to the size of the form
        ThePeriodicTable.BackColor = Color.FromArgb(237, 242, 251) ' Changes the background colour of the panel
        Me.Elements = Elements ' Allows the Elements list to be accessed by the rest of the class

        ' Adds the different groups of elements onto the panel
        Me.DrawHydrogen()
        Me.DrawAlkaliMetals()
        Me.DrawAlkalineEarthMetals()
        Me.DrawTransitionMetals()
        Me.DrawBasicMetals()
        Me.DrawMetalloids()
        Me.DrawNonMetals()
        Me.DrawHalogens()
        Me.DrawNobleGases()
        Me.DrawLabels()

        PeriodicTableForm.Controls.Add(ThePeriodicTable) ' Adds panel to form

    End Sub
    ' Following procedures add element tiles to the Periodic table
    Private Sub DrawHydrogen()
        Dim TileColour As Color = Color.FromArgb(239, 121, 138) ' Colour of the element tile
        Dim Tile As ElementTile = New ElementTile(Elements(0), TileColour) ' Creates new ElementTile

        Tile.Location = New Point(590, 100) ' Sets the location of the ElementTile
        ThePeriodicTable.Controls.Add(Tile) ' Adds the tile to ThePeriodicTable panel

    End Sub
    Private Sub DrawAlkaliMetals()
        Dim TileColour As Color = Color.FromArgb(38, 70, 83) ' Colour of the element tile
        Dim Tile As ElementTile
        Dim Y As Integer = 0 ' Y co-ordinate
        Dim AlkaliPos = {2, 10, 18, 36, 54, 86} ' Position of alkali metals in the elements list

        For i = 0 To 5 ' Draws a row of elements 
            Tile = New ElementTile(Elements(AlkaliPos(i)), TileColour) ' Instantiates new element tile
            Tile.Location = New Point(50, 140 + Y) ' Sets the location of the tile
            Y += 90 ' Shifts the next tile down by 90
            ThePeriodicTable.Controls.Add(Tile) ' Adds Tile to the panel
        Next

    End Sub
    Private Sub DrawAlkalineEarthMetals()
        Dim TileColour As Color = Color.FromArgb(40, 114, 113) ' Colour of the element tile
        Dim Tile As ElementTile
        Dim Y As Integer = 0 ' Y co-ordinate
        Dim AlkaliEarthPos = {3, 11, 19, 37, 55, 87} ' Position of alkali earth metal in the elements list

        For i = 0 To 5 ' Draws a column of elements 
            Tile = New ElementTile(Elements(AlkaliEarthPos(i)), TileColour) ' Instantiates new element tile
            Tile.Location = New Point(140, 140 + Y) ' Sets the location of the tile
            Y += 90 ' Shifts the text tile down by 90
            ThePeriodicTable.Controls.Add(Tile) ' Adds Tile to the panel
        Next

    End Sub
    Private Sub DrawTransitionMetals()
        Dim TileColour As Color = Color.FromArgb(42, 157, 143) ' Colour of the element tile
        Dim Tile As ElementTile
        Dim Y As Integer = 0 ' X co-ordinate of the tile
        Dim X As Integer = 0 ' Y co-ordinate of the tile
        Dim TransitionPos = {20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 56, 71, 72, 73, 74, 75, 76, 77, 78, 79, 88, 103, 104, 105, 106, 107, 108, 109, 110, 111} ' Position of transition elements in the elements list

        For i = 0 To 3 ' Adds columns of tiles
            X = 230 ' Resets the X co-ordinate
            For j = 0 To 9 ' Adds row of tiles in the middle
                Tile = New ElementTile(Elements(TransitionPos(j + 10 * i)), TileColour) ' Instantiates new element tile
                Tile.Location = New Point(X, 320 + Y) ' Sets the location of the tile
                X += 90 ' Shifts the next tile across by 90
                ThePeriodicTable.Controls.Add(Tile) ' Adds Tile to the panel
            Next
            Y += 90 ' Shifts the next row of tiles down by 90
        Next

    End Sub
    Private Sub DrawBasicMetals()
        Dim TileColour As Color = Color.FromArgb(138, 177, 125) ' Colour of the element tile
        Dim Tile As ElementTile
        Dim Y As Integer = 0 ' Y co-ordinate
        Dim BasicPos = {12, 30, 48, 49, 80, 81, 82} ' Position of the basic metals in the elements list

        For i = 0 To 6
            Tile = New ElementTile(Elements(BasicPos(i)), TileColour) ' Instantiates new element tile
            Select Case i
                Case 0, 1, 2, 4
                    Tile.Location = New Point(1130, 230 + Y) ' Sets the location of the 1st, 2nd, 3rd and 5th tile
                    Y += 90
                Case 3
                    Tile.Location = New Point(1220, 410) ' Sets the location of the 4th tile
                Case 5
                    Tile.Location = New Point(1220, 500) ' Sets the location of the 6th tile
                Case 6
                    Tile.Location = New Point(1310, 500) ' Sets the location of the 7th tile
            End Select
            ThePeriodicTable.Controls.Add(Tile) ' Adds Tile to the panel
        Next
    End Sub
    Private Sub DrawMetalloids()
        Dim TileColour As Color = Color.FromArgb(233, 196, 106)
        Dim Tile As ElementTile
        Dim MetalloidPos = {4, 13, 31, 32, 50, 51, 83} ' Position of metalloid elements in the elements list

        For i = 0 To 6
            Tile = New ElementTile(Elements(MetalloidPos(i)), TileColour) ' Instantiates new element tile
            Select Case i
                Case 0
                    Tile.Location = New Point(1130, 140) ' Sets the location of the 1st tile
                Case 1
                    Tile.Location = New Point(1220, 230) ' Sets the location of the 2nd tile
                Case 2
                    Tile.Location = New Point(1220, 320) ' Sets the location of the 3rd tile
                Case 3
                    Tile.Location = New Point(1310, 320) ' Sets the location of the 4th tile
                Case 4
                    Tile.Location = New Point(1310, 410) ' Sets the location of the 5th tile
                Case 5
                    Tile.Location = New Point(1400, 410) ' Sets the location of the 6th tile
                Case 6
                    Tile.Location = New Point(1400, 500) ' Sets the location of the 7th tile
            End Select
            ThePeriodicTable.Controls.Add(Tile) ' Adds the tile onto the panel
        Next

    End Sub
    Private Sub DrawNonMetals()
        Dim TileColour As Color = Color.FromArgb(244, 162, 97) ' Colour of the element tile
        Dim Tile As ElementTile
        Dim Y As Integer = 0 ' Y co-ordinate of tile
        Dim NonMetalPos = {5, 6, 7, 14, 15, 33} ' Position of element in the elements list

        For i = 0 To 5 ' Loop to 8 when file finished
            Tile = New ElementTile(Elements(NonMetalPos(i)), TileColour) ' Instantiates new element tile
            Select Case i
                Case 0
                    Tile.Location = New Point(1220, 140) ' Sets the location of the 1st tile
                Case 1
                    Tile.Location = New Point(1310, 140) ' Sets the location of the 2nd tile
                Case 2
                    Tile.Location = New Point(1400, 140) ' Sets the location of the 3rd tile
                Case 3
                    Tile.Location = New Point(1310, 230) ' Sets the location of the 4th tile
                Case 4
                    Tile.Location = New Point(1400, 230) ' Sets the location of the 5th tile
                Case 5
                    Tile.Location = New Point(1400, 320) ' Sets the location of the 6th tile
            End Select
            ThePeriodicTable.Controls.Add(Tile) ' Adds Tile to the panel
        Next
    End Sub
    Private Sub DrawHalogens()

        Dim TileColour As Color = Color.FromArgb(238, 137, 89) ' Colour of the element tile
        Dim Tile As ElementTile
        Dim Y As Integer = 0 ' Y co-ordinate
        Dim HalogenPos = {8, 16, 34, 52, 84} ' Position of element in the elements list

        For i = 0 To 4 ' Draws row of elements
            Tile = New ElementTile(Elements(HalogenPos(i)), TileColour) ' Instantiates new element tile
            Tile.Location = New Point(1490, 140 + Y) ' Sets the location of the tile
            Y += 90 ' Shifts next tile down by 90
            ThePeriodicTable.Controls.Add(Tile) ' Adds Tile to the panel
        Next

    End Sub
    Private Sub DrawNobleGases()

        Dim TileColour As Color = Color.FromArgb(231, 111, 81)
        Dim Tile As ElementTile
        Dim Y As Integer = 0 ' Y co-ordinate
        Dim NobelGases = {1, 9, 17, 35, 53, 85} ' Position of element in the elements list

        For i = 0 To 5 ' Loop to 6 when file finished
            Tile = New ElementTile(Elements(NobelGases(i)), TileColour) ' Instantiates new element tile
            Tile.Location = New Point(1580, 50 + Y) ' Sets the location of the tile
            Y += 90 ' Shifts next tile down by 90
            ThePeriodicTable.Controls.Add(Tile) ' Adds Tile to the panel
        Next

    End Sub
    Private Sub DrawLabels()
        ' Procedure draws the labels for group number, period number and title onto the periodic table
        Dim X As Integer = 10 ' X co-ordinate of TempText
        Dim Y As Integer = 70 ' Y co-ordinate of TempText
        Dim TempText As New Label ' Temporary label 

        ' Draws period numbers 1 to 7 vertically downwards
        For i = 1 To 7
            TempText = New Label ' Instantiates Label
            TempText.SetBounds(X, Y, 30, 70) ' Sets the size and location of the label
            TempText.Text = i.ToString ' Converts loop count to a string so can be written to a label
            TempText.BackColor = Color.Transparent ' Sets the background colour of the label
            TempText.Font = New Font("Nirmala UI", 20, FontStyle.Bold) ' Sets the font and font size of the text
            ThePeriodicTable.Controls.Add(TempText) ' Adds the period numbers to the panel
            Y += 90
        Next

        ' Resets X and Y co-ordinate
        X = 70
        Y = 10

        ' Draws group numbers 1 to 8 horizontally across
        For i = 1 To 8
            TempText = New Label ' Instantiates Label
            TempText.SetBounds(X, Y, 30, 70) ' Sets the size and location of the label
            TempText.Text = i.ToString ' Converts loop count to a string so can be written to a label
            TempText.BackColor = Color.Transparent ' Sets the background colour of the label
            TempText.Font = New Font("Nirmala UI", 20, FontStyle.Bold) ' Sets the font and font size of the text
            ThePeriodicTable.Controls.Add(TempText) ' Adds the group numbers onto the panel

            If i = 2 Then ' Makes sure labels skip transition metals (block in the middle)
                X = 1060
            End If

            X += 90 ' Shifts the next label across by 90
        Next

        TempText = New Label ' Draws title
        TempText.SetBounds(0, 0, ThePeriodicTable.Width, 100) ' Sets the size and location of the label
        TempText.Text = "The Periodic Table"
        TempText.TextAlign = ContentAlignment.MiddleCenter ' Centers the title on the middle of form
        TempText.BackColor = Color.Transparent ' Sets the background colour of the label
        TempText.Font = New Font("Nirmala UI", 40, FontStyle.Bold) ' Sets the font and font size of the text
        ThePeriodicTable.Controls.Add(TempText) ' Adds the title onto the panel

    End Sub
End Class
