<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PeriodicTableButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.DictionaryButton = New System.Windows.Forms.Button()
        Me.BondingButton = New System.Windows.Forms.Button()
        Me.ChemistryLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PeriodicTableButton
        '
        Me.PeriodicTableButton.BackColor = System.Drawing.Color.Thistle
        Me.PeriodicTableButton.FlatAppearance.BorderSize = 5
        Me.PeriodicTableButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.PeriodicTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PeriodicTableButton.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeriodicTableButton.Location = New System.Drawing.Point(213, 161)
        Me.PeriodicTableButton.Name = "PeriodicTableButton"
        Me.PeriodicTableButton.Size = New System.Drawing.Size(231, 82)
        Me.PeriodicTableButton.TabIndex = 0
        Me.PeriodicTableButton.Text = "Periodic Table"
        Me.PeriodicTableButton.UseVisualStyleBackColor = False
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.Thistle
        Me.SearchButton.FlatAppearance.BorderSize = 5
        Me.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(213, 260)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(231, 82)
        Me.SearchButton.TabIndex = 1
        Me.SearchButton.Text = "Search Elements"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'DictionaryButton
        '
        Me.DictionaryButton.BackColor = System.Drawing.Color.Thistle
        Me.DictionaryButton.FlatAppearance.BorderSize = 5
        Me.DictionaryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.DictionaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DictionaryButton.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DictionaryButton.Location = New System.Drawing.Point(213, 458)
        Me.DictionaryButton.Name = "DictionaryButton"
        Me.DictionaryButton.Size = New System.Drawing.Size(231, 82)
        Me.DictionaryButton.TabIndex = 3
        Me.DictionaryButton.Text = "Dictionary"
        Me.DictionaryButton.UseVisualStyleBackColor = False
        '
        'BondingButton
        '
        Me.BondingButton.BackColor = System.Drawing.Color.Thistle
        Me.BondingButton.FlatAppearance.BorderSize = 5
        Me.BondingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.BondingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BondingButton.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BondingButton.Location = New System.Drawing.Point(213, 359)
        Me.BondingButton.Name = "BondingButton"
        Me.BondingButton.Size = New System.Drawing.Size(231, 82)
        Me.BondingButton.TabIndex = 5
        Me.BondingButton.Text = "Bonding"
        Me.BondingButton.UseVisualStyleBackColor = False
        '
        'ChemistryLabel
        '
        Me.ChemistryLabel.BackColor = System.Drawing.Color.Thistle
        Me.ChemistryLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChemistryLabel.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChemistryLabel.Location = New System.Drawing.Point(-4, 23)
        Me.ChemistryLabel.Name = "ChemistryLabel"
        Me.ChemistryLabel.Size = New System.Drawing.Size(670, 100)
        Me.ChemistryLabel.TabIndex = 6
        Me.ChemistryLabel.Text = "CHEMISTRY"
        Me.ChemistryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(659, 568)
        Me.Controls.Add(Me.ChemistryLabel)
        Me.Controls.Add(Me.BondingButton)
        Me.Controls.Add(Me.DictionaryButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.PeriodicTableButton)
        Me.Name = "MenuForm"
        Me.Text = "MenuForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PeriodicTableButton As System.Windows.Forms.Button
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents DictionaryButton As System.Windows.Forms.Button
    Friend WithEvents BondingButton As System.Windows.Forms.Button
    Friend WithEvents ChemistryLabel As System.Windows.Forms.Label
End Class
