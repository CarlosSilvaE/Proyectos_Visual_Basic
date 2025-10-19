Imports System.Data.SqlClient
Public Class Videogames
    Dim conexion As String =
            "Server=C4RL0S_5ILVA\SQLEXPRESS; " &
            "database=Socio;" &
            "Integrated Security=True;"

    Private Sub Limpiar()
        txtId.Clear()
        txtNombre.Clear()
        txtGenero.Clear()
        txtCompañia.Clear()
        txtPrecio.Clear()
    End Sub
    Private Sub NuevoTsm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoTsm.Click
        Limpiar()
    End Sub

    Private Sub AgregarTsm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarTsm.Click
        Dim agregar As New ClassLibraryVideogames.Videogames
        With agregar
            .Id = txtId.Text
            .Nombre = txtNombre.Text
            .Genero = txtGenero.Text
            .Compañia = txtCompañia.Text
            .Precio = txtPrecio.Text

        End With
        If agregar.videogamesAlta Then

        End If

        Limpiar()
    End Sub

    Private Sub consultarTsm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles consultarTsm.Click
        Dim consultar As New ClassLibraryVideogames.Videogames
        With consultar
            .Id = txtId.Text
            If consultar.videogamesConsultar Then
                txtNombre.Text = .Nombre
                txtGenero.Text = .Genero
                txtCompañia.Text = .Compañia
                txtPrecio.Text = .Precio
            End If
        End With
    End Sub

    Private Sub modificarTsm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modificarTsm.Click
        Dim modificar As New ClassLibraryVideogames.Videogames

        With modificar
            .Nombre = txtNombre.Text
            .Genero = txtGenero.Text
            .Compañia = txtCompañia.Text
            .Precio = txtPrecio.Text
            .Id = txtId.Text

            If modificar.videogamesModificar Then

            End If

            Limpiar()

        End With
    End Sub

    Private Sub eliminarTsm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminarTsm.Click
        Dim eliminar As New ClassLibraryVideogames.Videogames

        With eliminar
            .Id = txtId.Text

        End With

        If eliminar.videogamesBaja Then

        End If
        Limpiar()
    End Sub

    Private Sub salirTsm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salirTsm.Click
        End
    End Sub

    Private Sub txtId_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cnx As New SqlConnection(conexion)
        Dim cmd As New SqlCommand("dbo.vidConsultar", cnx)

        cmd.CommandType = CommandType.StoredProcedure

        Dim vidNombre, vidGenero, vidCompañia, vidPrecio As String

        cmd.Parameters.Add(New SqlParameter("@Id", txtId.Text))

        cnx.Open()
        Dim leer As SqlDataReader
        leer = cmd.ExecuteReader

        If leer.Read() Then
            vidNombre = leer(1).ToString
            vidGenero = leer(2).ToString
            vidCompañia = leer(3).ToString
            vidPrecio = leer(4).ToString

            txtNombre.Text = vidNombre
            txtGenero.Text = vidGenero
            txtCompañia.Text = vidCompañia
            txtPrecio.Text = vidPrecio

            cnx.Close()
        End If
    End Sub
End Class
