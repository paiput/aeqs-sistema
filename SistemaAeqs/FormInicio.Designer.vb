﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ButtonCrearSolicitud = New System.Windows.Forms.Button()
        Me.ButtonEvaluarPresupuesto = New System.Windows.Forms.Button()
        Me.registro = New System.Windows.Forms.Button()
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
        'ButtonCrearSolicitud
        '
        Me.ButtonCrearSolicitud.Location = New System.Drawing.Point(75, 110)
        Me.ButtonCrearSolicitud.Name = "ButtonCrearSolicitud"
        Me.ButtonCrearSolicitud.Size = New System.Drawing.Size(128, 47)
        Me.ButtonCrearSolicitud.TabIndex = 1
        Me.ButtonCrearSolicitud.Text = "Crear solicitud de presupuesto"
        Me.ButtonCrearSolicitud.UseVisualStyleBackColor = True
        '
        'ButtonEvaluarPresupuesto
        '
        Me.ButtonEvaluarPresupuesto.Location = New System.Drawing.Point(75, 163)
        Me.ButtonEvaluarPresupuesto.Name = "ButtonEvaluarPresupuesto"
        Me.ButtonEvaluarPresupuesto.Size = New System.Drawing.Size(128, 47)
        Me.ButtonEvaluarPresupuesto.TabIndex = 2
        Me.ButtonEvaluarPresupuesto.Text = "Evaluar presupuesto"
        Me.ButtonEvaluarPresupuesto.UseVisualStyleBackColor = True
        '
        'registro
        '
        Me.registro.Location = New System.Drawing.Point(215, 227)
        Me.registro.Name = "registro"
        Me.registro.Size = New System.Drawing.Size(57, 22)
        Me.registro.TabIndex = 3
        Me.registro.Text = "Registros"
        Me.registro.UseVisualStyleBackColor = True
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.registro)
        Me.Controls.Add(Me.ButtonEvaluarPresupuesto)
        Me.Controls.Add(Me.ButtonCrearSolicitud)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormInicio"
        Me.Text = "AEQS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonCrearSolicitud As System.Windows.Forms.Button
    Friend WithEvents ButtonEvaluarPresupuesto As System.Windows.Forms.Button
    Friend WithEvents registro As System.Windows.Forms.Button

End Class
