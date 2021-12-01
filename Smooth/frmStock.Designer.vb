<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStock))
        Me.lblProdStock = New System.Windows.Forms.Label()
        Me.cmbProdStock = New System.Windows.Forms.ComboBox()
        Me.lblCantStock = New System.Windows.Forms.Label()
        Me.txtCantStock = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lstStock = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLimpiarStock = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblProdStock
        '
        Me.lblProdStock.AutoSize = True
        Me.lblProdStock.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdStock.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.lblProdStock.Image = CType(resources.GetObject("lblProdStock.Image"), System.Drawing.Image)
        Me.lblProdStock.Location = New System.Drawing.Point(12, 9)
        Me.lblProdStock.Name = "lblProdStock"
        Me.lblProdStock.Size = New System.Drawing.Size(70, 17)
        Me.lblProdStock.TabIndex = 5
        Me.lblProdStock.Text = "Producto:"
        '
        'cmbProdStock
        '
        Me.cmbProdStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cmbProdStock.FormattingEnabled = True
        Me.cmbProdStock.Items.AddRange(New Object() {"Quantum", "King", "Queen", "Void", "Delirious", "Black", "Geminis", "Scarlet", "Snowy", "Desert", "Wild", "Cherry", "Grape", "Orange", "Rose"})
        Me.cmbProdStock.Location = New System.Drawing.Point(89, 9)
        Me.cmbProdStock.Name = "cmbProdStock"
        Me.cmbProdStock.Size = New System.Drawing.Size(183, 23)
        Me.cmbProdStock.TabIndex = 6
        '
        'lblCantStock
        '
        Me.lblCantStock.AutoSize = True
        Me.lblCantStock.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantStock.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.lblCantStock.Image = CType(resources.GetObject("lblCantStock.Image"), System.Drawing.Image)
        Me.lblCantStock.Location = New System.Drawing.Point(12, 41)
        Me.lblCantStock.Name = "lblCantStock"
        Me.lblCantStock.Size = New System.Drawing.Size(75, 17)
        Me.lblCantStock.TabIndex = 7
        Me.lblCantStock.Text = "Cantidad: "
        '
        'txtCantStock
        '
        Me.txtCantStock.Location = New System.Drawing.Point(89, 36)
        Me.txtCantStock.Name = "txtCantStock"
        Me.txtCantStock.Size = New System.Drawing.Size(61, 20)
        Me.txtCantStock.TabIndex = 8
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.btnActualizar.Location = New System.Drawing.Point(192, 255)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(80, 31)
        Me.btnActualizar.TabIndex = 9
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.btnVolver.Location = New System.Drawing.Point(15, 255)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(80, 31)
        Me.btnVolver.TabIndex = 10
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'lstStock
        '
        Me.lstStock.FormattingEnabled = True
        Me.lstStock.Location = New System.Drawing.Point(15, 88)
        Me.lstStock.Name = "lstStock"
        Me.lstStock.Size = New System.Drawing.Size(249, 160)
        Me.lstStock.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Stock"
        '
        'btnLimpiarStock
        '
        Me.btnLimpiarStock.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnLimpiarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarStock.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarStock.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.btnLimpiarStock.Location = New System.Drawing.Point(192, 36)
        Me.btnLimpiarStock.Name = "btnLimpiarStock"
        Me.btnLimpiarStock.Size = New System.Drawing.Size(80, 31)
        Me.btnLimpiarStock.TabIndex = 13
        Me.btnLimpiarStock.Text = "Limpiar"
        Me.btnLimpiarStock.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.Button1.Location = New System.Drawing.Point(101, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 32)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(276, 298)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLimpiarStock)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstStock)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.txtCantStock)
        Me.Controls.Add(Me.lblCantStock)
        Me.Controls.Add(Me.cmbProdStock)
        Me.Controls.Add(Me.lblProdStock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmStock"
        Me.Text = "Actualizar Stock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProdStock As System.Windows.Forms.Label
    Friend WithEvents cmbProdStock As System.Windows.Forms.ComboBox
    Friend WithEvents lblCantStock As System.Windows.Forms.Label
    Friend WithEvents txtCantStock As System.Windows.Forms.TextBox
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents lstStock As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLimpiarStock As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
