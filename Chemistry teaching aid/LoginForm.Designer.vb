<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.SignUpButton = New System.Windows.Forms.Button()
        Me.RepeatPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.SignupEnterButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LoginEnterButton = New System.Windows.Forms.Button()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.RepeatPasswordLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(131, 147)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(219, 25)
        Me.PasswordTextBox.TabIndex = 0
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(131, 87)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(219, 25)
        Me.UsernameTextBox.TabIndex = 1
        '
        'SignUpButton
        '
        Me.SignUpButton.BackColor = System.Drawing.Color.Thistle
        Me.SignUpButton.FlatAppearance.BorderSize = 5
        Me.SignUpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignUpButton.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignUpButton.Location = New System.Drawing.Point(65, 128)
        Me.SignUpButton.Name = "SignUpButton"
        Me.SignUpButton.Size = New System.Drawing.Size(122, 61)
        Me.SignUpButton.TabIndex = 2
        Me.SignUpButton.Text = "Sign Up"
        Me.SignUpButton.UseVisualStyleBackColor = False
        '
        'RepeatPasswordTextBox
        '
        Me.RepeatPasswordTextBox.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepeatPasswordTextBox.Location = New System.Drawing.Point(131, 212)
        Me.RepeatPasswordTextBox.Name = "RepeatPasswordTextBox"
        Me.RepeatPasswordTextBox.Size = New System.Drawing.Size(219, 25)
        Me.RepeatPasswordTextBox.TabIndex = 3
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.Thistle
        Me.LoginButton.FlatAppearance.BorderSize = 5
        Me.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginButton.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.Location = New System.Drawing.Point(206, 128)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(122, 61)
        Me.LoginButton.TabIndex = 4
        Me.LoginButton.Text = "Login in"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'SignupEnterButton
        '
        Me.SignupEnterButton.BackColor = System.Drawing.Color.Thistle
        Me.SignupEnterButton.FlatAppearance.BorderSize = 5
        Me.SignupEnterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.SignupEnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignupEnterButton.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignupEnterButton.Location = New System.Drawing.Point(283, 296)
        Me.SignupEnterButton.Name = "SignupEnterButton"
        Me.SignupEnterButton.Size = New System.Drawing.Size(84, 48)
        Me.SignupEnterButton.TabIndex = 5
        Me.SignupEnterButton.Text = "Enter"
        Me.SignupEnterButton.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 331)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(368, 150)
        Me.DataGridView1.TabIndex = 6
        '
        'LoginEnterButton
        '
        Me.LoginEnterButton.BackColor = System.Drawing.Color.Thistle
        Me.LoginEnterButton.FlatAppearance.BorderSize = 5
        Me.LoginEnterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.LoginEnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginEnterButton.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginEnterButton.Location = New System.Drawing.Point(283, 296)
        Me.LoginEnterButton.Name = "LoginEnterButton"
        Me.LoginEnterButton.Size = New System.Drawing.Size(83, 48)
        Me.LoginEnterButton.TabIndex = 7
        Me.LoginEnterButton.Text = "Enter"
        Me.LoginEnterButton.UseVisualStyleBackColor = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(27, 86)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(87, 21)
        Me.UsernameLabel.TabIndex = 9
        Me.UsernameLabel.Text = "Username"
        '
        'RepeatPasswordLabel
        '
        Me.RepeatPasswordLabel.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepeatPasswordLabel.Location = New System.Drawing.Point(30, 200)
        Me.RepeatPasswordLabel.Name = "RepeatPasswordLabel"
        Me.RepeatPasswordLabel.Size = New System.Drawing.Size(89, 46)
        Me.RepeatPasswordLabel.TabIndex = 10
        Me.RepeatPasswordLabel.Text = "Repeat Password"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(27, 147)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(81, 21)
        Me.PasswordLabel.TabIndex = 11
        Me.PasswordLabel.Text = "Password"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(379, 356)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.RepeatPasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LoginEnterButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.SignupEnterButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.RepeatPasswordTextBox)
        Me.Controls.Add(Me.SignUpButton)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SignUpButton As System.Windows.Forms.Button
    Friend WithEvents RepeatPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents SignupEnterButton As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LoginEnterButton As System.Windows.Forms.Button
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents RepeatPasswordLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
End Class
