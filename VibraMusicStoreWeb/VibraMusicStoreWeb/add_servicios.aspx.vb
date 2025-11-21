Imports System.Data.SqlClient

Public Class add_servicios
    Inherits System.Web.UI.Page

    Private conexion As String = "Server=C4RL0S_5ILVA\SQLEXPRESS;Database=VibraMusicStore;Integrated Security=True;"
    Private Property IdServicioSeleccionado As Integer

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargarServicios()
        End If
    End Sub

    ' Cargar todos los servicios con nombre del cliente y total
    Private Sub CargarServicios()
        Dim sql As String = "
            SELECT 
                s.IdServicio,
                u.Nombre AS Cliente,
                s.TipoServicio,
                s.Detalles,
                s.Instrumento,
                s.Total
            FROM Servicios s
            INNER JOIN Usuarios u ON s.IdUsuario = u.IdUsuario
        "
        Using cnx As New SqlConnection(conexion)
            Using da As New SqlDataAdapter(sql, cnx)
                Dim dt As New DataTable()
                da.Fill(dt)
                gvServicios.DataSource = dt
                gvServicios.DataBind()
            End Using
        End Using
    End Sub

    ' Seleccionar fila del GridView y cargar datos al formulario
    Protected Sub gvServicios_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim fila As GridViewRow = gvServicios.SelectedRow
        txtId.Text = fila.Cells(1).Text
        txtCliente.Text = fila.Cells(2).Text
        ddlTipoServicio.SelectedValue = fila.Cells(3).Text
        txtDetalles.Text = fila.Cells(4).Text
        ddlInstrumento.SelectedValue = fila.Cells(5).Text
        txtPrecio.Text = fila.Cells(6).Text.Replace("$", "").Trim()
    End Sub

    ' Agregar nuevo servicio
    Protected Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim precio As Decimal
        If Not Decimal.TryParse(txtPrecio.Text, precio) Then Exit Sub

        Dim imagenBytes() As Byte = Nothing
        If fuImagen.HasFile Then
            imagenBytes = fuImagen.FileBytes
            imgPreview.ImageUrl = "data:image/png;base64," & Convert.ToBase64String(imagenBytes)
        End If

        ' Usa el IdUsuario de sesión (cliente logueado)
        Dim idUsuario As Integer = Convert.ToInt32(Session("IdUsuario"))

        Using cnx As New SqlConnection(conexion)
            Dim sql As String = "INSERT INTO Servicios (IdUsuario, TipoServicio, Detalles, Instrumento, Total, Imagen, Estatus) 
                                 VALUES (@IdUsuario, @TipoServicio, @Detalles, @Instrumento, @Total, @Imagen, 'Vigente')"
            Using cmd As New SqlCommand(sql, cnx)
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario)
                cmd.Parameters.AddWithValue("@TipoServicio", ddlTipoServicio.SelectedValue)
                cmd.Parameters.AddWithValue("@Detalles", txtDetalles.Text)
                cmd.Parameters.AddWithValue("@Instrumento", ddlInstrumento.SelectedValue)
                cmd.Parameters.AddWithValue("@Total", precio)
                cmd.Parameters.Add("@Imagen", SqlDbType.VarBinary, -1).Value = If(imagenBytes, DBNull.Value)
                cnx.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
        CargarServicios()
    End Sub

    ' Buscar servicios por nombre del cliente
    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim sql As String = "
            SELECT 
                s.IdServicio,
                u.Nombre AS Cliente,
                s.TipoServicio,
                s.Detalles,
                s.Instrumento,
                s.Total
            FROM Servicios s
            INNER JOIN Usuarios u ON s.IdUsuario = u.IdUsuario
            WHERE u.Nombre LIKE @Cliente
        "
        Using cnx As New SqlConnection(conexion)
            Using cmd As New SqlCommand(sql, cnx)
                cmd.Parameters.AddWithValue("@Cliente", "%" & txtCliente.Text & "%")
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                gvServicios.DataSource = dt
                gvServicios.DataBind()
            End Using
        End Using
    End Sub

    ' Limpiar formulario
    Protected Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtId.Text = ""
        txtCliente.Text = ""
        ddlTipoServicio.SelectedIndex = -1
        txtDetalles.Text = ""
        ddlInstrumento.SelectedIndex = -1
        txtPrecio.Text = ""
        imgPreview.ImageUrl = ""
        fuImagen.Attributes.Clear()
        IdServicioSeleccionado = 0
    End Sub

    ' Regresar al inicio empleado
    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Response.Redirect("~/inicio_empleado.aspx")
    End Sub
End Class
