Public Class Element
    Private Name As String ' Name of the element e.g. Helium
    Private Symbol As String ' Symbol of the element e.g. He
    Private GroupNo As String ' Stores group no of element e.g. 8
    ' If the element doesn't have a group number (transition metal), 'T' is used as a place holder
    Private PeriodNo As Integer ' Stores period number of an element e.g. 1
    Private IsMetal As Boolean ' Stores true if element is metal and false if element is a non-metal
    Private MassNo As Integer ' Number of protons + neutrons in an atom
    Private AtomicNo As Integer ' Number of protons or electrons in an atom, is unique

    Public Sub New(ByVal TempName,
                   ByVal TempSymbol,
                   ByVal TempGroupNo,
                   ByVal TempPeriodNo,
                   ByVal TempIsMetal,
                   ByVal TempMassNo,
                   ByVal TempAtomicNo)

        Me.Name = TempName
        Me.Symbol = TempSymbol
        Me.GroupNo = TempGroupNo
        Me.PeriodNo = TempPeriodNo
        Me.IsMetal = TempIsMetal
        Me.MassNo = TempMassNo
        Me.AtomicNo = TempAtomicNo

    End Sub
    ' Public getters for data hiding
    Public Function GetName() As String ' Getter for the element's name

        Return Me.Name

    End Function
    Public Function GetSymbol() As String ' Getter for the element's symbol

        Return Me.Symbol

    End Function
    Public Function GetGroupNo() As String ' Getter for the element's group number

        Return Me.GroupNo

    End Function
    Public Function GetPeriodNo() As Integer ' Getter for the element's period number

        Return Me.PeriodNo

    End Function
    Public Function GetIsMetal() As String ' Getter whether element is metal

        Return Me.IsMetal

    End Function
    Public Function GetMassNo() As Integer ' Getter for the element's mass number

        Return Me.MassNo

    End Function
    Public Function GetAtomicNo() As Integer ' Getter for the element's atomic number

        Return Me.AtomicNo

    End Function
End Class
