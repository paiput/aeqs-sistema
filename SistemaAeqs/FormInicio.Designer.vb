<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInicio
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
        Me.ButtonRegistros = New System.Windows.Forms.Button()
        Me.ButtonCerrarSesion = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido a AEQS"
        '
        'ButtonRegistros
        '
        Me.ButtonRegistros.Location = New System.Drawing.Point(95, 70)
        Me.ButtonRegistros.Name = "ButtonRegistros"
        Me.ButtonRegistros.Size = New System.Drawing.Size(83, 36)
        Me.ButtonRegistros.TabIndex = 3
        Me.ButtonRegistros.Text = "Registros"
        Me.ButtonRegistros.UseVisualStyleBackColor = True
        '
        'ButtonCerrarSesion
        '
        Me.ButtonCerrarSesion.Location = New System.Drawing.Point(95, 154)
        Me.ButtonCerrarSesion.Name = "ButtonCerrarSesion"
        Me.ButtonCerrarSesion.Size = New System.Drawing.Size(83, 36)
        Me.ButtonCerrarSesion.TabIndex = 4
        Me.ButtonCerrarSesion.Text = "Cerrar Sesión"
        Me.ButtonCerrarSesion.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(95, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 36)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Tablas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 235)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonCerrarSesion)
        Me.Controls.Add(Me.ButtonRegistros)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormInicio"
        Me.Text = "AEQS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonRegistros As System.Windows.Forms.Button
    Friend WithEvents ButtonCerrarSesion As Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
