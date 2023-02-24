Public Class frmTickets
    Private Sub llenarTickets()
        Dim sql As String = $"select id_garaje AS Garaje, id_ticket AS Nro_Ticket,
patente AS Patente, entrada AS Entrada, salida AS Salida,
total As Total, estado As Estado FROM tickets WHERE id_garaje = {grjSel}"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("Tickets")
        adp.Fill(ds.Tables("Tickets"))
        Me.dgvTickets.DataSource = ds.Tables("Tickets")
    End Sub
    Private Sub frmTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblNombreGarajeTickets.Text = grjNom.ToUpper()
        llenarTickets()
    End Sub
End Class