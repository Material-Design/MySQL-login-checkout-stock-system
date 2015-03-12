' You must have MySQL connector installed to run this code!
Imports MySql.Data.MySqlClient
Class form1
    Dim conn As MySqlConnection = auth()
    Public Function auth() As MySqlConnection
        'replace # with the appropriate MySQL server values
        Return New MySqlConnection("server=#;user id=#;password=#;database=#")
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            ' replace # with your table name.
            ' inside the table make sure your username and password fields are called "user" and "pass"
            ' otherwise you may have to edit this project to make it work
            Dim sqlquery = "SELECT user, pass FROM # Where user='" & TextBox1.Text & "' and pass='" & TextBox2.Text & "'"
            Dim myCommand As New MySqlCommand()
            myCommand.Connection = conn
            myCommand.CommandText = sqlquery
            Dim myData As MySqlDataReader
            myData = myCommand.ExecuteReader()
            If myData.HasRows = 0 Then
                MessageBox.Show("Your login details are not a valid.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox2.Text = ""
                conn.Close()
            Else
                MainForm.Show()
                conn.Close()
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class