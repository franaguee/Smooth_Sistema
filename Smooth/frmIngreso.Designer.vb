<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIngresarCliente))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblNuevoDni = New System.Windows.Forms.Label()
        Me.lblNuevoNombre = New System.Windows.Forms.Label()
        Me.lblNuevoTel = New System.Windows.Forms.Label()
        Me.lblNuevoDireccion = New System.Windows.Forms.Label()
        Me.lblNuevoCliente = New System.Windows.Forms.Label()
        Me.txtNuevoDni = New System.Windows.Forms.TextBox()
        Me.txtNuevoNombre = New System.Windows.Forms.TextBox()
        Me.txtNuevoTel = New System.Windows.Forms.TextBox()
        Me.txtNuevoDireccion = New System.Windows.Forms.TextBox()
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.btnVolver.Location = New System.Drawing.Point(12, 221)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(82, 28)
        Me.btnVolver.TabIndex = 1
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'lblNuevoDni
        '
        Me.lblNuevoDni.AutoSize = True
        Me.lblNuevoDni.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNuevoDni.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevoDni.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.lblNuevoDni.Image = CType(resources.GetObject("lblNuevoDni.Image"), System.Drawing.Image)
        Me.lblNuevoDni.Location = New System.Drawing.Point(12, 48)
        Me.lblNuevoDni.Name = "lblNuevoDni"
        Me.lblNuevoDni.Size = New System.Drawing.Size(38, 18)
        Me.lblNuevoDni.TabIndex = 5
        Me.lblNuevoDni.Text = "Dni:"
        '
        'lblNuevoNombre
        '
        Me.lblNuevoNombre.AutoSize = True
        Me.lblNuevoNombre.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNuevoNombre.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevoNombre.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.lblNuevoNombre.Image = CType(resources.GetObject("lblNuevoNombre.Image"), System.Drawing.Image)
        Me.lblNuevoNombre.Location = New System.Drawing.Point(12, 76)
        Me.lblNuevoNombre.Name = "lblNuevoNombre"
        Me.lblNuevoNombre.Size = New System.Drawing.Size(64, 18)
        Me.lblNuevoNombre.TabIndex = 6
        Me.lblNuevoNombre.Text = "Nombre:"
        '
        'lblNuevoTel
        '
        Me.lblNuevoTel.AutoSize = True
        Me.lblNuevoTel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNuevoTel.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevoTel.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.lblNuevoTel.Image = CType(resources.GetObject("lblNuevoTel.Image"), System.Drawing.Image)
        Me.lblNuevoTel.Location = New System.Drawing.Point(12, 108)
        Me.lblNuevoTel.Name = "lblNuevoTel"
        Me.lblNuevoTel.Size = New System.Drawing.Size(69, 18)
        Me.lblNuevoTel.TabIndex = 7
        Me.lblNuevoTel.Text = "Telefono:"
        '
        'lblNuevoDireccion
        '
        Me.lblNuevoDireccion.AutoSize = True
        Me.lblNuevoDireccion.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNuevoDireccion.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevoDireccion.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.lblNuevoDireccion.Image = CType(resources.GetObject("lblNuevoDireccion.Image"), System.Drawing.Image)
        Me.lblNuevoDireccion.Location = New System.Drawing.Point(12, 139)
        Me.lblNuevoDireccion.Name = "lblNuevoDireccion"
        Me.lblNuevoDireccion.Size = New System.Drawing.Size(75, 18)
        Me.lblNuevoDireccion.TabIndex = 8
        Me.lblNuevoDireccion.Text = "Direccion:"
        '
        'lblNuevoCliente
        '
        Me.lblNuevoCliente.AutoSize = True
        Me.lblNuevoCliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNuevoCliente.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevoCliente.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.lblNuevoCliente.Image = CType(resources.GetObject("lblNuevoCliente.Image"), System.Drawing.Image)
        Me.lblNuevoCliente.Location = New System.Drawing.Point(12, 9)
        Me.lblNuevoCliente.Name = "lblNuevoCliente"
        Me.lblNuevoCliente.Size = New System.Drawing.Size(130, 18)
        Me.lblNuevoCliente.TabIndex = 9
        Me.lblNuevoCliente.Text = "Ingrese sus Datos:"
        '
        'txtNuevoDni
        '
        Me.txtNuevoDni.Location = New System.Drawing.Point(93, 46)
        Me.txtNuevoDni.Name = "txtNuevoDni"
        Me.txtNuevoDni.Size = New System.Drawing.Size(179, 20)
        Me.txtNuevoDni.TabIndex = 10
        '
        'txtNuevoNombre
        '
        Me.txtNuevoNombre.Location = New System.Drawing.Point(93, 76)
        Me.txtNuevoNombre.Name = "txtNuevoNombre"
        Me.txtNuevoNombre.Size = New System.Drawing.Size(179, 20)
        Me.txtNuevoNombre.TabIndex = 11
        '
        'txtNuevoTel
        '
        Me.txtNuevoTel.Location = New System.Drawing.Point(93, 106)
        Me.txtNuevoTel.Name = "txtNuevoTel"
        Me.txtNuevoTel.Size = New System.Drawing.Size(179, 20)
        Me.txtNuevoTel.TabIndex = 12
        '
        'txtNuevoDireccion
        '
        Me.txtNuevoDireccion.Location = New System.Drawing.Point(93, 139)
        Me.txtNuevoDireccion.Name = "txtNuevoDireccion"
        Me.txtNuevoDireccion.Size = New System.Drawing.Size(179, 20)
        Me.txtNuevoDireccion.TabIndex = 13
        '
        'btnNuevoCliente
        '
        Me.btnNuevoCliente.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoCliente.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoCliente.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.btnNuevoCliente.Location = New System.Drawing.Point(190, 221)
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.btnNuevoCliente.Size = New System.Drawing.Size(82, 28)
        Me.btnNuevoCliente.TabIndex = 14
        Me.btnNuevoCliente.Text = "Ingresar"
        Me.btnNuevoCliente.UseVisualStyleBackColor = False
        '
        'frmIngresarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnNuevoCliente)
        Me.Controls.Add(Me.txtNuevoDireccion)
        Me.Controls.Add(Me.txtNuevoTel)
        Me.Controls.Add(Me.txtNuevoNombre)
        Me.Controls.Add(Me.txtNuevoDni)
        Me.Controls.Add(Me.lblNuevoCliente)
        Me.Controls.Add(Me.lblNuevoDireccion)
        Me.Controls.Add(Me.lblNuevoTel)
        Me.Controls.Add(Me.lblNuevoNombre)
        Me.Controls.Add(Me.lblNuevoDni)
        Me.Controls.Add(Me.btnVolver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmIngresarCliente"
        Me.Text = "Ingresar Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents lblNuevoDni As System.Windows.Forms.Label
    Friend WithEvents lblNuevoNombre As System.Windows.Forms.Label
    Friend WithEvents lblNuevoTel As System.Windows.Forms.Label
    Friend WithEvents lblNuevoDireccion As System.Windows.Forms.Label
    Friend WithEvents lblNuevoCliente As System.Windows.Forms.Label
    Friend WithEvents txtNuevoDni As System.Windows.Forms.TextBox
    Friend WithEvents txtNuevoNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtNuevoTel As System.Windows.Forms.TextBox
    Friend WithEvents txtNuevoDireccion As System.Windows.Forms.TextBox
    Friend WithEvents btnNuevoCliente As System.Windows.Forms.Button
End Class
