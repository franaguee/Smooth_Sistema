Public Class frmIngresarCliente

    

    
    Private Sub btnNuevoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoCliente.Click

        If txtNuevoDni.Text <> "" And txtNuevoNombre.Text <> "" And txtNuevoDireccion.Text <> "" And txtNuevoTel.Text <> "" Then
            sql = ("Insert into persona values ('', '" & txtNuevoDni.Text & "', '" & txtNuevoNombre.Text & "', '" & txtNuevoTel.Text & "', '" & txtNuevoDireccion.Text & "' )")
            Proc(sql)

            sql = ("Select idpersona from persona where dni = '" & txtNuevoDni.Text & "'")
            Proc(sql)

            rs.Read()
            sql = ("Insert into cliente values ('', '" & rs(0) & "') ")
            Proc(sql)

            MsgBox("Cliente Registrado Con Exito. Ya puede realizar el pago")

            Me.Close()
            frmPago.Show()
        Else
            MsgBox("Ingrese todos los datos")
        End If
        

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmMenu.Show()
    End Sub
End Class