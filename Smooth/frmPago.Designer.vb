<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPago))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblMontoFinal = New System.Windows.Forms.Label()
        Me.lblMetodoPago = New System.Windows.Forms.Label()
        Me.cmbMetodoPago = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.btnVolver.Location = New System.Drawing.Point(12, 116)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(82, 28)
        Me.btnVolver.TabIndex = 1
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnPagar
        '
        Me.btnPagar.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagar.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.btnPagar.Location = New System.Drawing.Point(190, 116)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(82, 28)
        Me.btnPagar.TabIndex = 2
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.UseVisualStyleBackColor = False
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMonto.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.lblMonto.Image = CType(resources.GetObject("lblMonto.Image"), System.Drawing.Image)
        Me.lblMonto.Location = New System.Drawing.Point(12, 9)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(112, 18)
        Me.lblMonto.TabIndex = 6
        Me.lblMonto.Text = "Monto a pagar: "
        '
        'lblMontoFinal
        '
        Me.lblMontoFinal.AutoSize = True
        Me.lblMontoFinal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMontoFinal.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoFinal.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.lblMontoFinal.Image = CType(resources.GetObject("lblMontoFinal.Image"), System.Drawing.Image)
        Me.lblMontoFinal.Location = New System.Drawing.Point(130, 9)
        Me.lblMontoFinal.Name = "lblMontoFinal"
        Me.lblMontoFinal.Size = New System.Drawing.Size(0, 18)
        Me.lblMontoFinal.TabIndex = 8
        '
        'lblMetodoPago
        '
        Me.lblMetodoPago.AutoSize = True
        Me.lblMetodoPago.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMetodoPago.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMetodoPago.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.lblMetodoPago.Image = CType(resources.GetObject("lblMetodoPago.Image"), System.Drawing.Image)
        Me.lblMetodoPago.Location = New System.Drawing.Point(12, 45)
        Me.lblMetodoPago.Name = "lblMetodoPago"
        Me.lblMetodoPago.Size = New System.Drawing.Size(105, 18)
        Me.lblMetodoPago.TabIndex = 9
        Me.lblMetodoPago.Text = "Forma de Pago"
        '
        'cmbMetodoPago
        '
        Me.cmbMetodoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cmbMetodoPago.FormattingEnabled = True
        Me.cmbMetodoPago.Items.AddRange(New Object() {"Efectivo", "Tarjeta Credito/Debito (Un Pago)", "Mercado Pago"})
        Me.cmbMetodoPago.Location = New System.Drawing.Point(133, 42)
        Me.cmbMetodoPago.Name = "cmbMetodoPago"
        Me.cmbMetodoPago.Size = New System.Drawing.Size(139, 23)
        Me.cmbMetodoPago.TabIndex = 10
        '
        'frmPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(284, 154)
        Me.Controls.Add(Me.cmbMetodoPago)
        Me.Controls.Add(Me.lblMetodoPago)
        Me.Controls.Add(Me.lblMontoFinal)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.btnVolver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPago"
        Me.Text = "Pago"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblMontoFinal As System.Windows.Forms.Label
    Friend WithEvents lblMetodoPago As System.Windows.Forms.Label
    Friend WithEvents cmbMetodoPago As System.Windows.Forms.ComboBox
End Class
