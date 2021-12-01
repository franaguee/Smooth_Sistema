<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecibos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecibos))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblnroRecibo = New System.Windows.Forms.Label()
        Me.txtNroRecibo = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lstDatosRecibo = New System.Windows.Forms.ListBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.btnVolver.Location = New System.Drawing.Point(12, 237)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(80, 31)
        Me.btnVolver.TabIndex = 1
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'lblnroRecibo
        '
        Me.lblnroRecibo.AutoSize = True
        Me.lblnroRecibo.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnroRecibo.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.lblnroRecibo.Image = CType(resources.GetObject("lblnroRecibo.Image"), System.Drawing.Image)
        Me.lblnroRecibo.Location = New System.Drawing.Point(12, 9)
        Me.lblnroRecibo.Name = "lblnroRecibo"
        Me.lblnroRecibo.Size = New System.Drawing.Size(103, 17)
        Me.lblnroRecibo.TabIndex = 4
        Me.lblnroRecibo.Text = "Nro de Recibo:"
        '
        'txtNroRecibo
        '
        Me.txtNroRecibo.Location = New System.Drawing.Point(121, 8)
        Me.txtNroRecibo.Name = "txtNroRecibo"
        Me.txtNroRecibo.Size = New System.Drawing.Size(151, 20)
        Me.txtNroRecibo.TabIndex = 5
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.btnAceptar.Location = New System.Drawing.Point(194, 34)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(80, 31)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Buscar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'lstDatosRecibo
        '
        Me.lstDatosRecibo.Enabled = False
        Me.lstDatosRecibo.FormattingEnabled = True
        Me.lstDatosRecibo.Location = New System.Drawing.Point(12, 85)
        Me.lstDatosRecibo.Name = "lstDatosRecibo"
        Me.lstDatosRecibo.Size = New System.Drawing.Size(260, 134)
        Me.lstDatosRecibo.TabIndex = 7
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.btnLimpiar.Location = New System.Drawing.Point(194, 237)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(80, 31)
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'frmRecibos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(286, 276)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lstDatosRecibo)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtNroRecibo)
        Me.Controls.Add(Me.lblnroRecibo)
        Me.Controls.Add(Me.btnVolver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmRecibos"
        Me.Text = "Recibo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents lblnroRecibo As System.Windows.Forms.Label
    Friend WithEvents txtNroRecibo As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lstDatosRecibo As System.Windows.Forms.ListBox
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
End Class
