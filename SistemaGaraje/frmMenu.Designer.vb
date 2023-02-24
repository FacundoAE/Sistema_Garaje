<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VehiculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TicketsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GarajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ElegirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadísticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNombreSistema = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPlazasUsadas = New System.Windows.Forms.Label()
        Me.lblPlazasTotales = New System.Windows.Forms.Label()
        Me.lblSeparador = New System.Windows.Forms.Label()
        Me.lblPlazas = New System.Windows.Forms.Label()
        Me.lblUso = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.IndividualesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComparaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VehiculosToolStripMenuItem, Me.TicketsToolStripMenuItem, Me.GarajeToolStripMenuItem, Me.EstadísticasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(10)
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 39)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VehiculosToolStripMenuItem
        '
        Me.VehiculosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresoToolStripMenuItem, Me.SalidaToolStripMenuItem})
        Me.VehiculosToolStripMenuItem.Name = "VehiculosToolStripMenuItem"
        Me.VehiculosToolStripMenuItem.Size = New System.Drawing.Size(69, 19)
        Me.VehiculosToolStripMenuItem.Text = "Vehiculos"
        '
        'IngresoToolStripMenuItem
        '
        Me.IngresoToolStripMenuItem.Name = "IngresoToolStripMenuItem"
        Me.IngresoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.IngresoToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.IngresoToolStripMenuItem.Text = "Ingreso"
        '
        'SalidaToolStripMenuItem
        '
        Me.SalidaToolStripMenuItem.Name = "SalidaToolStripMenuItem"
        Me.SalidaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.SalidaToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.SalidaToolStripMenuItem.Text = "Salida"
        '
        'TicketsToolStripMenuItem
        '
        Me.TicketsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteToolStripMenuItem, Me.ImprimirToolStripMenuItem})
        Me.TicketsToolStripMenuItem.Name = "TicketsToolStripMenuItem"
        Me.TicketsToolStripMenuItem.Size = New System.Drawing.Size(55, 19)
        Me.TicketsToolStripMenuItem.Text = "Tickets"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ReporteToolStripMenuItem.Text = "Reporte"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'GarajeToolStripMenuItem
        '
        Me.GarajeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosToolStripMenuItem, Me.ElegirToolStripMenuItem})
        Me.GarajeToolStripMenuItem.Name = "GarajeToolStripMenuItem"
        Me.GarajeToolStripMenuItem.Size = New System.Drawing.Size(57, 19)
        Me.GarajeToolStripMenuItem.Text = "Garajes"
        '
        'DatosToolStripMenuItem
        '
        Me.DatosToolStripMenuItem.Name = "DatosToolStripMenuItem"
        Me.DatosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.DatosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DatosToolStripMenuItem.Text = "Datos"
        '
        'ElegirToolStripMenuItem
        '
        Me.ElegirToolStripMenuItem.Name = "ElegirToolStripMenuItem"
        Me.ElegirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ElegirToolStripMenuItem.Text = "Seleccionar"
        '
        'EstadísticasToolStripMenuItem
        '
        Me.EstadísticasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndividualesToolStripMenuItem, Me.ComparaciónToolStripMenuItem})
        Me.EstadísticasToolStripMenuItem.Name = "EstadísticasToolStripMenuItem"
        Me.EstadísticasToolStripMenuItem.Size = New System.Drawing.Size(79, 19)
        Me.EstadísticasToolStripMenuItem.Text = "Estadísticas"
        '
        'lblNombreSistema
        '
        Me.lblNombreSistema.AutoSize = True
        Me.lblNombreSistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreSistema.Location = New System.Drawing.Point(12, 223)
        Me.lblNombreSistema.Name = "lblNombreSistema"
        Me.lblNombreSistema.Size = New System.Drawing.Size(124, 31)
        Me.lblNombreSistema.TabIndex = 2
        Me.lblNombreSistema.Text = "SIGEGA"
        '
        'Timer1
        '
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.Gray
        Me.lblHora.Location = New System.Drawing.Point(217, 77)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(22, 24)
        Me.lblHora.TabIndex = 3
        Me.lblHora.Text = "--"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.Gray
        Me.lblFecha.Location = New System.Drawing.Point(217, 103)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(22, 24)
        Me.lblFecha.TabIndex = 4
        Me.lblFecha.Text = "--"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(219, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Hora y Fecha"
        '
        'lblPlazasUsadas
        '
        Me.lblPlazasUsadas.AutoSize = True
        Me.lblPlazasUsadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlazasUsadas.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblPlazasUsadas.Location = New System.Drawing.Point(534, 271)
        Me.lblPlazasUsadas.Name = "lblPlazasUsadas"
        Me.lblPlazasUsadas.Size = New System.Drawing.Size(29, 31)
        Me.lblPlazasUsadas.TabIndex = 6
        Me.lblPlazasUsadas.Text = "0"
        '
        'lblPlazasTotales
        '
        Me.lblPlazasTotales.AutoSize = True
        Me.lblPlazasTotales.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlazasTotales.ForeColor = System.Drawing.Color.Maroon
        Me.lblPlazasTotales.Location = New System.Drawing.Point(614, 271)
        Me.lblPlazasTotales.Name = "lblPlazasTotales"
        Me.lblPlazasTotales.Size = New System.Drawing.Size(29, 31)
        Me.lblPlazasTotales.TabIndex = 7
        Me.lblPlazasTotales.Text = "0"
        '
        'lblSeparador
        '
        Me.lblSeparador.AutoSize = True
        Me.lblSeparador.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeparador.Location = New System.Drawing.Point(584, 271)
        Me.lblSeparador.Name = "lblSeparador"
        Me.lblSeparador.Size = New System.Drawing.Size(22, 31)
        Me.lblSeparador.TabIndex = 8
        Me.lblSeparador.Text = "/"
        '
        'lblPlazas
        '
        Me.lblPlazas.AutoSize = True
        Me.lblPlazas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlazas.Location = New System.Drawing.Point(564, 223)
        Me.lblPlazas.Name = "lblPlazas"
        Me.lblPlazas.Size = New System.Drawing.Size(62, 20)
        Me.lblPlazas.TabIndex = 9
        Me.lblPlazas.Text = "Plazas"
        '
        'lblUso
        '
        Me.lblUso.AutoSize = True
        Me.lblUso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUso.Location = New System.Drawing.Point(537, 247)
        Me.lblUso.Name = "lblUso"
        Me.lblUso.Size = New System.Drawing.Size(33, 17)
        Me.lblUso.TabIndex = 10
        Me.lblUso.Text = "Uso"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(617, 247)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(40, 17)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "Total"
        '
        'IndividualesToolStripMenuItem
        '
        Me.IndividualesToolStripMenuItem.Name = "IndividualesToolStripMenuItem"
        Me.IndividualesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.IndividualesToolStripMenuItem.Text = "Individuales"
        '
        'ComparaciónToolStripMenuItem
        '
        Me.ComparaciónToolStripMenuItem.Name = "ComparaciónToolStripMenuItem"
        Me.ComparaciónToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ComparaciónToolStripMenuItem.Text = "Comparación"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaGaraje.My.Resources.Resources.garajeIcono
        Me.PictureBox1.Location = New System.Drawing.Point(12, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 311)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblUso)
        Me.Controls.Add(Me.lblPlazas)
        Me.Controls.Add(Me.lblSeparador)
        Me.Controls.Add(Me.lblPlazasTotales)
        Me.Controls.Add(Me.lblPlazasUsadas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblNombreSistema)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VehiculosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TicketsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GarajeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNombreSistema As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblHora As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ElegirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadísticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblPlazasUsadas As Label
    Friend WithEvents lblPlazasTotales As Label
    Friend WithEvents lblSeparador As Label
    Friend WithEvents lblPlazas As Label
    Friend WithEvents lblUso As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndividualesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComparaciónToolStripMenuItem As ToolStripMenuItem
End Class
