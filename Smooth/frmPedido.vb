
Public Class frmPedido

    

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If cmbProducto.SelectedItem <> "" And txtCantProd.Text <> "" Then
            lstCarrito.Items.Add(cmbProducto.SelectedItem)
            lstCantidad.Items.Add(txtCantProd.Text)

            sql = ("Select precio from producto where descripcion = '" & cmbProducto.SelectedItem & "'")
            Proc(sql)
            rs.Read()

            lstPrecio.Items.Add(rs(0))

        Else
            MsgBox("Ingrese Producto y Cantidad")
        End If
        cmbProducto.Text = ""
        txtCantProd.Text = ""
    End Sub


    Private Sub btnComprar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComprar.Click
        
        If lstCarrito.Items.Count <> 0 Then

            sql = ("Create table if not exists PedidoEnProceso (IdProceso int auto_increment, idProducto int, Cantidad int, Monto float, Constraint Pk_Proceso Primary Key(IdProceso))")
            Proc(sql)

            For I As Integer = 0 To lstCarrito.Items.Count - 1
                sql = ("Select precio from producto where Descripcion = '" & lstCarrito.Items(I).ToString & "'")
                Proc(sql)
                rs.Read()
                Monto = Monto + (rs(0) * lstCantidad.Items(I))
                MontoProd = rs(0) * lstCantidad.Items(I)

                sql = ("Select idProducto from producto where descripcion = '" & lstCarrito.Items(I) & "'")
                Proc(sql)
                rs.Read()

                sql = ("Insert into PedidoEnProceso Values('', '" & rs(0) & "',  '" & lstCantidad.Items(I) & "', '" & MontoProd & "' )")
                Proc(sql)
            Next

            Me.Hide()
            frmCliente.Show()
        Else
            MsgBox("Ingrese Datos")
        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
        lstCarrito.Items.Clear()
        lstCantidad.Items.Clear()
        lstPrecio.Items.Clear()

    End Sub
End Class