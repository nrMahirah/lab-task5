Public Class FormLogin
    Public username As String
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPass.CheckedChanged
        If CheckBoxPass.Checked = True Then
            txtPassword.UseSystemPasswordChar = True     'Show password 
        Else
            txtPassword.UseSystemPasswordChar = False     'Password will be hide
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try  'Try and Catch
            Dim username As String = txtUsername.Text
            Dim num As Integer
            Dim pass As String
            pass = txtPassword.Text
            num = pass.Length

            If username.Length < 8 Then
                LabelErrorUser.Text = "*Username too short"   'Error will display for username
            ElseIf pass.Length < 8 Then
                LabelErrorPass.Text = "*Passwords must be at least 8 characters long"  'Error will display if enter less than 8
            Else
                username = txtUsername.Text.Remove(0, 4)
                Form2.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()  'Exit the application
    End Sub
End Class
