Public Class DictionaryForm
    Private TheDictionary As Dictionary
    Private Sub DictionaryForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TheDictionary = New Dictionary ' Instantiates new dictionary using the standard dictionary constructor

        SortComboBox.Items.Add("Alphabetical") ' Adds 'Alphabetical' option to the drop down list

    End Sub

    Private Sub SearchTextBox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles SearchTextBox.KeyDown

        ' If enter key is pressed, fill the data grid with the term and corresponding definition entered by the user

        If e.KeyCode = Keys.Enter Then
            TheDictionary.SearchDictionary(SearchTextBox.Text) ' Passes the text entered by the user into the SearchDictionary procedure
        End If

    End Sub

    Private Sub ResetButton_Click(sender As System.Object, e As System.EventArgs) Handles ResetButton.Click
        TheDictionary = New Dictionary ' Instantiates new dictionary using the standard dictionary constructor

    End Sub

    Private Sub SortComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles SortComboBox.SelectedIndexChanged

        If SortComboBox.SelectedIndex = 0 Then ' If 'Alphabetical' is selected in the drop down list
            TheDictionary = New Dictionary(True) ' Instantiates new dictionary using the sorted dictionary constructor
        End If

    End Sub

    Private Sub BackButton_Click(sender As System.Object, e As System.EventArgs) Handles BackButton.Click
        Me.Hide() ' If button is clicked, DictionaryForm is hidden
        MenuForm.Show() ' Shows MenuForm
    End Sub
End Class