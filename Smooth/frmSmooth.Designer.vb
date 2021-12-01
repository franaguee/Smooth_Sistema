<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.btnPedido = New System.Windows.Forms.Button()
        Me.btnVerRecibo = New System.Windows.Forms.Button()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPedido
        '
        Me.btnPedido.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPedido.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPedido.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.btnPedido.Location = New System.Drawing.Point(274, 372)
        Me.btnPedido.Name = "btnPedido"
        Me.btnPedido.Size = New System.Drawing.Size(167, 69)
        Me.btnPedido.TabIndex = 1
        Me.btnPedido.Text = "Ingresar Pedido"
        Me.btnPedido.UseVisualStyleBackColor = False
        '
        'btnVerRecibo
        '
        Me.btnVerRecibo.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnVerRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerRecibo.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerRecibo.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.btnVerRecibo.Location = New System.Drawing.Point(460, 372)
        Me.btnVerRecibo.Name = "btnVerRecibo"
        Me.btnVerRecibo.Size = New System.Drawing.Size(167, 69)
        Me.btnVerRecibo.TabIndex = 2
        Me.btnVerRecibo.Text = "Recibos"
        Me.btnVerRecibo.UseVisualStyleBackColor = False
        '
        'btnStock
        '
        Me.btnStock.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStock.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStock.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.btnStock.Location = New System.Drawing.Point(89, 372)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(167, 69)
        Me.btnStock.TabIndex = 3
        Me.btnStock.Text = "Stock"
        Me.btnStock.UseVisualStyleBackColor = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(707, 470)
        Me.Controls.Add(Me.btnStock)
        Me.Controls.Add(Me.btnVerRecibo)
        Me.Controls.Add(Me.btnPedido)
        Me.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmMenu"
        Me.Text = "Smooth"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPedido As System.Windows.Forms.Button
    Friend WithEvents btnVerRecibo As System.Windows.Forms.Button
    Friend WithEvents btnStock As System.Windows.Forms.Button

End Class
