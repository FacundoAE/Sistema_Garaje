Public Class frmSalidaVehiculo
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"UPDATE tickets SET salida = SYSDATETIME() WHERE id_ticket = {Me.txbNroTicket.Text} AND id_garaje = {Me.txbIdGaraje.Text} AND estado = 'abierto'"
        cmd.CommandText = sql

        If Me.txbNroTicket.Text <> "" And IsNumeric(Me.txbNroTicket.Text) = True Then
            Try
                cmd.ExecuteNonQuery()
                calcularTotal()
                cerrarTicket()
                nroTick = Me.txbNroTicket.Text
                Me.txbNroTicket.Clear()
                Console.Beep()
                Dim frm As New frmImprimirSalida
                frm.ShowDialog()
                'Me.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Debe ingresar un numero de ticket")
        End If
    End Sub
    Private Sub frmSalidaVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If grjSel > 0 Then
            Me.txbIdGaraje.Text = grjSel
        End If
    End Sub
    Private Sub calcularTotal()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"UPDATE tickets SET total = CAST(DATEDIFF(minute,entrada,salida) As Decimal) / 60 * (SELECT precioxhora FROM garajes WHERE id_garaje = {Me.txbIdGaraje.Text})
        WHERE id_ticket = {Me.txbNroTicket.Text} AND id_garaje = {Me.txbIdGaraje.Text} AND estado = 'abierto'"
        cmd.CommandText = sql

        If Me.txbNroTicket.Text <> "" And IsNumeric(Me.txbNroTicket.Text) = True Then
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Debe ingresar un numero de ticket")
        End If
    End Sub

    Private Sub cerrarTicket()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"UPDATE tickets SET estado = 'cerrado' FROM tickets
        WHERE id_ticket = {Me.txbNroTicket.Text} AND id_garaje = {Me.txbIdGaraje.Text} AND estado = 'abierto'"
        cmd.CommandText = sql

        If Me.txbNroTicket.Text <> "" And IsNumeric(Me.txbNroTicket.Text) = True Then
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Debe ingresar un numero de ticket")
        End If
    End Sub

End Class