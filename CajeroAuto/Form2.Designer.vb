<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtMDepositar = New System.Windows.Forms.TextBox()
        Me.TxtRetirar = New System.Windows.Forms.TextBox()
        Me.BtnDepositar = New System.Windows.Forms.Button()
        Me.BtnRetirar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TxtSaldoCuenta = New System.Windows.Forms.TextBox()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.Controls.Add(Me.BtnCerrar)
        Me.Panel1.Controls.Add(Me.BtnMinimizar)
        Me.Panel1.Controls.Add(Me.TxtSaldoCuenta)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(687, 120)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Monto a Depositar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(65, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Monto a Retirar"
        '
        'TxtMDepositar
        '
        Me.TxtMDepositar.Location = New System.Drawing.Point(48, 199)
        Me.TxtMDepositar.Name = "TxtMDepositar"
        Me.TxtMDepositar.Size = New System.Drawing.Size(227, 26)
        Me.TxtMDepositar.TabIndex = 5
        '
        'TxtRetirar
        '
        Me.TxtRetirar.Location = New System.Drawing.Point(48, 317)
        Me.TxtRetirar.Name = "TxtRetirar"
        Me.TxtRetirar.Size = New System.Drawing.Size(216, 26)
        Me.TxtRetirar.TabIndex = 6
        '
        'BtnDepositar
        '
        Me.BtnDepositar.BackColor = System.Drawing.SystemColors.Info
        Me.BtnDepositar.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDepositar.Location = New System.Drawing.Point(326, 173)
        Me.BtnDepositar.Name = "BtnDepositar"
        Me.BtnDepositar.Size = New System.Drawing.Size(138, 75)
        Me.BtnDepositar.TabIndex = 7
        Me.BtnDepositar.Text = "Depositar"
        Me.BtnDepositar.UseVisualStyleBackColor = False
        '
        'BtnRetirar
        '
        Me.BtnRetirar.BackColor = System.Drawing.SystemColors.Info
        Me.BtnRetirar.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRetirar.Location = New System.Drawing.Point(326, 274)
        Me.BtnRetirar.Name = "BtnRetirar"
        Me.BtnRetirar.Size = New System.Drawing.Size(138, 75)
        Me.BtnRetirar.TabIndex = 8
        Me.BtnRetirar.Text = "Retirar"
        Me.BtnRetirar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 29)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Saldo de cuenta"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'TxtSaldoCuenta
        '
        Me.TxtSaldoCuenta.Location = New System.Drawing.Point(47, 52)
        Me.TxtSaldoCuenta.Name = "TxtSaldoCuenta"
        Me.TxtSaldoCuenta.Size = New System.Drawing.Size(198, 26)
        Me.TxtSaldoCuenta.TabIndex = 10
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.Blue
        Me.BtnCerrar.Image = Global.CajeroAuto.My.Resources.Resources.Icono_cerrar_FN
        Me.BtnCerrar.Location = New System.Drawing.Point(599, 15)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(75, 63)
        Me.BtnCerrar.TabIndex = 12
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnMinimizar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnMinimizar.Image = Global.CajeroAuto.My.Resources.Resources.Icono_Minimizar
        Me.BtnMinimizar.Location = New System.Drawing.Point(508, 15)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(85, 63)
        Me.BtnMinimizar.TabIndex = 11
        Me.BtnMinimizar.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 508)
        Me.Controls.Add(Me.BtnRetirar)
        Me.Controls.Add(Me.BtnDepositar)
        Me.Controls.Add(Me.TxtMDepositar)
        Me.Controls.Add(Me.TxtRetirar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtMDepositar As TextBox
    Friend WithEvents TxtRetirar As TextBox
    Friend WithEvents BtnDepositar As Button
    Friend WithEvents BtnRetirar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TxtSaldoCuenta As TextBox
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents BtnCerrar As Button
End Class
