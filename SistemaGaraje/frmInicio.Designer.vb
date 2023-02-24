<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
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
        Me.txbContrasena = New System.Windows.Forms.TextBox()
        Me.txbUsuario = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.lblcompruebausuario = New System.Windows.Forms.Label()
        Me.lblcompruebacontrasena = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(13, 300)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(259, 49)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txbContrasena
        '
        Me.txbContrasena.Enabled = False
        Me.txbContrasena.Location = New System.Drawing.Point(13, 262)
        Me.txbContrasena.Name = "txbContrasena"
        Me.txbContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbContrasena.Size = New System.Drawing.Size(259, 20)
        Me.txbContrasena.TabIndex = 1
        '
        'txbUsuario
        '
        Me.txbUsuario.Location = New System.Drawing.Point(13, 207)
        Me.txbUsuario.Name = "txbUsuario"
        Me.txbUsuario.Size = New System.Drawing.Size(259, 20)
        Me.txbUsuario.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaGaraje.My.Resources.Resources.garajeIcono
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(12, 189)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 4
        Me.lblUsuario.Text = "Usuario"
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Location = New System.Drawing.Point(12, 244)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(61, 13)
        Me.lblContrasena.TabIndex = 5
        Me.lblContrasena.Text = "Contraseña"
        '
        'lblcompruebausuario
        '
        Me.lblcompruebausuario.AutoSize = True
        Me.lblcompruebausuario.Location = New System.Drawing.Point(356, 32)
        Me.lblcompruebausuario.Name = "lblcompruebausuario"
        Me.lblcompruebausuario.Size = New System.Drawing.Size(0, 13)
        Me.lblcompruebausuario.TabIndex = 6
        '
        'lblcompruebacontrasena
        '
        Me.lblcompruebacontrasena.AutoSize = True
        Me.lblcompruebacontrasena.Location = New System.Drawing.Point(356, 81)
        Me.lblcompruebacontrasena.Name = "lblcompruebacontrasena"
        Me.lblcompruebacontrasena.Size = New System.Drawing.Size(0, 13)
        Me.lblcompruebacontrasena.TabIndex = 7
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 361)
        Me.Controls.Add(Me.lblcompruebacontrasena)
        Me.Controls.Add(Me.lblcompruebausuario)
        Me.Controls.Add(Me.lblContrasena)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txbUsuario)
        Me.Controls.Add(Me.txbContrasena)
        Me.Controls.Add(Me.btnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents txbContrasena As TextBox
    Friend WithEvents txbUsuario As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblContrasena As Label
    Friend WithEvents lblcompruebausuario As Label
    Friend WithEvents lblcompruebacontrasena As Label
End Class
