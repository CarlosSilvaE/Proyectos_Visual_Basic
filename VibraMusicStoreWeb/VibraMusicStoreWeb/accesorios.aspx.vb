Imports System.Data.SqlClient

Public Class accesorios
    Inherits System.Web.UI.Page

    Public Property IdUsuarioActual As Integer
    Public Property Carrito As New List(Of Producto)   ' Usa la clase compartida Producto

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Recuperar carrito de Session en cada carga
        If Session("Carrito") IsNot Nothing Then
            Carrito = CType(Session("Carrito"), List(Of Producto))
        End If

        ' Recuperar IdUsuario desde la sesión
        If Session("IdUsuario") IsNot Nothing Then
            IdUsuarioActual = Convert.ToInt32(Session("IdUsuario"))
        End If

        If Not IsPostBack Then
            ' Aquí podrías cargar todos los accesorios si lo deseas
        End If
    End Sub

    ' Selección de fila en el GridView
    Protected Sub gvAccesorios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gvAccesorios.SelectedIndexChanged
        Dim fila As GridViewRow = gvAccesorios.SelectedRow
        ddlTipo.SelectedValue = fila.Cells(3).Text
        txtMarca.Text = fila.Cells(4).Text
        txtPrecio.Text = fila.Cells(5).Text.Replace("$", "").Trim()
    End Sub

    ' Agregar accesorio al carrito
    Protected Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If gvAccesorios.SelectedRow Is Nothing Then
            lblMensaje.Text = "Selecciona un accesorio primero."
            Exit Sub
        End If

        Dim fila As GridViewRow = gvAccesorios.SelectedRow
        Dim p As New Producto With {
            .Id = Convert.ToInt32(fila.Cells(1).Text),
            .Nombre = fila.Cells(2).Text,
            .Tipo = fila.Cells(3).Text,
            .Marca = fila.Cells(4).Text,
            .Precio = Convert.ToDecimal(fila.Cells(5).Text.Replace("$", "").Trim())
        }

        Carrito.Add(p)
        Session("Carrito") = Carrito

        lblMensaje.Text = "Accesorio agregado al carrito."
    End Sub

    ' Comprar accesorios
    Protected Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        If Session("Carrito") IsNot Nothing Then
            Carrito = CType(Session("Carrito"), List(Of Producto))
        End If

        If Carrito.Count = 0 Then
            lblMensaje.Text = "El carrito está vacío."
            Exit Sub
        End If

        Session("Carrito") = Carrito
        Session("IdUsuario") = IdUsuarioActual
        Response.Redirect("~/compra.aspx")
    End Sub

    ' Limpiar selección
    Protected Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        gvAccesorios.SelectedIndex = -1
        ddlTipo.SelectedIndex = -1
        txtMarca.Text = ""
        txtPrecio.Text = ""
        lblMensaje.Text = ""
    End Sub

    ' Regresar
    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Response.Redirect("~/inicio_cliente.aspx")
    End Sub

    ' Buscar accesorios
    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim sql As String = "SELECT IdAccesorio, Nombre, Tipo, Marca, Precio FROM Accesorios WHERE 1=1"

        If ddlTipo.SelectedValue <> "" Then
            sql &= " AND Tipo = @Tipo"
        End If

        If txtMarca.Text <> "" Then
            sql &= " AND Marca LIKE @Marca"
        End If

        If txtPrecio.Text <> "" Then
            sql &= " AND Precio <= @Precio"
        End If

        Using cnx As New SqlConnection("Server=C4RL0S_5ILVA\SQLEXPRESS;Database=VibraMusicStore;Integrated Security=True;")
            Using cmd As New SqlCommand(sql, cnx)
                If ddlTipo.SelectedValue <> "" Then cmd.Parameters.AddWithValue("@Tipo", ddlTipo.SelectedValue)
                If txtMarca.Text <> "" Then cmd.Parameters.AddWithValue("@Marca", "%" & txtMarca.Text & "%")
                If txtPrecio.Text <> "" Then cmd.Parameters.AddWithValue("@Precio", Convert.ToDecimal(txtPrecio.Text))

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                gvAccesorios.DataSource = dt
                gvAccesorios.DataBind()

                lblMensaje.Text = If(dt.Rows.Count = 0, "No se encontraron accesorios.", "")
            End Using
        End Using
    End Sub
End Class
