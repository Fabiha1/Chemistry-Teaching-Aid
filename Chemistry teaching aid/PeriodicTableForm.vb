Public Class PeriodicTableForm
    Private ThePeriodicTable As PeriodicTable
    Private TheSession As Session
    Private Sub BackButton_Click(sender As System.Object, e As System.EventArgs) Handles BackButton.Click
        Me.Hide() ' If button is clicked, PeriodicTablem form is hidden
        MenuForm.Show() ' MenuForm is shown
    End Sub

    Private Sub PeriodicTableForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TheSession = New Session ' Instantiates Session
        ThePeriodicTable = New PeriodicTable(TheSession.GetElements) ' Instantiates PeriodicTable
    End Sub
End Class
