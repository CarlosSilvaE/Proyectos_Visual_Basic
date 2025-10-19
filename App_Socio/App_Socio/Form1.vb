Imports System.Data.SqlClient
Public Class Form1
    Dim conexion As String =
            "Server=C4RL0S_5ILVA\SQLEXPRESS; " &
            "database=Socio;" &
            "Integrated Security=True;"
    Public Sub limpiar()

        txtId.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()

    End Sub
    Private Sub NuevoTsm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoTsm.Click
        limpiar()
    End Sub

    Private Sub ConsultarTsm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarTsm.Click
        Dim consultar As New ClassLibrarySocio.Socio
        With consultar
            .Id = txtId.Text
            If consultar.socioConsultar Then
                txtNombre.Text = .Nombre
                txtApellido.Text = .Apellido
                txtDireccion.Text = .Direccion
                txtTelefono.Text = .Telefono
            End If
        End With
    End Sub

    Private Sub AgregarTsm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarTsm.Click
        Dim agregar As New ClassLibrarySocio.Socio

        With agregar
            .Id = txtId.Text
            .Nombre = txtNombre.Text
            .Apellido = txtApellido.Text
            .Direccion = txtDireccion.Text
            .Telefono = txtTelefono.Text

        End With
        If agregar.socioAlta Then

        End If
        limpiar()
    End Sub

    Private Sub ModificarTsm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarTsm.Click
        Dim modificar As New ClassLibrarySocio.Socio

        With modificar
            .Nombre = txtNombre.Text
            .Apellido = txtApellido.Text
            .Direccion = txtDireccion.Text
            .Telefono = txtTelefono.Text
            .Id = txtId.Text

            If modificar.socioModificar Then

            End If

            limpiar()

        End With
    End Sub

    Private Sub EliminarTsm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarTsm.Click
        Dim eliminar As New ClassLibrarySocio.Socio

        With eliminar
            .Id = txtId.Text

        End With

        If eliminar.socioBaja Then

        End If
        limpiar()

    End Sub

    Private Sub txtId_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cnx As New SqlConnection(conexion)
        Dim cmd As New SqlCommand("dbo.socConsultar", cnx)

        cmd.CommandType = CommandType.StoredProcedure

        Dim socNombre, socApellido, socDireccion, socTelefono As String
        Dim pasar As Boolean

        cmd.Parameters.Add(New SqlParameter("@Id", txtId.Text))

        cnx.Open()
        Dim leer As SqlDataReader
        leer = cmd.ExecuteReader

        If leer.Read() Then
            socNombre = leer(1).ToString
            socApellido = leer(2).ToString
            socDireccion = leer(3).ToString
            socTelefono = leer(4).ToString

            txtNombre.Text = socNombre
            txtApellido.Text = socApellido
            txtDireccion.Text = socDireccion
            txtTelefono.Text = socTelefono

            cnx.Close()
        End If
    End Sub

    Private Sub SalirTsm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirTsm.Click
        End
    End Sub
End Class
