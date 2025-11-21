Imports System.Data.SqlClient

Public Class inicio_cliente
    Inherits System.Web.UI.Page

    Public Property IdUsuarioActual As Integer
    Public Property NombreUsuario As String
    Private conexion As String = "Server=C4RL0S_5ILVA\SQLEXPRESS;Database=VibraMusicStore;Integrated Security=True;"

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Session("NombreUsuario") IsNot Nothing Then
                NombreUsuario = Session("NombreUsuario").ToString()
                lblNombre.Text = NombreUsuario
            End If

            If Session("IdUsuario") IsNot Nothing Then
                IdUsuarioActual = Convert.ToInt32(Session("IdUsuario"))
            End If

            CargarInstrumentosVendidos()
        End If
    End Sub


    Private Sub CargarInstrumentosVendidos()
        Dim sql As String = "
            SELECT 
                i.Nombre AS Instrumento,
                i.Marca,
                SUM(dv.Cantidad) AS TotalVendido,
                dv.TipoProducto
            FROM DetalleVenta dv
            INNER JOIN Instrumentos i
                ON dv.IdProducto = i.IdInstrumento
            GROUP BY i.Nombre, i.Marca, dv.TipoProducto
            ORDER BY TotalVendido DESC;
        "

        Using cnx As New SqlConnection(conexion)
            Using da As New SqlDataAdapter(sql, cnx)
                Dim dt As New DataTable()
                da.Fill(dt)
                gvInstrumentosVendidos.DataSource = dt
                gvInstrumentosVendidos.DataBind()
            End Using
        End Using
    End Sub

    Protected Sub btnInstrumentos_Click(sender As Object, e As EventArgs) Handles btnInstrumentos.Click
        Response.Redirect("~/instrumentos.aspx")
    End Sub

    Protected Sub btnAccesorios_Click(sender As Object, e As EventArgs) Handles btnAccesorios.Click
        Response.Redirect("~/accesorios.aspx")
    End Sub

    Protected Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Response.Redirect("~/login.aspx")
    End Sub
End Class
