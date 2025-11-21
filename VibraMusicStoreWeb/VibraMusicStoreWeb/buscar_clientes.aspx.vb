Imports System.Data.SqlClient

Public Class buscar_clientes
    Inherits System.Web.UI.Page

    Private conexion As String = "Server=C4RL0S_5ILVA\SQLEXPRESS;Database=VibraMusicStore;Integrated Security=True;"

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Using cnx As New SqlConnection(conexion)
            Dim sql As String = "SELECT IdUsuario, Nombre, Correo, Contrasena, TipoUsuario " &
                                "FROM Usuarios " &
                                "WHERE TipoUsuario='Cliente' AND " &
                                "(IdUsuario = @Id OR Nombre LIKE @Nombre OR Correo LIKE @Correo OR Contrasena LIKE @Contrasena OR TipoUsuario LIKE @TipoUsuario)"

            Dim cmd As New SqlCommand(sql, cnx)

            Dim idBuscado As Integer
            If Integer.TryParse(txtId.Text, idBuscado) Then
                cmd.Parameters.AddWithValue("@Id", idBuscado)
            Else
                cmd.Parameters.AddWithValue("@Id", 0)
            End If

            cmd.Parameters.AddWithValue("@Nombre", "%" & txtNombre.Text & "%")
            cmd.Parameters.AddWithValue("@Correo", "%" & txtCorreo.Text & "%")
            cmd.Parameters.AddWithValue("@Contrasena", "%" & txtPassword.Text & "%")
            cmd.Parameters.AddWithValue("@TipoUsuario", "%" & ddlNivel.SelectedValue & "%")

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            gvClientes.DataSource = dt
            gvClientes.DataBind()
        End Using
    End Sub

    Protected Sub gvClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gvClientes.SelectedIndexChanged
        Dim fila As GridViewRow = gvClientes.SelectedRow
        txtId.Text = fila.Cells(1).Text
        txtNombre.Text = fila.Cells(2).Text
        txtCorreo.Text = fila.Cells(3).Text
        txtPassword.Text = fila.Cells(4).Text
        ddlNivel.SelectedValue = fila.Cells(5).Text
    End Sub

    Protected Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtId.Text = ""
        txtCorreo.Text = ""
        txtPassword.Text = ""
        txtNombre.Text = ""
        ddlNivel.SelectedIndex = -1
        gvClientes.DataSource = Nothing
        gvClientes.DataBind()
    End Sub

    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Response.Redirect("~/inicio_empleado.aspx")
    End Sub
End Class
