Public Class FormRegistros
    Private Sub FormEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Empleados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empleados.Click
        Dim data As New Dictionary(Of String, String)
        data.Add("ID", "ID")
        data.Add("DNI", "DNI")
        data.Add("Nombre", "Nombre")
        data.Add("Apellido", "Apellido")
        data.Add("Mail", "Mail")
        data.Add("Telefono", "Telefono")
        data.Add("Direccion", "Direccion")
        Modal_REmpleados.Title = "Empleados"
        Modal_REmpleados.Data = Data
        Modal_REmpleados.Show()
    End Sub

    Private Sub clientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clientes.Click
        Dim data As New Dictionary(Of String, String)
        data.Add("ID", "ID")
        data.Add("DNI", "DNI")
        data.Add("Nombre", "Nombre")
        data.Add("Apellido", "Apellido")
        data.Add("Mail", "Mail")
        data.Add("Telefono", "Telefono")
        data.Add("Direccion", "Direccion")
        Modal_REmpleados.Title = "Clientes"
        Modal_REmpleados.Data = data
        Modal_REmpleados.Show()
    End Sub

    Private Sub pedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pedido.Click
        Dim data As New Dictionary(Of String, String)
        data.Add("ID", "ID")
        data.Add("IDCliente", "IDCliente")
        data.Add("PresupuestoMin", "PresupuestoMin")
        data.Add("PresupuestoMax", "PresupuestoMax")
        data.Add("Aprobado", "Aprobado")
        data.Add("Fecha", "Fecha")
        Modal_REmpleados.Title = "Pedidos"
        Modal_REmpleados.Data = data
        Modal_REmpleados.Show()

    End Sub
End Class