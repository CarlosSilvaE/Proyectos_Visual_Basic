Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If txtUsuario.Text = "" Or txtContrasena.Text = "" Then
            lblMensaje.Text = "Por favor llene todos los campos."
            lblMensaje.ForeColor = Drawing.Color.Yellow
            Exit Sub
        End If

        Dim u As New LoginClase.Usuarios
        u.Correo = txtUsuario.Text
        u.Contrasena = txtContrasena.Text

        If u.Login() Then
            Session("NombreUsuario") = u.Nombre
            Session("IdUsuario") = u.Id   ' <-- usa siempre esta clave
            Session("TipoUsuarioActual") = u.TipoUsuario

            Select Case u.TipoUsuario
                Case "Empleado"
                    Response.Redirect("~/inicio_empleado.aspx")
                Case "Cliente"
                    Response.Redirect("~/inicio_cliente.aspx")
            End Select
        Else
            lblMensaje.Text = "Correo o contraseña incorrectos."
            lblMensaje.ForeColor = Drawing.Color.Red
        End If
    End Sub

    Protected Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Response.Redirect("~/Register.aspx")
    End Sub
End Class
