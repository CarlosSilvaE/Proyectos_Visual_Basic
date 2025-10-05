Public Class Compra_Exitosa
    Private Sub Compra_Exitosa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Compra.Text = TotalPedido
    End Sub

    Private Sub btn_Menu_Click(sender As Object, e As EventArgs) Handles btn_Menu.Click
        Dim menu As New Menu
        menu.Show()
        Me.Close()
    End Sub
End Class