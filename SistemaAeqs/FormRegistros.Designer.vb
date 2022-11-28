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
        Me.Login = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'empleados
        '
        Me.empleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empleados.Location = New System.Drawing.Point(136, 86)
        Me.empleados.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.empleados.Name = "empleados"
        Me.empleados.Size = New System.Drawing.Size(119, 39)
        Me.empleados.TabIndex = 0
        Me.empleados.Text = "Empleados"
        Me.empleados.UseVisualStyleBackColor = True
        '
        'clientes
        '
        Me.clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientes.Location = New System.Drawing.Point(137, 139)
        Me.clientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.clientes.Name = "clientes"
        Me.clientes.Size = New System.Drawing.Size(119, 39)
        Me.clientes.TabIndex = 1
        Me.clientes.Text = "Clientes"
        Me.clientes.UseVisualStyleBackColor = True
        '
        'pedido
        '
        Me.pedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pedido.Location = New System.Drawing.Point(137, 192)
        Me.pedido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pedido.Name = "pedido"
        Me.pedido.Size = New System.Drawing.Size(119, 39)
        Me.pedido.TabIndex = 2
        Me.pedido.Text = "Pedidos"
        Me.pedido.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.Login.AutoSize = True
        Me.Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.Location = New System.Drawing.Point(132, 31)
        Me.Login.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(125, 29)
        Me.Login.TabIndex = 8
        Me.Login.Text = "Registros"
        Me.Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormRegistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 330)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.pedido)
        Me.Controls.Add(Me.clientes)
        Me.Controls.Add(Me.empleados)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormRegistros"
        Me.Text = "AEQS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents empleados As System.Windows.Forms.Button
    Friend WithEvents clientes As System.Windows.Forms.Button
    Friend WithEvents pedido As System.Windows.Forms.Button
    Friend WithEvents Login As Label
End Class
