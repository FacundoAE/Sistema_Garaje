<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReImprimir
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbIdGaraje = New System.Windows.Forms.TextBox()
        Me.lblNroTicket = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txbNroTicket = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Garaje"
        '
        'txbIdGaraje
        '
        Me.txbIdGaraje.Enabled = False
        Me.txbIdGaraje.Location = New System.Drawing.Point(12, 231)
        Me.txbIdGaraje.Name = "txbIdGaraje"
        Me.txbIdGaraje.Size = New System.Drawing.Size(44, 20)
        Me.txbIdGaraje.TabIndex = 10
        '
        'lblNroTicket
        '
        Me.lblNroTicket.AutoSize = True
        Me.lblNroTicket.Location = New System.Drawing.Point(9, 264)
        Me.lblNroTicket.Name = "lblNroTicket"
        Me.lblNroTicket.Size = New System.Drawing.Size(92, 13)
        Me.lblNroTicket.TabIndex = 9
        Me.lblNroTicket.Text = "Numero de Ticket"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(11, 306)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(260, 42)
        Me.btnAceptar.TabIndex = 8
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txbNroTicket
        '
        Me.txbNroTicket.Location = New System.Drawing.Point(11, 280)
        Me.txbNroTicket.Name = "txbNroTicket"
        Me.txbNroTicket.Size = New System.Drawing.Size(260, 20)
        Me.txbNroTicket.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaGaraje.My.Resources.Resources.imprimirIcono
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frmReImprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 361)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbIdGaraje)
        Me.Controls.Add(Me.lblNroTicket)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txbNroTicket)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmReImprimir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReImprimir"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txbIdGaraje As TextBox
    Friend WithEvents lblNroTicket As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txbNroTicket As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
