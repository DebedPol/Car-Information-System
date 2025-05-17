Imports Microsoft.Data.SqlClient

Public Class Login
    Private Sub EnterBtn_Click(sender As Object, e As EventArgs) Handles EnterBtn.Click
        Dim connectionString As String = "Data Source=DAVID-PAUL;Initial Catalog=CarDB;Integrated Security=True;TrustServerCertificate=True"

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", UsernameTextField.Text.Trim())
                    cmd.Parameters.AddWithValue("@password", PasswordTextField.Text.Trim())

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("Login Successful!")
                        'palitan na lng yung next form'
                        Dim dashboard As New Form2()
                        dashboard.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        PasswordTextField.Clear()
                        PasswordTextField.Focus()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Application.Exit()
    End Sub

End Class
