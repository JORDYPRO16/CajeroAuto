Imports System.Diagnostics.Eventing.Reader

Public Class Form2
    Dim saldo As Double = 0.0 'se declara una variable global con el nombre saldo.
    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized 'se utiliza para minimizar el formulario.
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close() ' se utiliza para cerrar el formulario.

    End Sub

    Private Sub TxtSCuenta_TextChanged(sender As Object, e As EventArgs) Handles TxtSaldoCuenta.TextChanged

    End Sub

    Private Sub BtnDepositar_Click(sender As Object, e As EventArgs) Handles BtnDepositar.Click

        Dim deposito As Double
        ' Verifica si lo que hay en el TxtMDepositar es un número válido y mayor que cero.
        If Double.TryParse(TxtMDepositar.Text.Replace(",", "."), deposito) AndAlso deposito > 0 Then
            saldo += deposito ' Se aumenta el saldo actual con el monto depositado.
            TxtSaldoCuenta.Text = saldo.ToString("C") ' Se actualiza el TxtSaldoCuenta con el nuevo saldo.
            TxtMDepositar.Clear() 'sirve para limpiar el TxtMDepositar.
        Else
            ' Si el monto ingresado no es válido, se muestra un mensaje de error.
            MessageBox.Show("Ingrese un monto válido para depositar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If




    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtSaldoCuenta.Text = saldo.ToString()  'Actualiza el TxtSaldoCuenta con el saldo actual.
    End Sub

    Private Sub BtnRetirar_Click(sender As Object, e As EventArgs) Handles BtnRetirar.Click
        Dim retiro As Double  'se declara la variable retiro.



        'verifica si el numero en TxtRetirar es un número válido y mayor que cero.
        If Double.TryParse(TxtRetirar.Text.Replace(",", "."), retiro) AndAlso retiro > 0 Then


            If saldo >= retiro Then
                ' si hay el saldo suficiente si se puede realizar el retiro.

                saldo -= retiro  ' Se reduce el saldo qye hay por el monto retirado.
                TxtSaldoCuenta.Text = saldo.ToString("C")  'Se actualiza el TxtSaldoCuenta con el nuevo saldo.
                TxtRetirar.Clear()  'limpia el TxtRetirar.
            Else
                ' Si no hay suficiente saldo, se muestra un mensaje de error.
                MessageBox.Show("No tiene el dinero suficiente para realizar el retiro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ' Si el monto que se ingreso no es válido, se muestra un mensaje de error.
            MessageBox.Show("Ingrese un monto válido para retirar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class