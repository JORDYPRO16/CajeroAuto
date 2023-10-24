Imports System.Diagnostics.Eventing.Reader

Public Class Form2
    Dim saldo As Double = 0.0
    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub TxtSCuenta_TextChanged(sender As Object, e As EventArgs) Handles TxtSaldoCuenta.TextChanged

    End Sub

    Private Sub BtnDepositar_Click(sender As Object, e As EventArgs) Handles BtnDepositar.Click

        Dim deposito As Double

        If Double.TryParse(TxtMDepositar.Text.Replace(",", "."), deposito) AndAlso deposito > 0 Then
            saldo += deposito
            TxtSaldoCuenta.Text = saldo.ToString("C")
            TxtMDepositar.Clear()
        Else
            MessageBox.Show("Ingrese un monto válido para depositar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If




    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtSaldoCuenta.Text = saldo.ToString()
    End Sub

    Private Sub BtnRetirar_Click(sender As Object, e As EventArgs) Handles BtnRetirar.Click
        Dim retiro As Double

        If Double.TryParse(TxtRetirar.Text.Replace(",", "."), retiro) AndAlso retiro > 0 Then
            If saldo >= retiro Then
                saldo -= retiro
                TxtSaldoCuenta.Text = saldo.ToString("C")
                TxtRetirar.Clear()
            Else
                MessageBox.Show("No tiene suficiente saldo para realizar el retiro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Ingrese un monto válido para retirar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class