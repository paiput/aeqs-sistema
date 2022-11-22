Public Class FormInicio

    Private Sub FormInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub registro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRegistros.Click
        Me.Hide()
        FormRegistros.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonCerrarSesion.Click
        Me.Hide()
        FormFirst.Show()
    End Sub
End Class
