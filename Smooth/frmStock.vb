Public Class frmStock

    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click


        sql = ("Select idproducto from producto where descripcion = '" & cmbProdStock.SelectedItem & "' ")
        Proc(sql)
        rs.Read()

        sql = ("Update stock set stock = stock + '" & txtCantStock.Text & "' where idproducto = '" & rs(0) & "' ")
        Proc1(sql)

        sql = ("Select stock from stock where idproducto = '" & rs(0) & "' ")
        Proc(sql)
        rs.Read()

        lstStock.Items.Add("Producto: " & cmbProdStock.SelectedItem & " - Stock: " & rs(0))
    End Sub

    Private Sub btnLimpiarStock_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiarStock.Click
        cmbProdStock.Text = ""
        txtCantStock.Text = ""
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim Consulta As String
        Consulta = InputBox("Ingrese Producto para Consultar Stock", "Consulta")

        If Consulta <> "" Then
            sql = ("Select idProducto from producto where Descripcion = '" & Consulta & "' ")
            Proc(sql)
            rs.Read()

            sql = ("Select Stock from stock where idProducto = '" & rs(0) & "' ")
            Proc(sql)
            rs.Read()

            MsgBox("Producto: " & Consulta & " - Stock: " & rs(0))
        Else
            MsgBox("Ingrese Producto")
        End If
        

    End Sub
End Class