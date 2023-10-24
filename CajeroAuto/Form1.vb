Public Class Form1

    Dim intentosFallitos As Integer
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close() 'cierra el formulario.
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized 'minimiza el formulario.
    End Sub

    Private intentosFallidos As Integer = 0 'se declara la variable intentosFallidos.

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click


        If intentosFallidos < 4 Then  'va a verificar que el numero de intentos sean menor que cuatro que es el limite.

            Dim Ncuenta As String = TxtNTarjeta.Text  'se obtiene el número de cuenta ingresado.
            Dim PIN As String = TxtPIN.Text  'se obtiene el PIN ingresado.

            If Ncuenta = "901234" And PIN = "1267" Then ' Si los datos son correctos puede ingresar.

                MessageBox.Show("Acceso autorizado")  'mensaje de acceso autorizado.
                MessageBox.Show("BIENVENIDO A PERMATABANK")  ' mensaje de bienvenida.
                Form2.ShowDialog()  'abre el formulario Form2 para poder hacer los depositos y retiros.
            Else
                intentosFallidos += 1  'se aumenta el contador de los intentos fallidos.
                MessageBox.Show("Error, los datos de su tarjeta no coinciden. Intento " & intentosFallidos & " de 4")

                'si alcalnza el limite de intentos fallidos se bloquea el programa.
                If intentosFallidos = 4 Then
                    TxtNTarjeta.Enabled = False
                    TxtPIN.Enabled = False
                    BtnLogin.Enabled = False
                    MessageBox.Show("Has alcanzado el número máximo de intentos fallidos. Contacta al servicio al cliente para desbloquear tu cuenta.")
                End If
            End If
        End If
    End Sub



    Private Sub BtnBorrarE_Click(sender As Object, e As EventArgs) Handles BtnBorrarE.Click
        'se borran los espacios de los TextBox
        TxtNTarjeta.Clear()
        TxtPIN.Clear()
    End Sub

    Private Sub TxtNTarjeta_TextChanged(sender As Object, e As EventArgs) Handles TxtNTarjeta.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
