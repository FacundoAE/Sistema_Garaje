﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprimirEntrada
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.PrimerTicketBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SisGarDataSet = New SistemaGaraje.SisGarDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PrimerTicketTableAdapter = New SistemaGaraje.SisGarDataSetTableAdapters.PrimerTicketTableAdapter()
        CType(Me.PrimerTicketBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SisGarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrimerTicketBindingSource
        '
        Me.PrimerTicketBindingSource.DataMember = "PrimerTicket"
        Me.PrimerTicketBindingSource.DataSource = Me.SisGarDataSet
        '
        'SisGarDataSet
        '
        Me.SisGarDataSet.DataSetName = "SisGarDataSet"
        Me.SisGarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PrimerTicketBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaGaraje.reporteEntrada.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(384, 361)
        Me.ReportViewer1.TabIndex = 0
        '
        'PrimerTicketTableAdapter
        '
        Me.PrimerTicketTableAdapter.ClearBeforeFill = True
        '
        'frmImprimirEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmImprimirEntrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir Entrada"
        CType(Me.PrimerTicketBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SisGarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PrimerTicketBindingSource As BindingSource
    Friend WithEvents SisGarDataSet As SisGarDataSet
    Friend WithEvents PrimerTicketTableAdapter As SisGarDataSetTableAdapters.PrimerTicketTableAdapter
End Class
