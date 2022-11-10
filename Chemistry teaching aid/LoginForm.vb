
' https://www.youtube.com/watch?v=Z-3WnBapJWo
Public Class LoginForm
    Private Hash As New Hashing ' Instantiates Hashing

    Private Sub SignUpButton_Click(sender As System.Object, e As System.EventArgs) Handles SignUpButton.Click

        ' Form set up
        Me.LoginButton.Hide()
        Me.SignUpButton.Hide()
        Me.UsernameLabel.Show()
        Me.PasswordLabel.Show()
        Me.RepeatPasswordLabel.Show()
        Me.RepeatPasswordTextBox.Show()
        Me.PasswordTextBox.Show()
        Me.UsernameTextBox.Show()
        Me.SignupEnterButton.Show()
        Me.LoginEnterButton.Hide()

    End Sub
    Private Sub LoginButton_Click(sender As System.Object, e As System.EventArgs) Handles LoginButton.Click

        ' Form set up
        Me.LoginButton.Hide()
        Me.SignUpButton.Hide()
        Me.RepeatPasswordTextBox.Hide()
        Me.RepeatPasswordLabel.Hide()
        Me.PasswordLabel.Show()
        Me.UsernameLabel.Show()
        Me.PasswordTextBox.Show()
        Me.UsernameTextBox.Show()
        Me.SignupEnterButton.Hide()
        Me.LoginEnterButton.Show()

    End Sub
    Private Sub SignupEnterButton_Click(sender As System.Object, e As System.EventArgs) Handles SignupEnterButton.Click

        Hash.SignUp(UsernameTextBox.Text, PasswordTextBox.Text) ' Passes the user's username and password to the sign up procedure

        ' Empties the textboxes
        Me.PasswordTextBox.Clear()
        Me.UsernameTextBox.Clear()
        Me.RepeatPasswordTextBox.Clear()

    End Sub

    Private Sub LoginEnterButton_Click(sender As System.Object, e As System.EventArgs) Handles LoginEnterButton.Click

        Hash.Login(UsernameTextBox.Text, PasswordTextBox.Text) ' Passes the user's username and password to the login procedure

        ' Empties the textboxes
        Me.PasswordTextBox.Clear()
        Me.UsernameTextBox.Clear()
        Me.RepeatPasswordTextBox.Clear()

    End Sub

    Private Sub LoginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' Form set up
        Me.RepeatPasswordTextBox.Hide()
        Me.PasswordTextBox.Hide()
        Me.UsernameTextBox.Hide()
        Me.UsernameLabel.Hide()
        Me.PasswordLabel.Hide()
        Me.RepeatPasswordLabel.Hide()
        Me.SignupEnterButton.Hide()
        Me.LoginEnterButton.Hide()
        Me.SignUpButton.Show()
        Me.LoginButton.Show()
        Me.DataGridView1.Hide()
        ' Hides password using ● instead of actual password being entered
        PasswordTextBox.UseSystemPasswordChar = True
        RepeatPasswordTextBox.UseSystemPasswordChar = True

    End Sub

End Class