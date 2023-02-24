<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComparar
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
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbAno = New System.Windows.Forms.TextBox()
        Me.txbMes = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txbGaraje = New System.Windows.Forms.TextBox()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.nGaraje1 = New System.Windows.Forms.Label()
        Me.txbGaraje2 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.nGaraje2 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(315, 304)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(18, 20)
        Me.lbl3.TabIndex = 30
        Me.lbl3.Text = "0"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(291, 218)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(18, 20)
        Me.lbl2.TabIndex = 29
        Me.lbl2.Text = "0"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(315, 132)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(18, 20)
        Me.lbl1.TabIndex = 28
        Me.lbl1.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(292, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 17)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Ingresos promedio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(292, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 17)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Cantidad de Tickets"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(292, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Ingresos por tickets"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Año"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Mes"
        '
        'txbAno
        '
        Me.txbAno.Location = New System.Drawing.Point(154, 304)
        Me.txbAno.Name = "txbAno"
        Me.txbAno.Size = New System.Drawing.Size(71, 20)
        Me.txbAno.TabIndex = 21
        '
        'txbMes
        '
        Me.txbMes.Location = New System.Drawing.Point(14, 304)
        Me.txbMes.Name = "txbMes"
        Me.txbMes.Size = New System.Drawing.Size(71, 20)
        Me.txbMes.TabIndex = 20
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(12, 330)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(213, 29)
        Me.btnAceptar.TabIndex = 17
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txbGaraje
        '
        Me.txbGaraje.Enabled = False
        Me.txbGaraje.Location = New System.Drawing.Point(15, 252)
        Me.txbGaraje.Name = "txbGaraje"
        Me.txbGaraje.Size = New System.Drawing.Size(48, 20)
        Me.txbGaraje.TabIndex = 16
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.Location = New System.Drawing.Point(548, 304)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(18, 20)
        Me.lbl6.TabIndex = 38
        Me.lbl6.Text = "0"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.Location = New System.Drawing.Point(524, 218)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(18, 20)
        Me.lbl5.TabIndex = 37
        Me.lbl5.Text = "0"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.Location = New System.Drawing.Point(548, 132)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(18, 20)
        Me.lbl4.TabIndex = 36
        Me.lbl4.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(525, 264)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(142, 17)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Ingresos promedio"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(525, 176)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(152, 17)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Cantidad de Tickets"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(525, 95)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(151, 17)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Ingresos por tickets"
        '
        'nGaraje1
        '
        Me.nGaraje1.AutoSize = True
        Me.nGaraje1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nGaraje1.Location = New System.Drawing.Point(291, 20)
        Me.nGaraje1.Name = "nGaraje1"
        Me.nGaraje1.Size = New System.Drawing.Size(80, 24)
        Me.nGaraje1.TabIndex = 40
        Me.nGaraje1.Text = "Garaje 1"
        '
        'txbGaraje2
        '
        Me.txbGaraje2.BackColor = System.Drawing.SystemColors.Highlight
        Me.txbGaraje2.Location = New System.Drawing.Point(174, 252)
        Me.txbGaraje2.Name = "txbGaraje2"
        Me.txbGaraje2.ReadOnly = True
        Me.txbGaraje2.Size = New System.Drawing.Size(51, 20)
        Me.txbGaraje2.TabIndex = 41
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(443, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 24)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "vs"
        '
        'nGaraje2
        '
        Me.nGaraje2.AutoSize = True
        Me.nGaraje2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nGaraje2.Location = New System.Drawing.Point(524, 20)
        Me.nGaraje2.Name = "nGaraje2"
        Me.nGaraje2.Size = New System.Drawing.Size(80, 24)
        Me.nGaraje2.TabIndex = 43
        Me.nGaraje2.Text = "Garaje 2"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(173, 231)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 13)
        Me.Label20.TabIndex = 44
        Me.Label20.Text = "Comparar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Actual"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaGaraje.My.Resources.Resources.estadisticas
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 171)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(291, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 20)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "$"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(524, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 20)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "$"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(291, 304)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 20)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "$"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(524, 304)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 20)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "$"
        '
        'frmComparar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 376)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.nGaraje2)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txbGaraje2)
        Me.Controls.Add(Me.nGaraje1)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
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
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txbGaraje)
        Me.Name = "frmComparar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comparar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txbAno As TextBox
    Friend WithEvents txbMes As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txbGaraje As TextBox
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents nGaraje1 As Label
    Friend WithEvents txbGaraje2 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents nGaraje2 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
