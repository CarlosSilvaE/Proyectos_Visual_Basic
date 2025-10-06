
Imports System.Data.OleDb
Public Class Form1
    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        Try
            Dim Agregar = "Insert into habitaciones (Num_habitacion, Tipo, Precio, Foto) values (@Num_habitacion, @Tipo, @Precio, @Foto)"
            Dim cmdAgregar As New OleDbCommand(Agregar, cnx)

            cmdAgregar.Parameters.AddWithValue("@Num_habitacion", txt_NumHabitacion.Text)
            cmdAgregar.Parameters.AddWithValue("@Tipo", txt_Tipo.Text)
            cmdAgregar.Parameters.AddWithValue("@Precio", txt_Precio.Text)
            cmdAgregar.Parameters.AddWithValue("@Foto", pic_Tipo.ImageLocation)

            cnx.Open()
            cmdAgregar.ExecuteNonQuery()
            cnx.Close()
            MsgBox("Registro agregado exitosamente", MsgBoxStyle.Information, "Agenda")
        Catch ex As Exception
            MsgBox("Error al agregar el registro" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Dim Buscar = "SELECT * FROM habitaciones WHERE Num_habitacion=@Num_habitacion"
        Dim cmdBuscar As New OleDbCommand(Buscar, cnx)
        cmdBuscar.CommandType = CommandType.Text
        cmdBuscar.Parameters.AddWithValue("@Num_habitacion", txt_NumHabitacion.Text)

        cnx.Open()
        Dim lectura As OleDbDataReader = cmdBuscar.ExecuteReader()

        If lectura.Read() Then
            txt_Tipo.Text = lectura("Tipo").ToString()
            txt_Precio.Text = lectura("Precio").ToString()
            pic_Tipo.ImageLocation = lectura("Foto").ToString()
        Else
            MsgBox("Los datos no estan registrados", MsgBoxStyle.Information, "Agenda")
            txt_NumHabitacion.Clear()
            txt_NumHabitacion.Focus()
        End If
        cnx.Close()
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        txt_NumHabitacion.Clear()
        txt_Tipo.Clear()
        txt_Precio.Clear()
        pic_Tipo.Image = Nothing
    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        If MsgBox("¿Estas seguro de querer eliminar el registro?", MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            Try
                Dim Eliminar = "DELETE FROM habitaciones WHERE Num_habitacion=@Num_habitacion"
                Dim cmdEliminar As New OleDbCommand(Eliminar, cnx)
                cmdEliminar.Parameters.AddWithValue("@Num_habitacion", txt_NumHabitacion.Text)

                cnx.Open()
                cmdEliminar.ExecuteNonQuery()
                cnx.Close()

                MsgBox("Registro eliminado correctamente", MsgBoxStyle.Information, "Agenda")
                btn_Limpiar.PerformClick()
            Catch ex As Exception
                MsgBox("Error al eliminar registro" & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        Try
            Dim Modificar = "UPDATE habitaciones SET Tipo=@Tipo, Precio=@Precio, Foto=@Foto Where Num_habitacion=@Num_habitacion"
            Dim cmdModificar As New OleDbCommand(Modificar, cnx)

            cmdModificar.Parameters.AddWithValue("@Num_habitacion", txt_NumHabitacion.Text)
            cmdModificar.Parameters.AddWithValue("@Tipo", txt_Tipo.Text)
            cmdModificar.Parameters.AddWithValue("@Precio", txt_Precio.Text)
            cmdModificar.Parameters.AddWithValue("@Foto", pic_Tipo.ImageLocation)

            cnx.Open()
            cmdModificar.ExecuteNonQuery()
            cnx.Close()

            MsgBox("Registro modificado con exito", MsgBoxStyle.Information, "Agenda")
        Catch ex As Exception
            MsgBox("Error al actualizar registro" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class
