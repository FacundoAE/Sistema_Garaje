Public Class frmComparar
    Private Sub frmComparar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txbGaraje.Text = grjSel
        Me.nGaraje1.Text = grjNom
        grjSel2 = 0
        grjNom2 = ""
    End Sub
    Private Sub garajeuno()
        If IsNumeric(Me.txbMes.Text) = True And IsNumeric(Me.txbAno.Text) = True Then
            If Me.txbMes.Text >= 1 And Me.txbMes.Text <= 12 Then
                cmd.Connection = conexion.conexion
                cmd.CommandType = CommandType.Text
                Dim sql As String = $"SELECT sum(total), count(id_ticket), CAST(ROUND(avg(total), 2 , 1) As float)
FROM tickets WHERE SUBSTRING(CONVERT(varchar, salida, 112),5,2) = {Me.txbMes.Text} 
AND
SUBSTRING(CONVERT(varchar, salida, 112),0,5) = {Me.txbAno.Text}
AND id_garaje = {Me.txbGaraje.Text}"
                cmd.CommandText = sql

                dr = cmd.ExecuteReader()

                Try
                    If dr.HasRows Then
                        While dr.Read
                            Me.lbl1.Text = dr(0).ToString
                            Me.lbl2.Text = dr(1).ToString
                            Me.lbl3.Text = dr(2).ToString
                        End While
                        If Me.lbl1.Text = "0" Or Me.lbl2.Text = "0" Or Me.lbl3.Text = "0" Then
                            MsgBox("No se encontraron datos para esa fecha")
                        End If
                    Else
                        MsgBox("No se encontraron datos")
                    End If
                    dr.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("El mes debe ser un numero de 1 a 12")
            End If
        Else
            MsgBox("Por favor ingresa solo numeros")
        End If
    End Sub
    Private Sub garajedos()
        If IsNumeric(Me.txbMes.Text) = True And IsNumeric(Me.txbAno.Text) = True Then
            If Me.txbMes.Text >= 1 And Me.txbMes.Text <= 12 Then
                cmd.Connection = conexion.conexion
                cmd.CommandType = CommandType.Text
                Dim sql As String = $"SELECT sum(total), count(id_ticket), CAST(ROUND(avg(total), 2 , 1) As float)
FROM tickets WHERE SUBSTRING(CONVERT(varchar, salida, 112),5,2) = {Me.txbMes.Text} 
AND
SUBSTRING(CONVERT(varchar, salida, 112),0,5) = {Me.txbAno.Text}
AND id_garaje = {Me.txbGaraje2.Text}"
                cmd.CommandText = sql

                dr = cmd.ExecuteReader()

                Try
                    If dr.HasRows Then
                        While dr.Read
                            Me.lbl4.Text = dr(0).ToString
                            Me.lbl5.Text = dr(1).ToString
                            Me.lbl6.Text = dr(2).ToString
                        End While
                        If Me.lbl4.Text = "0" Or Me.lbl5.Text = "0" Or Me.lbl6.Text = "0" Then
                            MsgBox("No se encontraron datos para esa fecha")
                        End If
                    Else
                        MsgBox("No se encontraron datos")
                    End If
                    dr.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("El mes debe ser un numero de 1 a 12")
            End If
        Else
            MsgBox("Por favor ingresa solo numeros")
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If IsNumeric(Me.txbGaraje2.Text) = True Then
            If Me.txbGaraje2.Text = Me.txbGaraje.Text Then
                MsgBox("Debes elegir dos garajes diferentes para comparar")
            Else
                garajeuno()
                garajedos()
            End If
        Else
                MsgBox("Debes elegir un garaje para comparar")
        End If
    End Sub

    Private Sub txbGaraje2_KeyDown(sender As Object, e As KeyEventArgs) Handles txbGaraje2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim frmCompararElegir As New frmCompararElegir
            frmCompararElegir.ShowDialog()
        End If
    End Sub

    Private Sub frmComparar_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        If grjSel2 <> 0 And grjNom2 <> "" Then
            Me.txbGaraje2.Text = grjSel2
            Me.nGaraje2.Text = grjNom2
        End If
    End Sub
End Class