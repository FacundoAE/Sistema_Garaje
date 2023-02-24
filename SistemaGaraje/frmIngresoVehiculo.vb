Public Class frmIngresoVehiculo
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "INSERT INTO tickets(id_garaje,id_ticket,patente,entrada,estado) VALUES(" & Me.txbIdGaraje.Text & ",(SELECT COUNT(DISTINCT(id_ticket))+1 FROM tickets WHERE id_garaje = " & Me.txbIdGaraje.Text & "),'" & Me.txbPatente.Text & "', SYSDATETIME()," & "'abierto'" & ")"
        cmd.CommandText = sql

        If Me.txbIdGaraje.Text <> "" And IsNumeric(Me.txbIdGaraje.Text) = True Then
            If Me.txbPatente.Text <> "" Then
                Try
                    cmd.ExecuteNonQuery()
                    Me.txbPatente.Clear()
                    obtenerUltimoTicket()
                    Console.Beep()
                    Dim frm As New frmImprimirEntrada
                    frm.ShowDialog()
                    'Me.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("Debe ingresar una patente")
            End If
        Else
            MsgBox("Primero debes seleccionar un garaje")
        End If

    End Sub

    Private Sub obtenerUltimoTicket()

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"SELECT MAX(id_ticket) FROM tickets WHERE id_garaje = {Me.txbIdGaraje.Text}"
        cmd.CommandText = sql

        dr = cmd.ExecuteReader()

        Try
            If dr.HasRows Then
                While dr.Read
                    nroTick = dr(0).ToString
                End While
            Else
                MsgBox("No se pudo obtener el ultimo ticket", MsgBoxStyle.Critical, "Error")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub frmIngresoVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If grjSel > 0 Then
            Me.txbIdGaraje.Text = grjSel
        End If
    End Sub
End Class