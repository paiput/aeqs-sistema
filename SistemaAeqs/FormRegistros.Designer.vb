<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistros
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.empleados = New System.Windows.Forms.Button()
        Me.clientes = New System.Windows.Forms.Button()
        Me.pedido = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'empleados
        '
        Me.empleados.Location = New System.Drawing.Point(105, 30)
        Me.empleados.Name = "empleados"
        Me.empleados.Size = New System.Drawing.Size(75, 23)
        Me.empleados.TabIndex = 0
        Me.empleados.Text = "Empleados"
        Me.empleados.UseVisualStyleBackColor = True
        '
        'clientes
        '
        Me.clientes.Location = New System.Drawing.Point(105, 95)
        Me.clientes.Name = "clientes"
        Me.clientes.Size = New System.Drawing.Size(75, 23)
        Me.clientes.TabIndex = 1
        Me.clientes.Text = "Clientes"
        Me.clientes.UseVisualStyleBackColor = True
        '
        'pedido
        '
        Me.pedido.Location = New System.Drawing.Point(105, 159)
        Me.pedido.Name = "pedido"
        Me.pedido.Size = New System.Drawing.Size(75, 23)
        Me.pedido.TabIndex = 2
        Me.pedido.Text = "Pedidos"
        Me.pedido.UseVisualStyleBackColor = True
        '
        'FormRegistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 268)
        Me.Controls.Add(Me.pedido)
        Me.Controls.Add(Me.clientes)
        Me.Controls.Add(Me.empleados)
        Me.Name = "FormRegistros"
        Me.Text = "AEQS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents empleados As System.Windows.Forms.Button
    Friend WithEvents clientes As System.Windows.Forms.Button
    Friend WithEvents pedido As System.Windows.Forms.Button
End Class
