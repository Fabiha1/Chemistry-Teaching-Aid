Public Class BondingForm
    Private TheBonding As Bonding
    Private Elements As List(Of Element)
    Private TheSession As Session
    Private MetalAtom As Atom
    Private NonMetalAtom As Atom
    Private Metal As Element
    Private NonMetal As Element
    Private Sub IonicButton_Click(sender As System.Object, e As System.EventArgs) Handles IonicButton.Click

        ' Set up
        IonicButton.Hide()
        MetallicBondingButton.Hide()
        BackButton1.Hide()
        BackButton2.Show()
        ShowMetallicBondingButton.Hide()
        ShowIonicBondingButton.Show()
        MetalsComboBox.Show()
        NonMetalsComboBox.Show()

        MetalsComboBox.Items.Clear() ' Clears the items in the combo box
        NonMetalsComboBox.Items.Clear() ' Clears the items in the combo box
        MetalsComboBox.Text = "Metals" ' Labels the combo box
        NonMetalsComboBox.Text = "Non-metals" ' Labels the combo box

        ' Fills in drop down lists
        For Each Item As Element In Elements ' Searches each element in list
            If Item.GetIsMetal = False And Item.GetGroupNo <> "8" And Item.GetSymbol <> "H" Then ' Elements in group 8 can't undergo ionic bonding
                ' Hydrogen has anomalous properties so isn't included
                NonMetalsComboBox.Items.Add(Item.GetName) ' Adds appropriate non-metals to drop down list
            ElseIf Item.GetIsMetal = True And Item.GetGroupNo <> "T" Then ' Ionic bonding with transition metals is not relevent to GCSE spec 
                MetalsComboBox.Items.Add(Item.GetName) ' Adds appropriate metals to drop down list
            End If
        Next

    End Sub

    Private Sub MetalsComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles MetalsComboBox.SelectedIndexChanged

        For Each Item As Element In Elements ' Linear search on items in element
            If MetalsComboBox.SelectedItem.ToString = Item.GetName Then ' Finds the element in the list elements equal to the one selected
                Metal = Item ' Assigns the element found to Metal so it can be accessed elsewhere
            End If
        Next

    End Sub

    Private Sub NonMetalsComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles NonMetalsComboBox.SelectedIndexChanged

        For Each Item As Element In Elements ' Linear search on items in element
            If NonMetalsComboBox.SelectedItem.ToString = Item.GetName Then ' Finds the element in the list elements equal to the one selected
                NonMetal = Item ' Assigns the element found to NonMetal so it can be accessed elsewhere
            End If
        Next
    End Sub

    Private Sub BondingForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TheSession = New Session ' Instantiates Session
        Elements = TheSession.GetElements ' Assigns list of elements so they can be accessed elsewhere

        ' Form setup
        MetalsComboBox.Hide()
        NonMetalsComboBox.Hide()
        ShowMetallicBondingButton.Hide()
        ShowIonicBondingButton.Hide()
        BackButton2.Hide()

    End Sub

    Private Sub ShowMetallicBondingButton_Click(sender As System.Object, e As System.EventArgs) Handles ShowMetallicBondingButton.Click

        If MetalsComboBox.SelectedItem Is Nothing Then
            MsgBox("Please select an element") ' Displays an error if drop down list is left blank
        Else
            TheBonding = New Bonding ' Instantiates Bonding
            ' Form setup
            MetalsComboBox.Hide()
            ShowMetallicBondingButton.Hide()
            ShowIonicBondingButton.Hide()
            BackButton2.Show()

            TheBonding.MetallicBonding(Metal) ' Calls metallic bonding procedure in bonding
        End If

    End Sub

    Private Sub MetallicBondingButton_Click(sender As System.Object, e As System.EventArgs) Handles MetallicBondingButton.Click

        ' Form setup
        IonicButton.Hide()
        MetallicBondingButton.Hide()
        BackButton1.Hide()
        BackButton2.Show()
        ShowMetallicBondingButton.Show()
        ShowIonicBondingButton.Hide()
        MetalsComboBox.Show()
        NonMetalsComboBox.Hide()

        MetalsComboBox.Items.Clear() ' Clears combo box
        MetalsComboBox.Text = "Metals" ' Labels the combo box

        For Each Item As Element In Elements ' Searches each element in list
            If Item.GetIsMetal = True And Item.GetGroupNo <> "T" Then  ' Elements in group 8 can't undergo ionic bonding
                MetalsComboBox.Items.Add(Item.GetName) ' Adds appropriate metals to drop down list
            End If
        Next

    End Sub

    Private Sub BackButton1_Click(sender As System.Object, e As System.EventArgs) Handles BackButton1.Click
        Me.Hide() ' If the back button is clicked, BondingForm is hidden
        MenuForm.Show() ' MenuForm is hidden
    End Sub

    Private Sub BackButton2_Click(sender As System.Object, e As System.EventArgs) Handles BackButton2.Click

        ' Form setup
        IonicButton.Show()
        MetallicBondingButton.Show()
        BackButton1.Show()
        MetalsComboBox.Hide()
        NonMetalsComboBox.Hide()
        ShowMetallicBondingButton.Hide()
        BackButton2.Hide()

        ' If TempPanel from Bonding has controls, when the back button is clicked, the panel is hidden
        If TheBonding Is Nothing Then
        Else
            TheBonding.GetTempPanel.Hide()
        End If

    End Sub

    Private Sub ShowIonicBondingButton_Click(sender As System.Object, e As System.EventArgs) Handles ShowIonicBondingButton.Click

        If NonMetalsComboBox.SelectedItem Is Nothing Or MetalsComboBox.SelectedItem Is Nothing Then
            MsgBox("Please enter an element") ' Displays error message is drop down lists are left blank
        Else
            TheBonding = New Bonding ' Instantiates Bonding
            ' Form set up
            MetalsComboBox.Hide()
            NonMetalsComboBox.Hide()
            ShowMetallicBondingButton.Hide()
            ShowIonicBondingButton.Hide()
            BackButton2.Show()

            TheBonding.IonicBonding(Metal, NonMetal) ' Calls the ionic bonding procedure in bonding to display ionic bonding
        End If

    End Sub
End Class