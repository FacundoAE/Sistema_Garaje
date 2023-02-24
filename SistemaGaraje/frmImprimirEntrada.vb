Public Class frmImprimirEntrada
    Private Sub frmImprimirEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SisGarDataSet.PrimerTicket' Puede moverla o quitarla según sea necesario.
        Me.PrimerTicketTableAdapter.Fill(Me.SisGarDataSet.PrimerTicket, nroTick, grjSel)

        Me.ReportViewer1.RefreshReport()

        nroTick = 0
    End Sub
End Class