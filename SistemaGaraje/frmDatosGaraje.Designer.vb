<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosGaraje
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txbNombre = New System.Windows.Forms.TextBox()
        Me.txbDireccion = New System.Windows.Forms.TextBox()
        Me.txbLocalidad = New System.Windows.Forms.TextBox()
        Me.txbTelefono = New System.Windows.Forms.TextBox()
        Me.txbPrecio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvGarajes = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txbId = New System.Windows.Forms.TextBox()
        Me.txbPlazas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGarajes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Location = New System.Drawing.Point(12, 507)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(258, 42)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaGaraje.My.Resources.Resources.opcionesIcono
        Me.PictureBox1.Location = New System.Drawing.Point(14, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'txbNombre
        '
        Me.txbNombre.Enabled = False
        Me.txbNombre.Location = New System.Drawing.Point(12, 289)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(258, 20)
        Me.txbNombre.TabIndex = 11
        '
        'txbDireccion
        '
        Me.txbDireccion.Enabled = False
        Me.txbDireccion.Location = New System.Drawing.Point(12, 328)
        Me.txbDireccion.Name = "txbDireccion"
        Me.txbDireccion.Size = New System.Drawing.Size(258, 20)
        Me.txbDireccion.TabIndex = 12
        '
        'txbLocalidad
        '
        Me.txbLocalidad.Enabled = False
        Me.txbLocalidad.Location = New System.Drawing.Point(12, 367)
        Me.txbLocalidad.Name = "txbLocalidad"
        Me.txbLocalidad.Size = New System.Drawing.Size(258, 20)
        Me.txbLocalidad.TabIndex = 13
        '
        'txbTelefono
        '
        Me.txbTelefono.Enabled = False
        Me.txbTelefono.Location = New System.Drawing.Point(12, 406)
        Me.txbTelefono.Name = "txbTelefono"
        Me.txbTelefono.Size = New System.Drawing.Size(258, 20)
        Me.txbTelefono.TabIndex = 14
        '
        'txbPrecio
        '
        Me.txbPrecio.Enabled = False
        Me.txbPrecio.Location = New System.Drawing.Point(12, 445)
        Me.txbPrecio.Name = "txbPrecio"
        Me.txbPrecio.Size = New System.Drawing.Size(258, 20)
        Me.txbPrecio.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 270)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Dirección"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 351)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Localidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 390)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Telefono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 429)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Precio por hora"
        '
        'dgvGarajes
        '
        Me.dgvGarajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGarajes.Location = New System.Drawing.Point(284, 12)
        Me.dgvGarajes.Name = "dgvGarajes"
        Me.dgvGarajes.Size = New System.Drawing.Size(488, 199)
        Me.dgvGarajes.TabIndex = 21
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(661, 223)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(111, 23)
        Me.btnEliminar.TabIndex = 22
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(544, 223)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(111, 23)
        Me.btnModificar.TabIndex = 23
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(427, 223)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(111, 23)
        Me.btnNuevo.TabIndex = 24
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "ID"
        '
        'txbId
        '
        Me.txbId.Enabled = False
        Me.txbId.Location = New System.Drawing.Point(12, 247)
        Me.txbId.Name = "txbId"
        Me.txbId.Size = New System.Drawing.Size(258, 20)
        Me.txbId.TabIndex = 25
        '
        'txbPlazas
        '
        Me.txbPlazas.Enabled = False
        Me.txbPlazas.Location = New System.Drawing.Point(12, 481)
        Me.txbPlazas.Name = "txbPlazas"
        Me.txbPlazas.Size = New System.Drawing.Size(258, 20)
        Me.txbPlazas.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 467)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Plazas"
        '
        'frmDatosGaraje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txbPlazas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txbId)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgvGarajes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbPrecio)
        Me.Controls.Add(Me.txbTelefono)
        Me.Controls.Add(Me.txbLocalidad)
        Me.Controls.Add(Me.txbDireccion)
        Me.Controls.Add(Me.txbNombre)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmDatosGaraje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Garaje"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGarajes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txbNombre As TextBox
    Friend WithEvents txbDireccion As TextBox
    Friend WithEvents txbLocalidad As TextBox
    Friend WithEvents txbTelefono As TextBox
    Friend WithEvents txbPrecio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvGarajes As DataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txbId As TextBox
    Friend WithEvents txbPlazas As TextBox
    Friend WithEvents Label7 As Label
End Class
