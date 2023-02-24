Public Class frmMenu
    Private Sub desactivarPlazas()
        Me.lblSeparador.Enabled = False
        Me.lblTotal.Enabled = False
        Me.lblUso.Enabled = False
        Me.lblPlazas.Enabled = False
        Me.lblPlazasTotales.Enabled = False
        Me.lblPlazasUsadas.Enabled = False
    End Sub
    Private Sub activarPlazas()
        Me.lblSeparador.Enabled = True
        Me.lblTotal.Enabled = True
        Me.lblUso.Enabled = True
        Me.lblPlazas.Enabled = True
        Me.lblPlazasTotales.Enabled = True
        Me.lblPlazasUsadas.Enabled = True
    End Sub

    Private Sub IngresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoToolStripMenuItem.Click
        If grjSel > 0 Then
            Dim frmIngresoVehiculo As New frmIngresoVehiculo
            frmIngresoVehiculo.ShowDialog()
        Else
            MsgBox("Primero debes seleccionar un garaje")
        End If
    End Sub

    Private Sub SalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaToolStripMenuItem.Click
        If grjSel > 0 Then
            Dim frmSalidaVehiculo As New frmSalidaVehiculo
            frmSalidaVehiculo.ShowDialog()
        Else
            MsgBox("Primero debes seleccionar un garaje")
        End If
    End Sub

    Private Sub ReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteToolStripMenuItem.Click
        If grjSel > 0 Then
            Dim frmTickets As New frmTickets
            frmTickets.ShowDialog()
        Else
            MsgBox("Primero debes seleccionar un garaje")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblHora.Text = DateTime.Now.ToString("hh:mm:ss")
        Me.lblFecha.Text = DateTime.Now.ToShortDateString()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Timer1.Enabled = True
        desactivarPlazas()
    End Sub

    Private Sub DatosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DatosToolStripMenuItem.Click
        Dim frmDatosGaraje As New frmDatosGaraje
        frmDatosGaraje.ShowDialog()
    End Sub
    Private Sub ElegirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElegirToolStripMenuItem.Click
        Dim frmSeleccionarGaraje As New frmSeleccionarGaraje
        frmSeleccionarGaraje.ShowDialog()
    End Sub

    Private Sub frmMenu_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        If grjNom <> "" Then
            Me.lblNombreSistema.Text = grjNom.ToUpper()
            activarPlazas()
            consultarPlazasTotales()
            consultarPlazasUsadas()
        End If
    End Sub
    Private Sub consultarPlazasTotales()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"SELECT plazas FROM garajes WHERE id_garaje = {grjSel}"
        cmd.CommandText = sql

        dr = cmd.ExecuteReader()

        Try
            If dr.HasRows Then
                While dr.Read
                    Me.lblPlazasTotales.Text = dr(0).ToString
                End While
            Else
                MsgBox("Error al consultar la cantidad de plazas disponibles")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub consultarPlazasUsadas()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"SELECT COUNT(id_ticket) FROM tickets WHERE id_garaje = {grjSel} AND estado = 'abierto'"
        cmd.CommandText = sql

        dr = cmd.ExecuteReader()

        Try
            If dr.HasRows Then
                While dr.Read
                    Me.lblPlazasUsadas.Text = dr(0).ToString
                End While
            Else
                MsgBox("Error al consultar la cantidad de plazas disponibles")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        If grjSel > 0 Then
            Dim frmReImprimir As New frmReImprimir
            frmReImprimir.ShowDialog()
        Else
            MsgBox("Primero debes seleccionar un garaje")
        End If
    End Sub

    Private Sub IndividualesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndividualesToolStripMenuItem.Click
        If grjSel > 0 Then
            Dim frmIndividuales As New frmIndividuales
            frmIndividuales.ShowDialog()
        Else
            MsgBox("Primero debes seleccionar un garaje")
        End If
    End Sub

    Private Sub ComparaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComparaciónToolStripMenuItem.Click
        If grjSel > 0 Then
            Dim frmComparar As New frmComparar
            frmComparar.ShowDialog()
        Else
            MsgBox("Primero debes seleccionar un garaje")
        End If
    End Sub
End Class