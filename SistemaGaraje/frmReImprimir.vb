Public Class frmReImprimir
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.txbNroTicket.Text <> "" And IsNumeric(Me.txbNroTicket.Text) = True Then
            nroTick = Me.txbNroTicket.Text
            Dim frm As New frmImprimirSalida
            frm.ShowDialog()
        Else
            MsgBox("Debes ingresar un numero de ticket")
        End If
    End Sub

    Private Sub frmReImprimir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txbIdGaraje.Text = grjSel
    End Sub
End Class