Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.Exit()
    End Sub

    Private Sub btn_Siguiente_Click(sender As Object, e As EventArgs) Handles btn_Siguiente.Click
        Me.HabitacionesBindingSource.MoveNext()
    End Sub

    Private Sub btn_Primero_Click(sender As Object, e As EventArgs) Handles btn_Primero.Click
        Me.HabitacionesBindingSource.MoveFirst()
    End Sub

    Private Sub btn_Ultimo_Click(sender As Object, e As EventArgs) Handles btn_Ultimo.Click
        Me.HabitacionesBindingSource.MoveLast()
    End Sub

    Private Sub btn_Anterior_Click(sender As Object, e As EventArgs) Handles btn_Anterior.Click
        Me.HabitacionesBindingSource.MovePrevious(q)
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Me.HabitacionesTableAdapter.Fill(Me.Hotel_ReservasDataSet.Habitaciones)
    End Sub
End Class
