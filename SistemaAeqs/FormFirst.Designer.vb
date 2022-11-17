<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFirst
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
        Me.user = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.message = New System.Windows.Forms.Label()
        Me.Login = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'user
        '
        Me.user.Location = New System.Drawing.Point(115, 78)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(100, 20)
        Me.user.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contraseña"
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(115, 104)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(100, 20)
        Me.pass.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(105, 149)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'message
        '
        Me.message.AutoSize = True
        Me.message.Location = New System.Drawing.Point(91, 131)
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(0, 13)
        Me.message.TabIndex = 6
        '
        'Login
        '
        Me.Login.AutoSize = True
        Me.Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.Location = New System.Drawing.Point(111, 29)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(62, 24)
        Me.Login.TabIndex = 7
        Me.Login.Text = "Login"
        Me.Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormFirst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 201)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.message)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.user)
        Me.Name = "FormFirst"
        Me.Text = "Ingresar AEQS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents user As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pass As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents message As System.Windows.Forms.Label
    Friend WithEvents Login As System.Windows.Forms.Label
End Class
