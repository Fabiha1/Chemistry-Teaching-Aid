' Libraries used to generate hashes
Imports System.Text
Imports System.Security.Cryptography
Imports System.Data.OleDb
Public Class Hashing
    Private HashValue As String ' Stores the hashed version of the password
    Private DTable As New DataTable
    Private DAdapter As New OleDbDataAdapter
    Private Con As New OleDbConnection
    Public Sub New()
        Me.HashValue = ""
        Con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=S:\Login.mdb" ' Connection to Login SQL database

    End Sub
    Private Function HashPassword(ByVal Password As String) As String
        ' Hashes password using SHA256
        Using Hasher As SHA256 = SHA256.Create() ' Creates hash object
            Dim Bytes As Byte() = Hasher.ComputeHash(Encoding.UTF8.GetBytes(Password)) ' Convert to byte array and get hash

            For i As Integer = 0 To Bytes.Length - 1 ' Converts byte data to hex string
                HashValue &= Hex(Bytes(i))
            Next

            Return HashValue ' Hashed password is returned
        End Using

    End Function
    Public Sub SignUp(ByVal Username As String,
                      ByVal Password As String)

        ' Writes the user's username and hash value of their password to Login database after sign up
        Con.Open()

        HashValue = HashPassword(Password) ' Hashes password entered

        Try ' Exception handling
            ' User is required to enter password twice when signing up
            If LoginForm.PasswordTextBox.Text = LoginForm.RepeatPasswordTextBox.Text Then ' Checks if the password matches eachother
                Dim SQL As String = "Insert into LoginTable(Username, [Password]) values(@Username, @HashValue)" ' SQL command to insert username and hash value of password into database
                Dim Command As New System.Data.OleDb.OleDbCommand(SQL, Con)

                Command.Parameters.Add("@Username", Data.OleDb.OleDbType.LongVarChar).Value = Username
                Command.Parameters.Add("@Password", Data.OleDb.OleDbType.LongVarChar).Value = HashValue

                Command.ExecuteNonQuery() ' Execute SQL command

                MsgBox("Sign up successful")
                MenuForm.Show() ' Opens the menu so the rest of the program can be accessed
                LoginForm.Hide() ' Hides current form
            Else
                MsgBox("Passwords don't match") ' If password's don't match, an error message is displayed
            End If
        Catch
            ' Username is a primary key
            ' If Username is a duplicate of another an error occurs and the user has to enter a new, unique username
            MsgBox("Duplicate username") ' Appropriate error message displayed
        End Try

        HashValue = "" ' Resets hash

        Con.Close()

    End Sub
    Public Sub Login(ByVal Username As String,
                     ByVal Password As String)


        ' Retrieves username and hashed password from SQL Login database

        Con.Open()

        HashValue = HashPassword(Password) ' Hashes password entered by the user when trying to login

        Try
            Dim DPassword As String = "" ' Password extracted from database
            Dim SQL As String = "Select Password from LoginTable where Username = @Username" ' SQL command that selects the hash value asssociated to the username entered
            Dim Command As New System.Data.OleDb.OleDbCommand(SQL, con)

            Command.Parameters.Add("@Username", Data.OleDb.OleDbType.LongVarChar).Value = Username

            DAdapter = New OleDbDataAdapter(Command)
            DAdapter.Fill(DTable)

            LoginForm.DataGridView1.DataSource = DTable.DefaultView ' Fills selected data from database into data grid
            DPassword = LoginForm.DataGridView1.Rows(0).Cells(0).Value.ToString ' Extracts password from data grid

            If DPassword = HashValue Then ' Checks if hash value of password entered is the same as password in database
                MsgBox("Login successful") ' Success message is displayed
                MenuForm.Show() ' Opens the menu so the rest of the program can be accessed
                LoginForm.Hide() ' Hides current form
            Else
                ' If HashValue does not match the password from the data base
                MsgBox("Incorrect password") ' Appropriate error message is displayed
            End If
        Catch
            ' If the Username does not exist in LoginTable, an error occurs
            MsgBox("User does not exist") ' Appropriate error message is show
        End Try

        HashValue = "" ' Resets hash

        con.Close()

    End Sub
End Class
