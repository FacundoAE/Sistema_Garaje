Public Class frmSeleccionarGaraje
    Private Sub frmSeleccionarGaraje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGarajes()
    End Sub

    Private Sub llenarGarajes()
        Dim sql As String = "SELECT * FROM garajes"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("Garajes")
        adp.Fill(ds.Tables("Garajes"))
        Me.dgvElegirGaraje.DataSource = ds.Tables("Garajes")
    End Sub

    Private Sub dgvElegirGaraje_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvElegirGaraje.KeyDown
        If e.KeyCode = Keys.Enter Then
            grjSel = Me.dgvElegirGaraje.CurrentRow.Cells(0).Value.ToString
            grjNom = Me.dgvElegirGaraje.CurrentRow.Cells(1).Value.ToString
            MsgBox("Ahora estás en el garaje: " & Me.dgvElegirGaraje.CurrentRow.Cells(1).Value.ToString)
            Me.Close()
        End If
    End Sub
    Private Sub dgvElegirGaraje_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvElegirGaraje.CellClick
        grjSel = Me.dgvElegirGaraje.CurrentRow.Cells(0).Value.ToString
        grjNom = Me.dgvElegirGaraje.CurrentRow.Cells(1).Value.ToString
        MsgBox("Ahora estás en el garaje: " & Me.dgvElegirGaraje.CurrentRow.Cells(1).Value.ToString)
        Me.Close()
    End Sub
End Class