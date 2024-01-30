Imports System.Data
Imports System.Data.SqlClient
Imports System.Globalization

Public Class Form_login

    Public con As New SqlConnection("Data Source=LAPTOP-QDECFD8R\SQLEXPRESS01;Initial Catalog=expense;Integrated Security=True;Encrypt=False")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Login_btn_Click(sender As Object, e As EventArgs) Handles Login_btn.Click
        ' Call a method to handle login function
        PerformLogin()
    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        ' Close the application when the exit button is clicked
        Application.Exit()
    End Sub

    Private Sub PerformLogin()
        Try
            ' Open the database connection
            con.Open()

            ' Execute SQL command
            Dim sql As String = "SELECT * FROM users WHERE Username = @Username AND Password = @Password"
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@Username", username_txt.Text)
                cmd.Parameters.AddWithValue("@Password", Password_txt.Text)

                ' Execute the command
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                ' Check if there is a row with matching username and password
                If reader.HasRows Then
                    ' User is authenticated
                    MessageBox.Show("Login successful")
                    Me.Hide() ' To hide the login form
                    Mainform.Show() ' To link the main form to the login form
                    Mainform.Login_info1.Text = "User: " & username_txt.Text
                Else
                    ' User authentication failed
                    MessageBox.Show("Invalid username or password")
                End If

                ' Close the SqlDataReader
                reader.Close()
            End Using
        Catch ex As Exception
            ' Handle any exceptions that may occur during database operations
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the database connection in the finally block to ensure it's always closed
            con.Close()
        End Try
    End Sub

    Private Sub ShowPasswordCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordCheckBox.CheckedChanged
        ' Toggle the PasswordChar based on the CheckBox state
        If ShowPasswordCheckBox.Checked Then
            Password_txt.PasswordChar = ControlChars.NullChar ' Show characters
        Else
            Password_txt.PasswordChar = "*" ' Hide characters
        End If
    End Sub


    Private Sub Registerlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Registerlink.LinkClicked
        Dim registrationForm As New Form_register()
        Me.Hide()
        registrationForm.Show()
    End Sub

    Private Sub Remove_user_btn_Click(sender As Object, e As EventArgs) Handles Remove_user_btn.Click
        ' Get the username from the user (you may use a TextBox or another input method)
        Dim usernameToRemove As String = InputBox("Enter the username to remove:", "Remove User")

        ' Call the RemoveUser function
        RemoveUser(usernameToRemove)
    End Sub
    Private Sub RemoveUser(username As String)
        Try
            ' Open the database connection
            con.Open()

            ' Execute SQL command to delete user by username
            Dim sql As String = "DELETE FROM users WHERE Username = @Username"
            Using cmd As New SqlCommand(sql, con)
                ' Replace the parameter with the actual value
                cmd.Parameters.AddWithValue("@Username", username)

                ' Execute the command
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                ' Check if any rows were affected to determine if the user was deleted
                If rowsAffected > 0 Then
                    MessageBox.Show("User removed successfully")
                Else
                    MessageBox.Show("User not found or could not be removed")
                End If
            End Using
        Catch ex As Exception
            ' Handle any exceptions that may occur during database operations
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the database connection in the finally block to ensure it's always closed
            con.Close()
        End Try
    End Sub

    Private Sub Password_txt_TextChanged(sender As Object, e As EventArgs) Handles Password_txt.TextChanged
        Password_txt.PasswordChar = "*"
    End Sub
End Class
