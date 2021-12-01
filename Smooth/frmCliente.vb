Public Class frmCliente

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Sub bntVerifClie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntVerifClie.Click
        DniPersona = txtDniVerif.Text

        sql = ("Select count(*) from persona where Dni = '" & txtDniVerif.Text & "'")
        Proc(sql)
        rs.Read()



        If txtDniVerif.Text <> "" Then
            If rs(0) > 0 Then
                


                Me.Hide()
                frmPago.Show()
            Else
                MsgBox("No sos cliente. Por favor registrarse")
                Me.Hide()
                frmIngresarCliente.Show()
            End If
        Else
            MsgBox("Ingrese Datos")
        End If
       


    End Sub
End Class