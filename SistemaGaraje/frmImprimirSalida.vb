Public Class frmImprimirSalida
    Private Sub frmImprimirSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SisGarDataSet.SegundoTicket' Puede moverla o quitarla según sea necesario.
        Me.SegundoTicketTableAdapter.Fill(Me.SisGarDataSet.SegundoTicket, nroTick, grjSel)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class