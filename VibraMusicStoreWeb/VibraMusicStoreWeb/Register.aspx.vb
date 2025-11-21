Public Class Register
    Inherits System.Web.UI.Page

    Protected Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        ' Redirige al login
        Response.Redirect("~/Login.aspx")
    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim agregar As New LoginClase.Usuarios

        With agregar
            .Nombre = txtNombre.Text
            .Correo = txtUsuario.Text
            .Contrasena = txtContrasena.Text
            .TipoUsuario = ddlTipo.SelectedValue
        End With

        If agregar.Registrar() Then
            lblMensaje.Text = "Usuario registrado correctamente."
            lblMensaje.ForeColor = Drawing.Color.Green
        Else
            lblMensaje.Text = "Error al registrar usuario."
            lblMensaje.ForeColor = Drawing.Color.Red
        End If
    End Sub
End Class
