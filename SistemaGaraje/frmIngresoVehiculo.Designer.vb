<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIngresoVehiculo
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
        Me.lblPatente = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txbPatente = New System.Windows.Forms.TextBox()
        Me.txbIdGaraje = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPatente
        '
        Me.lblPatente.AutoSize = True
        Me.lblPatente.Location = New System.Drawing.Point(12, 265)
        Me.lblPatente.Name = "lblPatente"
        Me.lblPatente.Size = New System.Drawing.Size(44, 13)
        Me.lblPatente.TabIndex = 7
        Me.lblPatente.Text = "Patente"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(12, 310)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(260, 42)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txbPatente
        '
        Me.txbPatente.Location = New System.Drawing.Point(12, 284)
        Me.txbPatente.Name = "txbPatente"
        Me.txbPatente.Size = New System.Drawing.Size(258, 20)
        Me.txbPatente.TabIndex = 5
        '
        'txbIdGaraje
        '
        Me.txbIdGaraje.Enabled = False
        Me.txbIdGaraje.Location = New System.Drawing.Point(12, 231)
        Me.txbIdGaraje.Name = "txbIdGaraje"
        Me.txbIdGaraje.Size = New System.Drawing.Size(44, 20)
        Me.txbIdGaraje.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Garaje"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaGaraje.My.Resources.Resources.ingresoIcono
        Me.PictureBox1.Location = New System.Drawing.Point(14, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frmIngresoVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 361)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbIdGaraje)
        Me.Controls.Add(Me.lblPatente)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txbPatente)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmIngresoVehiculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso Vehiculo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPatente As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txbPatente As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txbIdGaraje As TextBox
    Friend WithEvents Label1 As Label
End Class
