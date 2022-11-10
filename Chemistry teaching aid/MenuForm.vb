Public Class MenuForm
    Private Sub PeriodicTableButton_Click(sender As System.Object, e As System.EventArgs) Handles PeriodicTableButton.Click
        PeriodicTableForm.Show() ' If periodic table button is clicked, the periodic table form is loaded
        Me.Hide() ' Menu form is hidden
    End Sub

    Private Sub SearchButton_Click(sender As System.Object, e As System.EventArgs) Handles SearchButton.Click
        SearchForm.Show() ' If search button is clicked, the search form is loaded
        Me.Hide() ' Menu form is hidden

    End Sub

    Private Sub BondingButton_Click(sender As System.Object, e As System.EventArgs) Handles BondingButton.Click
        BondingForm.Show() ' If bonding button is clicked, bonding form is shown
        Me.Hide() ' Menu form is hidden
    End Sub

    Private Sub DictionaryButton_Click(sender As System.Object, e As System.EventArgs) Handles DictionaryButton.Click
        DictionaryForm.Show() ' If dictionary button is clicked, the dictionary form is shown
        Me.Hide() ' Menu form is hidden
    End Sub


End Class