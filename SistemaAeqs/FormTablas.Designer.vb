<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTablas
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
        Me.Login = New System.Windows.Forms.Label()
        Me.pedido = New System.Windows.Forms.Button()
        Me.clientes = New System.Windows.Forms.Button()
        Me.empleados = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Login
        '
        Me.Login.AutoSize = True
        Me.Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.Location = New System.Drawing.Point(96, 49)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(72, 24)
        Me.Login.TabIndex = 12
        Me.Login.Text = "Tablas"
        Me.Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pedido
        '
        Me.pedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pedido.Location = New System.Drawing.Point(100, 180)
        Me.pedido.Name = "pedido"
        Me.pedido.Size = New System.Drawing.Size(89, 32)
        Me.pedido.TabIndex = 11
        Me.pedido.Text = "Pedidos"
        Me.pedido.UseVisualStyleBackColor = True
        '
        'clientes
        '
        Me.clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientes.Location = New System.Drawing.Point(100, 137)
        Me.clientes.Name = "clientes"
        Me.clientes.Size = New System.Drawing.Size(89, 32)
        Me.clientes.TabIndex = 10
        Me.clientes.Text = "Clientes"
        Me.clientes.UseVisualStyleBackColor = True
        '
        'empleados
        '
        Me.empleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empleados.Location = New System.Drawing.Point(99, 94)
        Me.empleados.Name = "empleados"
        Me.empleados.Size = New System.Drawing.Size(89, 32)
        Me.empleados.TabIndex = 9
        Me.empleados.Text = "Empleados"
        Me.empleados.UseVisualStyleBackColor = True
        '
        'FormTablas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.pedido)
        Me.Controls.Add(Me.clientes)
        Me.Controls.Add(Me.empleados)
        Me.Name = "FormTablas"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Login As System.Windows.Forms.Label
    Friend WithEvents pedido As System.Windows.Forms.Button
    Friend WithEvents clientes As System.Windows.Forms.Button
    Friend WithEvents empleados As System.Windows.Forms.Button
End Class
