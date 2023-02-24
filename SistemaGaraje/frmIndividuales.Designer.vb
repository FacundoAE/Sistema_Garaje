<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndividuales
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
        Me.txbGaraje = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblGaraje = New System.Windows.Forms.Label()
        Me.txbMes = New System.Windows.Forms.TextBox()
        Me.txbAno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txbGaraje
        '
        Me.txbGaraje.Enabled = False
        Me.txbGaraje.Location = New System.Drawing.Point(177, 200)
        Me.txbGaraje.Name = "txbGaraje"
        Me.txbGaraje.Size = New System.Drawing.Size(48, 20)
        Me.txbGaraje.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(12, 288)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(213, 29)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaGaraje.My.Resources.Resources.estadisticas
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 171)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblGaraje
        '
        Me.lblGaraje.AutoSize = True
        Me.lblGaraje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGaraje.Location = New System.Drawing.Point(10, 200)
        Me.lblGaraje.Name = "lblGaraje"
        Me.lblGaraje.Size = New System.Drawing.Size(0, 20)
        Me.lblGaraje.TabIndex = 3
        '
        'txbMes
        '
        Me.txbMes.Location = New System.Drawing.Point(13, 262)
        Me.txbMes.Name = "txbMes"
        Me.txbMes.Size = New System.Drawing.Size(71, 20)
        Me.txbMes.TabIndex = 4
        '
        'txbAno
        '
        Me.txbAno.Location = New System.Drawing.Point(154, 262)
        Me.txbAno.Name = "txbAno"
        Me.txbAno.Size = New System.Drawing.Size(71, 20)
        Me.txbAno.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Mes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Año"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(256, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Ingresos por tickets"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(256, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Cantidad de Tickets"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(256, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Ingresos promedio"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(279, 63)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(18, 20)
        Me.lbl1.TabIndex = 12
        Me.lbl1.Text = "0"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(255, 163)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(18, 20)
        Me.lbl2.TabIndex = 13
        Me.lbl2.Text = "0"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(279, 260)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(18, 20)
        Me.lbl3.TabIndex = 14
        Me.lbl3.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(255, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "$"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(255, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "$"
        '
        'frmIndividuales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 326)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbAno)
        Me.Controls.Add(Me.txbMes)
        Me.Controls.Add(Me.lblGaraje)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txbGaraje)
        Me.Name = "frmIndividuales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Individuales"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txbGaraje As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblGaraje As Label
    Friend WithEvents txbMes As TextBox
    Friend WithEvents txbAno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
