Public Class SearchForm
    Private TheSession As Session
    Private TheAtom As Atom
    Private Elements As List(Of Element) ' Stores all elements and its properties
    Private TheElement As Element
    Private NameLabel As New Label ' Label for name of element
    Private SymbolLabel As New Label ' Label for element symbol
    Private MassNoLabel As New Label ' Label for mass number of element (number of protons + neutrons)
    Private AtomicNoLabel As New Label ' Label for atomic number of element (number of protons or electrons)
    Private WithEvents DisplayAtomButton As New Button ' Button displays the atom
    Private WithEvents BackButton As New Button
    Private WithEvents DisplayIonButton As New Button ' Button displays ion
    Private Sub ESearchTextbox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles ESearchTextbox.KeyDown

        If e.KeyCode = Keys.Enter Then ' If the enter key is pressed, performs search
            TheSession = New Session ' Instantiates new session
            Elements = TheSession.GetElements
            TheElement = Nothing ' Resets TheElement

            Dim Text As String = ESearchTextbox.Text

            ' Linear search
            For Each Item As Element In Elements ' Searches each element in list
                If Item.GetName.ToUpper = Text.ToUpper Or Item.GetSymbol.ToUpper = Text.ToUpper Then ' Finds the element entered by the user 
                    TheElement = Item ' Assigns the element found to Metal so it can be accessed elsewhere
                End If
            Next

            If IsNothing(TheElement) = False Then ' Checks if element entered exists
                NameLabel.Visible = True
                MassNoLabel.Visible = True
                AtomicNoLabel.Visible = True
                DisplayAtomButton.Visible = True

                If TheElement.GetGroupNo = "8" Or TheElement.GetGroupNo = "T" Then ' Elements in group 8 don't form ions
                    DisplayIonButton.Visible = False ' so display ion button is hidden
                Else
                    DisplayIonButton.Visible = True
                End If

                ' Form set up
                NameLabel.Text = TheElement.GetName ' Writes name of element e.g. Helium
                NameLabel.Font = New Font("Nirmala UI", 20, FontStyle.Bold) ' Sets the font and font size
                NameLabel.TextAlign = ContentAlignment.MiddleCenter ' Aligns the text in the middle center of the label
                NameLabel.SetBounds(0, 250, Me.Width, 35) ' Sets the location and the size of the label

                SymbolLabel.Text = TheElement.GetSymbol ' Writes the symbol of the element e.g. He
                SymbolLabel.Font = New Font("Nirmala UI", 100, FontStyle.Bold) ' Sets the font and font size
                SymbolLabel.TextAlign = ContentAlignment.MiddleCenter ' Aligns the text in the middle center of the label
                SymbolLabel.SetBounds(0, 90, Me.Width, 175) ' Sets the location and the size of the label

                MassNoLabel.Text = TheElement.GetMassNo ' Writes the mass number of the element
                MassNoLabel.Font = New Font("Nirmala UI", 20, FontStyle.Bold) ' Sets the font and font size
                MassNoLabel.TextAlign = ContentAlignment.MiddleCenter ' Aligns the text in the middle center of the label
                MassNoLabel.SetBounds(0, 75, Me.Width, 40) ' Sets the location and the size of the label

                AtomicNoLabel.Text = TheElement.GetAtomicNo ' Writes the atomic number of the element
                AtomicNoLabel.Font = New Font("Nirmala UI", 20, FontStyle.Bold) ' Sets the font and font size
                AtomicNoLabel.TextAlign = ContentAlignment.MiddleCenter ' Aligns the text in the middle center of the label
                AtomicNoLabel.SetBounds(0, 300, Me.Width, 40) ' Sets the location and the size of the label

                DisplayAtomButton.Text = "Display Atom" ' Writes 'Display Atom' to the button
                DisplayAtomButton.Font = New Font("Nirmala UI", 8, FontStyle.Bold) ' Sets the font and font size
                DisplayAtomButton.FlatStyle = FlatStyle.Flat
                DisplayAtomButton.FlatAppearance.BorderSize = 5 ' Sets the thickness of the border
                DisplayAtomButton.BackColor = Color.Thistle ' Sets the background colour of the button
                DisplayAtomButton.SetBounds(350, 350, 75, 45) ' Sets the location and the size of the button

                DisplayIonButton.Text = "Display Ion" ' Writes 'Display Atom' to the button
                DisplayIonButton.Font = New Font("Nirmala UI", 8, FontStyle.Bold) ' Sets the font and font size
                DisplayIonButton.FlatStyle = FlatStyle.Flat
                DisplayIonButton.FlatAppearance.BorderSize = 5 ' Sets the thickness of the border
                DisplayIonButton.BackColor = Color.Thistle ' Sets the background colour of the button
                DisplayIonButton.SetBounds(250, 350, 75, 45) ' Sets the location and the size of the button

                Me.Controls.Add(NameLabel) ' Adds the name to the form
                Me.Controls.Add(SymbolLabel) ' Adds the symbol to the form
                Me.Controls.Add(MassNoLabel) ' Adds the mass number to the form
                Me.Controls.Add(AtomicNoLabel) ' Adds the atomic number to the form
                Me.Controls.Add(DisplayAtomButton) ' Adds the button saying 'Display Atom' to the form
                Me.Controls.Add(DisplayIonButton) ' Adds the button saying 'Display Ion' to the form
                MassNoLabel.BringToFront()
                AtomicNoLabel.BringToFront()
                DisplayAtomButton.BringToFront()
                DisplayIonButton.BringToFront()
            Else
                NameLabel.Visible = False
                MassNoLabel.Visible = False
                AtomicNoLabel.Visible = False
                DisplayIonButton.Visible = False
                DisplayAtomButton.Visible = False

                SymbolLabel.Text = "Element not found" ' Reuses symbol label if element is not found
                SymbolLabel.Font = New Font("Nirmala UI", 15) ' Sets the font and font size
                SymbolLabel.SetBounds(50, 100, 300, 175) ' Sets the location and the size of the label
                Me.Controls.Add(SymbolLabel) ' Adds the label to the form
            End If
        End If

    End Sub

    Private Sub DisplayAtomButton_Click(sender As Object, e As System.EventArgs) Handles DisplayAtomButton.Click

        ' Displays the atom corresponding the element entered

        ' Form set up
        NameLabel.Visible = False
        SymbolLabel.Visible = False
        MassNoLabel.Visible = False
        AtomicNoLabel.Visible = False
        DisplayAtomButton.Visible = False
        DisplayIonButton.Visible = False
        ESearchTextbox.Visible = False
        SearchLabel.Visible = False
        BackButton.Visible = True
        BackButton2.Visible = False

        ' Creates back button 
        BackButton.Text = "Back" ' Writes 'Back' to the button
        BackButton.FlatStyle = FlatStyle.Flat
        BackButton.Font = New Font("Nirmala UI", 8, FontStyle.Bold) ' Sets the font and font size
        BackButton.FlatAppearance.BorderSize = 5 ' Sets the size of the border of the button
        BackButton.BackColor = Color.Thistle ' Sets the background colour of the button
        BackButton.SetBounds(10, 10, 75, 45) ' Sets the location and the size of the button
        Me.Controls.Add(BackButton) ' Adds the button to the form
        BackButton.BringToFront()

        TheAtom = New Atom(TheElement) ' Instantiates Atom
        TheAtom.Location = New Point(10, 20) ' Sets the location of the atom
        Me.Controls.Add(TheAtom) ' Adds the atom onto the form

    End Sub
    Private Sub DisplayIonButton_Click(sender As Object, e As System.EventArgs) Handles DisplayIonButton.Click

        ' Displays the ion corresponding the element entered

        ' Form set up
        NameLabel.Visible = False
        SymbolLabel.Visible = False
        MassNoLabel.Visible = False
        AtomicNoLabel.Visible = False
        DisplayAtomButton.Visible = False
        DisplayIonButton.Visible = False
        ESearchTextbox.Visible = False
        SearchLabel.Visible = False
        BackButton.Visible = True
        BackButton2.Visible = False

        BackButton.Text = "Back" ' Writes 'Back' to the button
        BackButton.FlatStyle = FlatStyle.Flat
        BackButton.Font = New Font("Nirmala UI", 8, FontStyle.Bold) ' Sets the font and font size
        BackButton.FlatAppearance.BorderSize = 5 ' Sets the size of the border of the button
        BackButton.BackColor = Color.Thistle ' Sets the background colour of the button
        BackButton.SetBounds(10, 10, 75, 45)  ' Sets the location and the size of the button
        Me.Controls.Add(BackButton) ' Adds the button to the form
        BackButton.BringToFront()

        TheAtom = New Atom(TheElement, True)  ' Instantiates Atom using the Ion constructor
        TheAtom.Location = New Point(10, 20) ' Sets the location of the atom
        Me.Controls.Add(TheAtom) ' Adds atom to the form

    End Sub
    Private Sub BackButton_Click(sender As Object, e As System.EventArgs) Handles BackButton.Click

        ' When clicked, the user is taken back to the searching interface

        ' Form set up
        NameLabel.Visible = True
        SymbolLabel.Visible = True
        MassNoLabel.Visible = True
        AtomicNoLabel.Visible = True
        DisplayAtomButton.Visible = True
        BackButton2.Visible = True
        If TheElement.GetGroupNo.ToString = "8" Or TheElement.GetGroupNo = "T" Then ' Elements in group 8 don't form ions
            DisplayIonButton.Visible = False ' so DisplayIonButton is hidden
        Else
            DisplayIonButton.Visible = True
        End If
        ESearchTextbox.Visible = True
        SearchLabel.Visible = True
        TheAtom.Visible = False
        BackButton.Visible = False

    End Sub

    Private Sub BackButton2_Click(sender As System.Object, e As System.EventArgs) Handles BackButton2.Click
        Me.Hide() ' If button is clicked, BondingForm is hidden
        MenuForm.Show() ' MenuForm is shown
    End Sub

End Class