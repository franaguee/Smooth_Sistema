Public Class frmRecibos

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        sql = ("Select * From Recibo Where idRecibo = '" & txtNroRecibo.Text & "'")
        Proc(sql)
        If rs.Read = True Then
            lstDatosRecibo.Items.Add("Recibo: " & rs(0))
            lstDatosRecibo.Items.Add("Entrega: " & rs(1))
            sql = ("select c.idcliente from recibo r inner join entrega e on r.identrega = e.identrega inner join pedido p on e.idpedido = p.idpedido inner join cliente c on p.idcliente = c.idcliente where idrecibo = '" & rs(0) & "'")
            Proc1(sql)
            rs1.Read()
            lstDatosRecibo.Items.Add("Cliente: " & rs1(0))
            lstDatosRecibo.Items.Add("Monto: " & rs(2))
            lstDatosRecibo.Items.Add("FPago: " & rs(3))
            lstDatosRecibo.Items.Add("Metodo de Pago: " & FormaPago)

            

            txtNroRecibo.Enabled = False
        Else
            MsgBox("No Existe el numero de recibo")
        End If


    End Sub

    Private Sub btnVolver_Click_1(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
        lstDatosRecibo.Items.Clear()
        txtNroRecibo.Enabled = True
        txtNroRecibo.Text = ""
    End Sub

    
End Class