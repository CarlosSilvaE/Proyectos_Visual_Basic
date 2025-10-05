Public Class Confirmar_Compra
    Private Sub Confirmar_Compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Pedidos.Text = PedidoDetalle
        txt_Total.Text = "$" & TotalPedido
    End Sub

    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Dim menu As New Menu
        menu.Show()
        Me.Close()
    End Sub

    Private Sub btn_Confirmar_Click(sender As Object, e As EventArgs) Handles btn_Confirmar.Click
        Dim exitosa As New Compra_Exitosa()
        Compra_Exitosa.Show()
        Me.Close()
    End Sub
End Class