Imports System.Data.SqlClient
Public Class Add_Instrumentos
    Inherits System.Web.UI.Page

    Private Sub Limpiar()
        txtId.Text = ""
        txtNombre.Text = ""
        ddlTipo.SelectedIndex = -1
        txtPrecio.Text = ""
        txtMarca.Text = ""
    End Sub

    Private Sub CargarInstrumentos()
        Dim cn As New SqlConnection("Server=C4RL0S_5ILVA\SQLEXPRESS;Database=VibraMusicStore;Integrated Security=True;")
        Dim da As New SqlDataAdapter("SELECT * FROM Instrumentos", cn)
        Dim dt As New DataTable
        da.Fill(dt)
        gvInstrumentos.DataSource = dt
        gvInstrumentos.DataBind()
    End Sub

    Protected Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargarInstrumentos()
        End If
    End Sub

    Protected Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtNombre.Text = "" Or ddlTipo.SelectedValue = "" Or txtPrecio.Text = "" Or txtMarca.Text = "" Then
            lblMensaje.Text = "Por favor llena todos los campos."
            Exit Sub
        End If

        Dim obj As New InstrumentosClase.Instrumentos
        With obj
            .Nombre = txtNombre.Text
            .Tipo = ddlTipo.SelectedValue
            .Precio = Convert.ToDecimal(txtPrecio.Text)
            .Marca = txtMarca.Text
        End With

        If obj.Alta() Then
            lblMensaje.Text = "Instrumento registrado correctamente."
            CargarInstrumentos()
            Limpiar()
        Else
            lblMensaje.Text = "Error al registrar."
        End If
    End Sub

    Protected Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtId.Text = "" Then
            lblMensaje.Text = "Ingresa un ID para modificar."
            Exit Sub
        End If

        Dim obj As New InstrumentosClase.Instrumentos
        With obj
            .IdInstrumento = Convert.ToInt32(txtId.Text)
            .Nombre = txtNombre.Text
            .Tipo = ddlTipo.SelectedValue
            .Precio = Convert.ToDecimal(txtPrecio.Text)
            .Marca = txtMarca.Text
        End With

        If obj.Modificar() Then
            lblMensaje.Text = "Instrumento modificado correctamente."
            CargarInstrumentos()
            Limpiar()
        Else
            lblMensaje.Text = "Error al modificar."
        End If
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtId.Text = "" Then
            lblMensaje.Text = "Ingresa un ID."
            Exit Sub
        End If

        Dim obj As New InstrumentosClase.Instrumentos
        obj.IdInstrumento = Convert.ToInt32(txtId.Text)

        If obj.Consultar() Then
            txtNombre.Text = obj.Nombre
            ddlTipo.SelectedValue = obj.Tipo
            txtPrecio.Text = obj.Precio
            txtMarca.Text = obj.Marca
        Else
            lblMensaje.Text = "No se encontró un instrumento con ese ID."
        End If
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtId.Text = "" Then
            lblMensaje.Text = "Ingresa un ID para eliminar."
            Exit Sub
        End If

        Dim obj As New InstrumentosClase.Instrumentos
        obj.IdInstrumento = Convert.ToInt32(txtId.Text)

        If obj.Baja() Then
            lblMensaje.Text = "Instrumento eliminado."
            CargarInstrumentos()
            Limpiar()
        Else
            lblMensaje.Text = "Error al eliminar."
        End If
    End Sub

    Protected Sub gvInstrumentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gvInstrumentos.SelectedIndexChanged
        Dim fila As GridViewRow = gvInstrumentos.SelectedRow
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
