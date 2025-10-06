Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Me.HabitacionesTableAdapter.Fill(Me.Hotel_ReservasDataSet.Habitaciones)
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.Exit()
    End Sub
End Class
