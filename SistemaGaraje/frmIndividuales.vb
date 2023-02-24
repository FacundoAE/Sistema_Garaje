Public Class frmIndividuales
    Private Sub frmIndividuales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblGaraje.Text = grjNom
        Me.txbGaraje.Text = grjSel
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
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
End Class