Public Class FormInicio

    Private Sub registro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRegistros.Click
        Me.Hide()
        FormRegistros.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonCerrarSesion.Click
        Me.Hide()
        FormFirst.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        FormRegistros.Show()
    End Sub
End Class
