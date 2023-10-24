<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNTarjeta = New System.Windows.Forms.TextBox()
        Me.TxtPIN = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnBorrarE = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cajero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(328, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingrese numero de tarjeta"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BtnMinimizar)
        Me.Panel1.Controls.Add(Me.BtnCerrar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(569, 117)
        Me.Panel1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(136, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ingrese su PIN"
        '
        'TxtNTarjeta
        '
        Me.TxtNTarjeta.Location = New System.Drawing.Point(122, 222)
        Me.TxtNTarjeta.Name = "TxtNTarjeta"
        Me.TxtNTarjeta.Size = New System.Drawing.Size(278, 26)
        Me.TxtNTarjeta.TabIndex = 5
        '
        'TxtPIN
        '
        Me.TxtPIN.Location = New System.Drawing.Point(122, 338)
        Me.TxtPIN.Name = "TxtPIN"
        Me.TxtPIN.Size = New System.Drawing.Size(278, 26)
        Me.TxtPIN.TabIndex = 6
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.Lime
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLogin.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.Location = New System.Drawing.Point(52, 419)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(174, 81)
        Me.BtnLogin.TabIndex = 7
        Me.BtnLogin.Text = "Registrarse"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'BtnBorrarE
        '
        Me.BtnBorrarE.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnBorrarE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBorrarE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrarE.Location = New System.Drawing.Point(349, 419)
        Me.BtnBorrarE.Name = "BtnBorrarE"
        Me.BtnBorrarE.Size = New System.Drawing.Size(157, 81)
        Me.BtnBorrarE.TabIndex = 8
        Me.BtnBorrarE.Text = "Borrar espacios"
        Me.BtnBorrarE.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.CajeroAuto.My.Resources.Resources._2425815_bank_indonesia_permata_permatabank_syariah_icon
        Me.PictureBox1.Location = New System.Drawing.Point(3, -16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnMinimizar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnMinimizar.Image = Global.CajeroAuto.My.Resources.Resources.Icono_Minimizar
        Me.BtnMinimizar.Location = New System.Drawing.Point(410, 21)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(75, 66)
        Me.BtnMinimizar.TabIndex = 4
        Me.BtnMinimizar.UseVisualStyleBackColor = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.Blue
        Me.BtnCerrar.Image = Global.CajeroAuto.My.Resources.Resources.Icono_cerrar_FN
        Me.BtnCerrar.Location = New System.Drawing.Point(482, 21)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(75, 66)
        Me.BtnCerrar.TabIndex = 4
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 583)
        Me.Controls.Add(Me.BtnBorrarE)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TxtPIN)
        Me.Controls.Add(Me.TxtNTarjeta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNTarjeta As TextBox
    Friend WithEvents TxtPIN As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnBorrarE As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
