Public Class Atom ' Draws the atom
    Inherits Panel ' Atom is a panel as it holds other VB.NET controls
    Protected NoOfShells As Integer ' Stores the number of electron shells the atom has, it is the same value as PeriodNo
    Protected NoOfOuterElectrons As Integer ' Stores the number of electrons on the outer shell as the atom, it has the same value as GroupNo
    Protected NoOfProtons As Integer ' Stores the number of protons, is equal to AtomicNo
    Protected NoOfNeutrons As Integer ' Stores number of neutrons, is equal to MassNo - AtomicNo
    Protected NoOfElectrons As Integer ' Stores number of electrons 
    Protected Charge As String ' Stores the charge of an ion
    ' Only ions have charges, e.g. if the ion has lost 3 electron, it will have a charge of '3+'
    ' If the ion has gained two electrons, it will have a charge of '2-'

    Public Sub New(ByVal TheElement As Element) ' Constructor for a normal atom
        Me.Size = SearchForm.Size ' Sets the default size of the panel to the size of SearchForm
        Me.BackColor = Color.Transparent ' Sets the background colour of the panel
        Me.NoOfShells = TheElement.GetPeriodNo ' Number of electron shells is equal to the period number of the element. This logic only applies to atoms
        Me.NoOfProtons = TheElement.GetAtomicNo ' Number of protons is equal to the atomic number of the element
        Me.NoOfNeutrons = TheElement.GetMassNo - TheElement.GetAtomicNo ' Number of neutrons is equal to the Mass number - Atomic number
        Me.NoOfElectrons = TheElement.GetAtomicNo ' Number of electrons is equal to the atomic number. This logic only applies to atoms
        Me.Charge = Nothing ' Atoms have no charge

        If TheElement.GetGroupNo <> "T" Then ' Transition metals don't follow the same rules
            Me.NoOfOuterElectrons = TheElement.GetGroupNo ' Number of outer shell electrons is equal to the group number. Logic only applies to atoms
        Else
            Me.NoOfOuterElectrons = Me.NoOfElectrons - 2 - ((Me.NoOfShells - 2) * 8)
            ' The number of outer shell electrons of transition metals cannot be calculated using group number as transition metals don't have a group number
            ' Number of outer shell electrons can be calculated by subtracted 2 from the total number of electrons as there only 2 electrons on the first shell
            ' Then, subtract 8 * Number of subsequent shells - 1 as all subsquent shells (apart from the outer shell) has 8 electrons
            ' The remaining electrons make up the electrons in the outer shell
        End If

    End Sub
    ' Overloading
    Public Sub New(ByVal TheElement As Element, ByVal IsIon As Boolean) ' Constructor for an ion (charged atom)
        Me.Size = SearchForm.Size ' Sets the default size of the panel to the size of SearchForm
        Me.BackColor = Color.Transparent ' Sets the background colour of the panel
        Me.NoOfProtons = TheElement.GetAtomicNo ' Number of protons is equal to the atomic number of the element
        Me.NoOfNeutrons = TheElement.GetMassNo - TheElement.GetAtomicNo ' Number of neutrons is equal to the Mass number - Atomic number
        Me.NoOfOuterElectrons = 8 ' Sets to 8 as all ions have a full outer shell of 8 electrons

        If TheElement.GetGroupNo <> "T" Then ' If is not a transition metal as transition metals variable charges
            If TheElement.GetIsMetal = True Then ' Checks if element is a metal
                Me.NoOfElectrons = TheElement.GetAtomicNo - TheElement.GetGroupNo ' Metals lose all outer electrons 
                Me.Charge = TheElement.GetGroupNo & "+" ' Gives a +ve charge to metals
                Me.NoOfShells = TheElement.GetPeriodNo - 1 ' NoOfShells in a metal ion is 1 less than PeriodNo
            Else
                If TheElement.GetSymbol = "H" Then
                    Me.Charge = "+" ' Hydrogen is anomalous, although it is a non-metal, it has a +ve charge
                    Me.NoOfOuterElectrons = 0 ' Hydrogen ions have no electrons
                    Me.NoOfElectrons = 0
                Else  ' All other ions follow the same structure
                    If TheElement.GetGroupNo <> 8 Then  'Checks if element is a noble gas (in group 8) as they do not form ions
                        Me.Charge = (8 - TheElement.GetGroupNo) & "-" ' Gives a -ve charge to metals
                        Me.NoOfElectrons = TheElement.GetAtomicNo + TheElement.GetGroupNo ' Non-metals gain electrons in ionic bonding 
                    Else
                        Me.NoOfElectrons = TheElement.GetGroupNo ' Noble gases don't lose or gain electrons 
                    End If
                End If
                Me.NoOfShells = TheElement.GetPeriodNo ' The number of shells in a non-metal ion is the same as the period number
            End If
        End If

        DrawIon()

    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs) ' Draws the atom onto the panel
        MyBase.OnPaint(e)
        Dim TempPen As New Pen(Color.Black)
        Dim TempBrush As New SolidBrush(Color.Green) ' Sets the fill colour of the neutrons
        Dim LoopTo As Integer ' Stores number of electrons on the first shell (0, 1 or 2)
        Dim Skew As Integer = 0 ' Increases as number of shells increases so electrons fit onto shells
        Dim X As Integer = 100 ' X co-ordinate
        Dim Y As Integer = 100 ' Y co-ordinate
        Dim Height As Integer = 200
        Dim Width As Integer = 200

        ' NoOfShells determines the size of the atom
        Select Case NoOfShells ' Scales down if graphics is too big and centres it on the panel
            Case 2 ' If atom has 2 shells
                e.Graphics.ScaleTransform(0.9F, 0.9F) ' Scale down the graphics by scale factor 0.9
                e.Graphics.TranslateTransform(30, 0) ' Translate graphics by 30 in the x direction
            Case 3
                ' If atom has 3 shells
                e.Graphics.ScaleTransform(0.7F, 0.7F) ' Scale down the graphics by scale factor 0.7
                e.Graphics.TranslateTransform(95, 60) ' Translate graphics by 95 in the x direction and 60 in the y direction
            Case 4, 5
                ' If atom has 4 or 5 shells
                e.Graphics.ScaleTransform(0.5F, 0.5F)  ' Scale down the graphics by scale factor 0.5
                e.Graphics.TranslateTransform(210, 175) ' Translate graphics by 210 in the x direction and 175 in the y direction
            Case 6, 7
                ' If atom has 6 or 7 shells
                e.Graphics.ScaleTransform(0.4F, 0.4F) ' Scale down the graphics by scale factor 0.5 
                e.Graphics.TranslateTransform(310, 265)  ' Translate graphics by 310 in the x direction and 265 in the y direction
        End Select

        TempPen.Width = 5 ' Sets the width of the outline

        For i = 1 To NoOfShells ' Creates circles corresponding to the PeriodNo of an TheElement
            e.Graphics.DrawEllipse(TempPen, X, Y, Height, Width) ' Draws electron shells
            X -= 50
            Y -= 50
            Height += 100
            Width += 100
        Next

        For i = 1 To NoOfNeutrons ' Draws neutrons randomly in the centre of the atom
            X = Int(50 * Rnd() + 150) ' Random X co-ordinate
            Y = Int(50 * Rnd() + 150) ' Random Y co-ordinate
            e.Graphics.FillEllipse(TempBrush, X, Y, 40, 40) ' Draws filled in circles
            e.Graphics.DrawEllipse(TempPen, X, Y, 40, 40) ' Draws outline around the neutrons
        Next

        TempBrush = New SolidBrush(Color.Crimson) ' Sets the color of the proton

        For i = 1 To NoOfProtons ' Draws protons randomly in the nucleus
            X = Int((150 - 100 + 1) * Rnd() + 150) ' Random X co-ordinate
            Y = Int((150 - 100 + 1) * Rnd() + 150) ' Random Y co-ordinate
            e.Graphics.FillEllipse(TempBrush, X, Y, 40, 40) ' Draws filled in circles
            e.Graphics.DrawEllipse(TempPen, X, Y, 40, 40) ' Draws outline around the protons
        Next

        ' Draws electrons on the electron shells

        TempBrush = New SolidBrush(Color.DarkCyan) ' Sets the color of the electron
        X = 190 ' Sets intial X co-ordinate of electron
        Y = 90 ' Sets intital Y co-ordinate of electron

        If NoOfElectrons = 1 Then ' If the element only has one electron, only one electron on the first shell
            LoopTo = 1
        ElseIf NoOfElectrons = 0 Then ' If the element has no electrons, no electrons on the first sheel
            LoopTo = 0
        Else ' If the atom has 2 or more electrons, the first shell always contains 2 electrons
            LoopTo = 2
        End If

        For i = 1 To LoopTo ' Draws first shell of electrons as the first shell holds a max of 2
            e.Graphics.FillEllipse(TempBrush, X, Y, 20, 20) ' Draws filled circle
            e.Graphics.DrawEllipse(TempPen, X, Y, 20, 20) ' Draws outline around electron
            Y += 200
        Next

        For i = 1 To NoOfShells - 1 ' Draws electrons on the remaining shells (not the first one)
            If i = NoOfShells - 1 Then ' Checks if outershell has been looped to
                LoopTo = NoOfOuterElectrons ' The outershell holds the same number of electrons as the group no.
            Else ' If not at outer shell the number of electrons is 8
                LoopTo = 8
            End If

            ' Draws electrons clockwise on the electron shells
            For j = 1 To LoopTo
                Select Case j
                    Case 1
                        X = 165
                        Y = 40 - Skew
                    Case 2
                        X = 340 + Skew
                        Y = 165
                    Case 3
                        X = 215
                        Y = 340 + Skew
                    Case 4
                        X = 40 - Skew
                        Y = 215
                    Case 5
                        X = 215
                        Y = 40 - Skew
                    Case 6
                        X = 340 + Skew
                        Y = 215
                    Case 7
                        X = 165
                        Y = 340 + Skew
                    Case 8
                        X = 40 - Skew
                        Y = 165
                End Select

                e.Graphics.FillEllipse(TempBrush, X, Y, 20, 20) ' Draws filled circle
                e.Graphics.DrawEllipse(TempPen, X, Y, 20, 20) ' Draws outline around the electron
            Next
            Skew += 50 ' Adjusts the position of the electron when needed to be drawn onto a new shell
        Next

    End Sub
    Private Sub DrawIon()
        ' Only called in the ion contructor
        Dim TempText As New Label ' Adds the charge of the ion to the panel

        TempText.SetBounds(385, 30, 100, 70) ' Sets the position and the size of the label
        TempText.Text = Me.Charge ' Sets the text as the charge of the ion
        TempText.BackColor = Color.Transparent
        TempText.Font = New Font("Nirmala UI", 20, FontStyle.Bold) ' Sets the font and the font size
        Me.Controls.Add(TempText) ' Adds the charge to the panel

        Dim SquareBrackets As New PictureBox ' Adds square brackets around the diagram of an ion

        SquareBrackets.SetBounds(-70, 0, 550, 370) ' Sets the position and the size of the brackets
        SquareBrackets.ImageLocation = "C:\Users\fabih.FABIHAS-LAPTOP\Documents\School Work\Year 13\Computer Science\NEA\square-brackets.png"
        SquareBrackets.SizeMode = PictureBoxSizeMode.StretchImage
        Me.Controls.Add(SquareBrackets) ' Adds the square brackets to the panel

    End Sub

End Class