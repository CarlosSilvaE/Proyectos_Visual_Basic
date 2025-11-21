Imports System.Data.SqlClient

Public Class Add_Accesorios
    Inherits System.Web.UI.Page

    Private Sub Limpiar()
        txtId.Text = ""
        txtNombre.Text = ""
        ddlTipo.SelectedIndex = -1
        txtPrecio.Text = ""
        txtMarca.Text = ""
    End Sub

    Private Sub CargarAccesorios()
        Dim cn As New SqlConnection("Server=C4RL0S_5ILVA\SQLEXPRESS;Database=VibraMusicStore;Integrated Security=True;")
        Dim da As New SqlDataAdapter("SELECT * FROM Accesorios", cn)
        Dim dt As New DataTable
        da.Fill(dt)
        gvAccesorios.DataSource = dt
        gvAccesorios.DataBind()
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargarAccesorios()
        End If
    End Sub

    Protected Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Protected Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtNombre.Text = "" Or ddlTipo.SelectedValue = "" Or txtPrecio.Text = "" Or txtMarca.Text = "" Then
            lblMensaje.Text = "Por favor llena todos los campos."
            Exit Sub
        End If

        Dim obj As New AccesoriosClase.Accesorios
        With obj
            .Nombre = txtNombre.Text
            .Tipo = ddlTipo.SelectedValue
            .Precio = Convert.ToDecimal(txtPrecio.Text)
            .Marca = txtMarca.Text
        End With

        If obj.Alta() Then
            lblMensaje.Text = "Accesorio registrado correctamente."
            CargarAccesorios()
            Limpiar()
        Else
            lblMensaje.Text = "Error al registrar."
        End If
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtId.Text = "" Then
            lblMensaje.Text = "Ingresa un ID."
            Exit Sub
        End If

        Dim obj As New AccesoriosClase.Accesorios
        obj.IdAccesorio = Convert.ToInt32(txtId.Text)

        If obj.Consultar() Then
            txtNombre.Text = obj.Nombre
            ddlTipo.SelectedValue = obj.Tipo
            txtPrecio.Text = obj.Precio
            txtMarca.Text = obj.Marca
        Else
            lblMensaje.Text = "No se encontró un accesorio con ese ID."
        End If
    End Sub

    Protected Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtId.Text = "" Then
            lblMensaje.Text = "Ingresa un ID para modificar."
            Exit Sub
        End If

        Dim obj As New AccesoriosClase.Accesorios
        With obj
            .IdAccesorio = Convert.ToInt32(txtId.Text)
            .Nombre = txtNombre.Text
            .Tipo = ddlTipo.SelectedValue
            .Precio = Convert.ToDecimal(txtPrecio.Text)
            .Marca = txtMarca.Text
        End With

        If obj.Modificar() Then
            lblMensaje.Text = "Accesorio modificado correctamente."
            CargarAccesorios()
            Limpiar()
        Else
            lblMensaje.Text = "Error al modificar."
        End If
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtId.Text = "" Then
            lblMensaje.Text = "Ingresa un ID para eliminar."
            Exit Sub
        End If

        Dim obj As New AccesoriosClase.Accesorios
        obj.IdAccesorio = Convert.ToInt32(txtId.Text)

        If obj.Baja() Then
            lblMensaje.Text = "Accesorio eliminado."
            CargarAccesorios()
            Limpiar()
        Else
            lblMensaje.Text = "Error al eliminar."
        End If
    End Sub

    Protected Sub gvAccesorios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gvAccesorios.SelectedIndexChanged
        Dim fila As GridViewRow = gvAccesorios.SelectedRow
        txtId.Text = fila.Cells(1).Text
        txtNombre.Text = fila.Cells(2).Text
        ddlTipo.SelectedValue = fila.Cells(3).Text
        txtPrecio.Text = fila.Cells(4).Text
        txtMarca.Text = fila.Cells(5).Text
    End Sub

    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Response.Redirect("~/inicio_empleado.aspx")
    End Sub
End Class
