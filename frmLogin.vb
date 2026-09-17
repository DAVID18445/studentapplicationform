Imports System.Data.OleDb

Public Class frmLogin
    Private connectionString As String =
    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
    IO.Path.Combine(Application.StartupPath, "StudentApplicationSystem.accdb") &
    ";Persist Security Info=False;"
    Private Sub lblSubtitle_Click(sender As Object, e As EventArgs) Handles lblSubtitle.Click

    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Dim answer As DialogResult

        answer = MessageBox.Show(
        "Are you sure you want to exit?",
        "Exit Application",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If answer = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text.Trim() = "" Then
            lblMessage.ForeColor = Color.Red
            lblMessage.Text = "Please enter your username or email."
            txtUsername.Focus()
            Exit Sub
        End If

        If txtPassword.Text = "" Then
            lblMessage.ForeColor = Color.Red
            lblMessage.Text = "Please enter your password."
            txtPassword.Focus()
            Exit Sub
        End If

        Try

            Using connection As New OleDbConnection(connectionString)

                connection.Open()

                Dim query As String = "SELECT COUNT(*) FROM Users WHERE (UserName = ? OR Email = ?) AND [Password] = ?"

                Using command As New OleDbCommand(query, connection)

                    command.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
                    command.Parameters.AddWithValue("@email", txtUsername.Text.Trim())
                    command.Parameters.AddWithValue("@password", txtPassword.Text)

                    Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                    If result > 0 Then

                        lblMessage.ForeColor = Color.Green
                        lblMessage.Text = "Login successful."

                        Me.Hide()
                        frmApplication.ShowDialog()
                        Me.Show()

                    Else

                        lblMessage.ForeColor = Color.Red
                        lblMessage.Text = "Incorrect username/email or password."

                    End If

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
            "Database connection error: " & ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        End Try

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBackToLogin_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        pnlRegistration.Visible = True
    End Sub

    Private Sub pnlRegistration_Paint(sender As Object, e As PaintEventArgs) Handles pnlRegistration.Paint

    End Sub

    Private Sub btnBackToLogin_Click_1(sender As Object, e As EventArgs) Handles btnBackToLogin.Click
        pnlRegistration.Visible = False
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtFullName.Text.Trim() = "" Then
            MessageBox.Show("Please enter your full name.")
            txtFullName.Focus()
            Exit Sub
        End If

        If txtRegUsername.Text.Trim() = "" Then
            MessageBox.Show("Please enter a username.")
            txtRegUsername.Focus()
            Exit Sub
        End If

        If txtRegEmail.Text.Trim() = "" Then
            MessageBox.Show("Please enter your email.")
            txtRegEmail.Focus()
            Exit Sub
        End If

        If txtRegPassword.Text = "" Then
            MessageBox.Show("Please enter a password.")
            txtRegPassword.Focus()
            Exit Sub
        End If

        Try

            Using connection As New OleDbConnection(connectionString)

                connection.Open()

                Dim query As String =
                    "INSERT INTO Users (FullName, UserName, Email, [Password]) VALUES (?, ?, ?, ?)"

                Using command As New OleDbCommand(query, connection)

                    command.Parameters.AddWithValue("@fullname", txtFullName.Text.Trim())
                    command.Parameters.AddWithValue("@username", txtRegUsername.Text.Trim())
                    command.Parameters.AddWithValue("@email", txtRegEmail.Text.Trim())
                    command.Parameters.AddWithValue("@password", txtRegPassword.Text)

                    command.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show("Account created successfully.")

            txtFullName.Clear()
            txtRegUsername.Clear()
            txtRegEmail.Clear()
            txtRegPassword.Clear()

            pnlRegistration.Visible = False

        Catch ex As Exception

            MessageBox.Show(
                "Registration error: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try
    End Sub

    Private Sub lblRegPassword_Click(sender As Object, e As EventArgs) Handles lblRegPassword.Click

    End Sub

    Private Sub lblRegEmail_Click(sender As Object, e As EventArgs) Handles lblRegEmail.Click

    End Sub

    Private Sub lblRegUsername_Click(sender As Object, e As EventArgs) Handles lblRegUsername.Click

    End Sub
End Class