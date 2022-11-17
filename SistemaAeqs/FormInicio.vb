Public Class FormInicio

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCrearSolicitud.Click
        Me.Hide()
        FormSolicitudLogin.Show()
    End Sub

    Private Sub FormInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub registro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registro.Click
        Me.Hide()
        FormRegistros.Show()
    End Sub
End Class
