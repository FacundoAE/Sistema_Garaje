Public Class frmDatosGaraje
    Private Sub limpiarTextBox()
        Me.txbId.Clear()
        Me.txbNombre.Clear()
        Me.txbDireccion.Clear()
        Me.txbLocalidad.Clear()
        Me.txbTelefono.Clear()
        Me.txbPrecio.Clear()
        Me.txbPlazas.Clear()
    End Sub
    Private Sub activarOpciones()
        Me.txbId.Enabled = True
        Me.txbNombre.Enabled = True
        Me.txbDireccion.Enabled = True
        Me.txbLocalidad.Enabled = True
        Me.txbTelefono.Enabled = True
        Me.txbPrecio.Enabled = True
        Me.txbPlazas.Enabled = True
        Me.btnAceptar.Enabled = True
    End Sub

    Private Sub desactivarOpciones()
        Me.txbId.Enabled = False
        Me.txbNombre.Enabled = False
        Me.txbDireccion.Enabled = False
        Me.txbLocalidad.Enabled = False
        Me.txbTelefono.Enabled = False
        Me.txbPrecio.Enabled = False
        Me.txbPlazas.Enabled = False
        Me.btnAceptar.Enabled = False
    End Sub

    Private Sub llenarGarajes()
        Dim sql As String = "SELECT * FROM garajes"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("Garajes")
        adp.Fill(ds.Tables("Garajes"))
        Me.dgvGarajes.DataSource = ds.Tables("Garajes")

    End Sub

    Private Sub frmDatosGaraje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGarajes()
        limpiarTextBox()
    End Sub

    Private Sub nuevoGaraje()

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "INSERT INTO garajes VALUES(" & Me.txbId.Text & ",'" & Me.txbNombre.Text & "','" & Me.txbDireccion.Text & "','" & Me.txbLocalidad.Text & "','" & Me.txbTelefono.Text & "'," & Me.txbPrecio.Text & "," & Me.txbPlazas.Text & ")"
        cmd.CommandText = sql

        If Me.txbId.Text <> "" And IsNumeric(Me.txbId.Text) = True And Me.txbPlazas.Text <> "" And IsNumeric(Me.txbPlazas.Text) = True Then
            If Me.txbNombre.Text <> "" And Me.txbDireccion.Text <> "" And Me.txbLocalidad.Text <> "" And Me.txbTelefono.Text <> "" And Me.txbPrecio.Text <> "" Then

                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarGarajes()
                    limpiarTextBox()
                    MsgBox("Garaje agregado correctamente")
                    desactivarOpciones()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            Else
                MsgBox("Debes completar todos los campos", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("El campo ID no puede estar vacío y debe ser un número al igual que las plazas.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub modificarGaraje()

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "UPDATE garajes SET nombre = '" & Me.txbNombre.Text & "', direccion = '" & Me.txbDireccion.Text & "', localidad = '" & Me.txbLocalidad.Text & "', telefono = '" & Me.txbTelefono.Text & "', precioxhora = " & Replace(Me.txbPrecio.Text, ",", ".") & ", plazas = " & Me.txbPlazas.Text & " WHERE id_garaje = " & Me.txbId.Text
        cmd.CommandText = sql

        If Me.txbId.Text <> "" And IsNumeric(Me.txbId.Text) = True And Me.txbPlazas.Text <> "" And IsNumeric(Me.txbPlazas.Text) = True Then
            If Me.txbNombre.Text <> "" And Me.txbDireccion.Text <> "" And Me.txbLocalidad.Text <> "" And Me.txbTelefono.Text <> "" And Me.txbPrecio.Text <> "" Then

                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarGarajes()
                    limpiarTextBox()
                    MsgBox("Garaje modificado correctamente")
                    desactivarOpciones()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            Else
                MsgBox("Debes completar todos los campos", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("El campo ID no puede estar vacío y debe ser un número.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub
    Private Sub eliminarGaraje()

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "DELETE FROM tickets WHERE id_garaje = " & Me.txbId.Text
        cmd.CommandText = sql

        If Me.txbId.Text <> "" And IsNumeric(Me.txbId.Text) = True Then

            Dim seguridad = MsgBox("Vas a dar de baja a ID: " & Me.txbId.Text & " Nombre: " & Me.txbNombre.Text & " - TICKETS TAMBIÉN SERÁN ELIMINADOS - ", vbOKCancel, "Seguridad")

            If seguridad = vbOKCancel Then
                Try
                    cmd.ExecuteNonQuery()
                    limpiarGarajes()
                    Console.Beep()
                    llenarGarajes()
                    limpiarTextBox()
                    MsgBox("Garaje y sus tickets eliminados correctamente")
                    desactivarOpciones()
                    grjSel = 0
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                desactivarOpciones()
            End If

        Else
            MsgBox("El campo ID no puede estar vacío y debe ser un número.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub
    Private Sub limpiarGarajes()

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "DELETE FROM garajes WHERE id_garaje = " & Me.txbId.Text
        cmd.CommandText = sql

        If Me.txbId.Text <> "" And IsNumeric(Me.txbId.Text) = True Then

            Try
                cmd.ExecuteNonQuery()
                llenarGarajes()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        Else
            MsgBox("El campo ID no puede estar vacío y debe ser un número.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        MsgBox("Seleccionaste agregar nuevo garaje", MsgBoxStyle.Information)
        flag_abm = 1
        limpiarTextBox()
        activarOpciones()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        MsgBox("Seleccionaste modificar un garaje", MsgBoxStyle.Information)
        flag_abm = 2
        limpiarTextBox()

        activarOpciones()

        Me.txbId.Text = Me.dgvGarajes.CurrentRow.Cells(0).Value.ToString
        Me.txbNombre.Text = Me.dgvGarajes.CurrentRow.Cells(1).Value.ToString
        Me.txbDireccion.Text = Me.dgvGarajes.CurrentRow.Cells(2).Value.ToString
        Me.txbLocalidad.Text = Me.dgvGarajes.CurrentRow.Cells(3).Value.ToString
        Me.txbTelefono.Text = Me.dgvGarajes.CurrentRow.Cells(4).Value.ToString
        Me.txbPrecio.Text = Me.dgvGarajes.CurrentRow.Cells(5).Value.ToString

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        MsgBox("Seleccionaste eliminar un garaje", MsgBoxStyle.Information)
        flag_abm = 3
        limpiarTextBox()

        Me.txbId.Enabled = True
        Me.txbNombre.Enabled = False
        Me.txbDireccion.Enabled = False
        Me.txbLocalidad.Enabled = False
        Me.txbTelefono.Enabled = False
        Me.txbPrecio.Enabled = False
        Me.btnAceptar.Enabled = True

        Me.txbId.Text = Me.dgvGarajes.CurrentRow.Cells(0).Value.ToString
        Me.txbNombre.Text = Me.dgvGarajes.CurrentRow.Cells(1).Value.ToString
        Me.txbDireccion.Text = Me.dgvGarajes.CurrentRow.Cells(2).Value.ToString
        Me.txbLocalidad.Text = Me.dgvGarajes.CurrentRow.Cells(3).Value.ToString
        Me.txbTelefono.Text = Me.dgvGarajes.CurrentRow.Cells(4).Value.ToString
        Me.txbPrecio.Text = Me.dgvGarajes.CurrentRow.Cells(5).Value.ToString

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If flag_abm = 1 Then
            nuevoGaraje()
            limpiarTextBox()
        ElseIf flag_abm = 2 Then
            modificarGaraje()
            limpiarTextBox()
        ElseIf flag_abm = 3 Then
            eliminarGaraje()
            limpiarTextBox()
        End If
    End Sub
End Class