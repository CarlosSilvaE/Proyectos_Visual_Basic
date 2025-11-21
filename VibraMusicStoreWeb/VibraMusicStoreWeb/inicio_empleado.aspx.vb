Public Class inicio_empleado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ' Recupera el nombre del usuario desde la sesión
            If Session("NombreUsuario") IsNot Nothing Then
                lblBienvenida.Text = "Bienvenido, " & Session("NombreUsuario").ToString()
            Else
                ' Si no hay sesión, redirige al login
                Response.Redirect("~/Login.aspx")
            End If
        End If
    End Sub

    ' Métodos de navegación
    Protected Sub lnkInstrumentos_Click(sender As Object, e As EventArgs) Handles lnkInstrumentos.Click
        Response.Redirect("~/Add_Instrumentos.aspx")
    End Sub

    Protected Sub lnkAccesorios_Click(sender As Object, e As EventArgs) Handles lnkAccesorios.Click
        Response.Redirect("~/Add_Accesorios.aspx")
    End Sub

    Protected Sub lnkServicios_Click(sender As Object, e As EventArgs) Handles lnkServicios.Click
        Response.Redirect("~/Add_Servicios.aspx")
    End Sub

    Protected Sub lnkConsultas_Click(sender As Object, e As EventArgs) Handles lnkConsultas.Click
        Response.Redirect("~/Servicios.aspx")
    End Sub

    Protected Sub lnkHistorial_Click(sender As Object, e As EventArgs) Handles lnkHistorial.Click
        Response.Redirect("~/Historial.aspx")
    End Sub

    Protected Sub lnkClientes_Click(sender As Object, e As EventArgs) Handles lnkClientes.Click
        Response.Redirect("~/buscar_clientes.aspx")
    End Sub

    Protected Sub lnkCerrar_Click(sender As Object, e As EventArgs) Handles lnkCerrar.Click
        Session.Clear()
        Response.Redirect("~/Login.aspx")
    End Sub
End Class
