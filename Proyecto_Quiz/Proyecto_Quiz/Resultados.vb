Public Class Resultados
    Private Sub btn_Cerrar_Click(sender As Object, e As EventArgs) Handles btn_Cerrar.Click
        'Aqui solamente cerramos la ventana y regresamos al inicio al darle al boton de cerrar
        Me.Close()
        Bienvenida.Show()
    End Sub

    Private Sub Resultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Lo que queremos es que nos muestre el total del resultado, eso lo haremos con el label

        lvl_Resultado.Text = "Tu resultado es: " & puntaje & " / 3"

        'Dependiendo el puntaje que haya sacado mostrara una imagen diferente

        If puntaje = 3 Then
            pbx_Result.Image = Proyecto_Quiz.My.Resources.Aprobado
        ElseIf puntaje = 2 Then
            pbx_Result.Image = Proyecto_Quiz.My.Resources.segundo
        ElseIf puntaje = 1 Then
            pbx_Result.Image = Proyecto_Quiz.My.Resources.tercer
        Else
            pbx_Result.Image = Proyecto_Quiz.My.Resources.Reprobado
        End If
    End Sub
End Class