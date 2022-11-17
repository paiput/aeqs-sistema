<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSolicitudLogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonRegistro = New System.Windows.Forms.Button()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Solicitud de presupuesto"
        '
        'ButtonRegistro
        '
        Me.ButtonRegistro.Location = New System.Drawing.Point(79, 153)
        Me.ButtonRegistro.Name = "ButtonRegistro"
        Me.ButtonRegistro.Size = New System.Drawing.Size(113, 38)
        Me.ButtonRegistro.TabIndex = 2
        Me.ButtonRegistro.Text = "Registrar cliente"
        Me.ButtonRegistro.UseVisualStyleBackColor = True
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Location = New System.Drawing.Point(79, 107)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(113, 40)
        Me.ButtonLogin.TabIndex = 3
        Me.ButtonLogin.Text = "Crear solicitud para cliente existente"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'FormSolicitudLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.ButtonRegistro)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormSolicitudLogin"
        Me.Text = "AEQS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonRegistro As System.Windows.Forms.Button
    Friend WithEvents ButtonLogin As System.Windows.Forms.Button
End Class
