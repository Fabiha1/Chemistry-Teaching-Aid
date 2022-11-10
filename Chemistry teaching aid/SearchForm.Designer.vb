<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchForm
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
        Me.ESearchTextbox = New System.Windows.Forms.TextBox()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.BackButton2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ESearchTextbox
        '
        Me.ESearchTextbox.Location = New System.Drawing.Point(85, 24)
        Me.ESearchTextbox.Name = "ESearchTextbox"
        Me.ESearchTextbox.Size = New System.Drawing.Size(331, 20)
        Me.ESearchTextbox.TabIndex = 0
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLabel.Location = New System.Drawing.Point(20, 26)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(53, 16)
        Me.SearchLabel.TabIndex = 2
        Me.SearchLabel.Text = "Search"
        '
        'BackButton2
        '
        Me.BackButton2.BackColor = System.Drawing.Color.Thistle
        Me.BackButton2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BackButton2.FlatAppearance.BorderSize = 5
        Me.BackButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.BackButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton2.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton2.Location = New System.Drawing.Point(12, 351)
        Me.BackButton2.Name = "BackButton2"
        Me.BackButton2.Size = New System.Drawing.Size(75, 45)
        Me.BackButton2.TabIndex = 4
        Me.BackButton2.Text = "Back"
        Me.BackButton2.UseVisualStyleBackColor = False
        '
        'SearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(442, 408)
        Me.Controls.Add(Me.BackButton2)
        Me.Controls.Add(Me.SearchLabel)
        Me.Controls.Add(Me.ESearchTextbox)
        Me.Name = "SearchForm"
        Me.Text = "SearchForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ESearchTextbox As System.Windows.Forms.TextBox
    Friend WithEvents SearchLabel As System.Windows.Forms.Label
    Friend WithEvents BackButton2 As System.Windows.Forms.Button
End Class
