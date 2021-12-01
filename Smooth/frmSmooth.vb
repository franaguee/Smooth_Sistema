Public Class frmMenu

    Private Sub btnPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPedido.Click
        Me.Hide()
        frmPedido.Show()
    End Sub

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conectar()
    End Sub

    Private Sub btnVerRecibo_Click(sender As System.Object, e As System.EventArgs) Handles btnVerRecibo.Click
        Me.Hide()
        frmRecibos.Show()

    End Sub



    Private Sub btnStock_Click(sender As System.Object, e As System.EventArgs) Handles btnStock.Click
        Me.Hide()
        frmStock.Show()

    End Sub
End Class
