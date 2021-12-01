Public Class frmPago

    

    Private Sub frmPago_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblMontoFinal.Text = Monto.ToString
    End Sub

    Private Sub btnPagar_Click(sender As System.Object, e As System.EventArgs) Handles btnPagar.Click
        Dim MontoFinal As Double
        If cmbMetodoPago.Text <> "" Then
            FormaPago = cmbMetodoPago.SelectedItem

            sql = ("Select idcliente from cliente c inner join persona p on c.idpersona = p.idpersona where p.dni = '" & DniPersona & "'")
            Proc(sql)
            rs.Read()

            sql = ("Insert into pedido values ('', '" & rs(0) & "' , curdate(), 0, 1)")
            Proc(sql)



            sql = ("Select * from PedidoEnProceso")
            Proc1(sql)

            Do While rs1.Read = True
                sql = ("select max(idpedido) from pedido")
                Proc(sql)
                rs.Read()

                sql = ("Insert into detallePedido values ('', '" & rs(0) & "', '" & rs1(1) & "' , '" & rs1(2) & "', '" & rs1(3) & "')")
                Proc(sql)

                sql = ("Update Stock set Stock = Stock - '" & rs1(1) & "' where idproducto = '" & rs1(0) & "'")
                Proc(sql)

            Loop
            sql = ("Select idVehiculo from Vehiculo where Disponible = 1 Limit 1")
            Proc1(sql)
            rs1.Read()

            sql = ("select max(idpedido) from pedido")
            Proc(sql)
            rs.Read()

            sql = ("Insert into entrega values('', '" & rs(0) & "', '" & rs1(0) & "', Date_Add(Curdate(), INTERVAL 3 DAY), 500)")
            Proc(sql)

            sql = ("Select max(Identrega) from entrega")
            Proc(sql)
            rs.Read()

            sql = ("Select CostoEnvio from entrega where identrega = '" & rs(0) & "' ")
            Proc1(sql)
            rs1.Read()

            MontoFinal = Monto + rs1(0)

            sql = ("Insert into recibo values ('', '" & rs(0) & "', '" & MontoFinal & "', Curdate())")
            Proc(sql)

            sql = ("Truncate table PedidoEnProceso")
            Proc(sql)

            MsgBox("Compra Realizada Con exito. Volvera al inicio")
            Me.Close()
            frmMenu.Show()
        Else
            MsgBox("Ingrese Forma de Pago")
        End If

        


    End Sub


    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmMenu.Show()
    End Sub
End Class