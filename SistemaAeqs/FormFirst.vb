
Public Class FormFirst



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If (TextBoxUser.Text = "admin" And TextBoxPassword.Text = "admin") Then
            Me.Hide()
            FormInicio.Show()
        Else
            message.Text = "Usuario o contraseña incorrectos."
            message.ForeColor = Color.Red
        End If
    End Sub

    Private Sub FormFirst_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBoxUser.Text = ""
        TextBoxPassword.Text = ""
    End Sub
End Class