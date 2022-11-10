Public Class Bonding
    Private TempPanel As Panel ' Temporary panel that holds the bonding
    Public Sub New()

        TempPanel = New Panel ' Instantiates new panel
        TempPanel.SetBounds(0, 0, BondingForm.Width, BondingForm.Height) ' Sets the position and the size of the panel to the size of the form
        BondingForm.Controls.Add(TempPanel) ' Adds the panel to the form

    End Sub
    Public Sub IonicBonding(ByVal Metal As Element,
                            ByVal NonMetal As Element) ' A metal and non-metal element are passed in

        Dim MetalAtom As Atom
        Dim NonMetalAtom As Atom
        Dim MetalIon As Atom
        Dim NonMetalIon As Atom
        Dim MetalCharge As String = Metal.GetGroupNo
        Dim NonMetalCharge As String = (8 - NonMetal.GetGroupNo)

        If NonMetal.GetSymbol = "H" Then ' Charge of Hydrogen does not follow same rules
            NonMetalCharge = "1" ' Charge set to 1
        End If

        ' If charge is 1, number does not appear in compound
        ' e.g. Na1H1 is actually NaH
        If NonMetalCharge = 1 Then
            NonMetalCharge = "" ' Charge is set to nothing
        End If
        If MetalCharge = 1 Then
            MetalCharge = "" ' Charge is set to nothing
        End If

        MetalAtom = New Atom(Metal) ' Instantiates a new atom 
        NonMetalAtom = New Atom(NonMetal) ' Instantiates a new atom
        MetalAtom.SetBounds(0, 70, 500, 500) ' Sets the size and the position of the metal atom
        NonMetalAtom.SetBounds(600, 70, 500, 500) ' Sets the size and the position of the non-metal atom
        TempPanel.Controls.Add(MetalAtom) ' Adds the metal atom onto the panel
        TempPanel.Controls.Add(NonMetalAtom) ' Adds the non-metal atom onto the panel

        Threading.Thread.Sleep(1000) ' Pauses the program for 1 second
        MsgBox("")

        MetalIon = New Atom(Metal, True) ' Instantiates a new atom but uses the ion constructor
        NonMetalIon = New Atom(NonMetal, True) ' Instantiates a new atom but uses the ion constructor
        MetalIon.SetBounds(0, 70, 500, 500) ' Sets the size and location of the metal ion
        NonMetalIon.SetBounds(600, 70, 500, 500) ' Sets the size and location of the non-metal ion
        TempPanel.Controls.Add(MetalIon) ' Adds the metal ion onto the panel
        TempPanel.Controls.Add(NonMetalIon) ' Adds the non-metal ion onto the panel

        MetalIon.BringToFront()
        NonMetalIon.BringToFront()

        Dim CompoundLabel As New Label ' Creates new label
        CompoundLabel.SetBounds(0, 0, BondingForm.Width, 40) ' Sets the size and location of the label
        CompoundLabel.Font = New Font("Nirmala UI", 25, FontStyle.Bold) ' Sets the font and font size of the text
        ' To calculate the formula of a compound you need the charge of the metal and non-metal
        ' The charge of the metal = the number of non-metal ions
        ' Therefore, the charge of the non-metal = the number of metal ions
        ' e.g. If you have Al 3+ and O 2-, the formula of the compound will be Al2O3
        CompoundLabel.Text = Metal.GetSymbol & NonMetalCharge & NonMetal.GetSymbol & MetalCharge
        CompoundLabel.TextAlign = ContentAlignment.MiddleCenter ' Aligns the text in the middle of the label
        TempPanel.Controls.Add(CompoundLabel) ' Adds the label to the panel
        CompoundLabel.BringToFront()

    End Sub
    Public Sub MetallicBonding(ByVal Metal As Element) ' A metal element is passed in 
        Dim Cation As PictureBox ' Stores the image of an cation
        Dim Electron As PictureBox ' Stores the image of an electron
        Dim X As Integer ' X co-ordinate
        Dim Y As Integer = 100 ' Y co-ordinate

        ' Number of electrons present is calculated using GroupNo as that is equal to the number of electrons in the outer shell
        ' GroupNo is multiplied by 32 as 32 cations are displayed (4 rows x 8 columns = 32 cations)
        For i = 1 To (Metal.GetGroupNo) * 32 ' Draws the number of electrons present in the outer shells of the metals
            Electron = CreateElectron(Int((850 * Rnd()) + 100), Int((450 * Rnd()) + 50)) ' Draws electrons in random locations
        Next

        ' Draws a lattice (grid) of cations (positive ions)
        For j = 0 To 3 ' Draws 4 rows
            X = 150 ' Sets the intial X co-ordinate of the cation
            For i = 0 To 7 ' Draws 8 columns
                Cation = CreateCation(X, Y) ' Draws the cation
                X += 100 ' Shifts the next cation to the right by 100
            Next
            Y += 100 ' Shifts the next row of cations downwards by 100
        Next


    End Sub
    Private Function CreateCation(ByVal X As Integer, ByVal Y As Integer) As PictureBox
        Dim Cation As New PictureBox ' Create a picture box of a position ion (cation)

        Cation.SetBounds(X, Y, 80, 80) ' Sets the size and location of the cation
        Cation.BackColor = Color.Transparent ' Sets the background colour of the cation
        Cation.ImageLocation = "S:/Cation.png"
        Cation.SizeMode = PictureBoxSizeMode.StretchImage
        TempPanel.Controls.Add(Cation) ' Adds the cation to the panel

        Return Cation

    End Function
    Private Function CreateElectron(ByVal X As Integer, ByVal Y As Integer) As PictureBox
        Dim Electron As New PictureBox ' Create a picture box of an electron 

        Electron.SetBounds(X, Y, 30, 30) ' Sets the size and location of the electron
        Electron.BackColor = Color.Transparent ' Sets the background colour of the electron
        Electron.ImageLocation = "S:/Electron.png"
        Electron.SizeMode = PictureBoxSizeMode.StretchImage
        TempPanel.Controls.Add(Electron) ' Adds the electron the panel
        Electron.BringToFront()

        Return Electron

    End Function
    Public Function GetTempPanel() As Panel ' Public getter for TempPanel

        Return Me.TempPanel

    End Function
End Class
