Imports System.Data.SqlClient

Public Class Compra
    Inherits System.Web.UI.Page

    Public Property IdUsuario As Integer
    Public Property ListaCarrito As New List(Of Producto)   ' Usa la clase compartida Producto

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Recuperar carrito y usuario desde Session
        If Session("Carrito") IsNot Nothing Then
            ListaCarrito = CType(Session("Carrito"), List(Of Producto))
        End If
        If Session("IdUsuario") IsNot Nothing Then
            IdUsuario = Convert.ToInt32(Session("IdUsuario"))
        End If

        If Not IsPostBack Then
            MostrarDetalle()
        End If
    End Sub

    Private Sub MostrarDetalle()
        Dim total As Decimal = 0
        pnlDetalle.Controls.Clear()

        For Each p In ListaCarrito
            Dim item As New Label()
            item.Text = $"{p.Id} - {p.Nombre} - {p.Tipo} - {p.Marca} - ${p.Precio}"
            item.CssClass = "detalle-item"
            pnlDetalle.Controls.Add(item)
            pnlDetalle.Controls.Add(New LiteralControl("<br/>"))
            total += p.Precio
        Next

        Dim descuento As Decimal = 0
        If total >= 30000 Then
            descuento = total * 0.07D
            total -= descuento
        End If

        lblTotal.Text = "Total: $" & total.ToString("0.00")
    End Sub

    Protected Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        If ListaCarrito.Count = 0 Then
            lblMensaje.Text = "El carrito está vacío."
            Exit Sub
        End If

        Dim totalCompra As Decimal = ListaCarrito.Sum(Function(p) p.Precio)
        Dim descuento As Decimal = 0

        If totalCompra >= 30000 Then
            descuento = totalCompra * 0.07D
            totalCompra -= descuento
        End If

        Using cnx As New SqlConnection("Server=C4RL0S_5ILVA\SQLEXPRESS;Database=VibraMusicStore;Integrated Security=True;")
            Dim sqlVenta As String =
            "INSERT INTO Ventas (IdUsuario, Total) 
             VALUES (@IdUsuario, @Total);
             SELECT SCOPE_IDENTITY();"

            Dim cmdVenta As New SqlCommand(sqlVenta, cnx)
            cmdVenta.Parameters.AddWithValue("@IdUsuario", IdUsuario)
            cmdVenta.Parameters.AddWithValue("@Total", totalCompra)

            cnx.Open()
            Dim idVenta As Integer = Convert.ToInt32(cmdVenta.ExecuteScalar())
            cnx.Close()

            For Each p In ListaCarrito
                Dim precioFinal As Decimal = p.Precio
                If descuento > 0 Then
                    Dim porcentaje As Decimal = p.Precio / ListaCarrito.Sum(Function(x) x.Precio)
                    precioFinal -= descuento * porcentaje
                End If

                Dim sqlDetalle As String =
                "INSERT INTO DetalleVenta (IdVenta, IdProducto, TipoProducto, Cantidad, PrecioUnitario)
                 VALUES (@IdVenta, @IdProducto, @TipoProducto, 1, @Precio);"

                Dim cmdDetalle As New SqlCommand(sqlDetalle, cnx)
                cmdDetalle.Parameters.AddWithValue("@IdVenta", idVenta)
                cmdDetalle.Parameters.AddWithValue("@IdProducto", p.Id)
                cmdDetalle.Parameters.AddWithValue("@TipoProducto", p.Tipo)
                cmdDetalle.Parameters.AddWithValue("@Precio", precioFinal)

                cnx.Open()
                cmdDetalle.ExecuteNonQuery()
                cnx.Close()
            Next
        End Using

        lblMensaje.Text = "Compra realizada correctamente." &
                      If(descuento > 0, " Se aplicó un 7% de descuento.", "")
        ListaCarrito.Clear()
        Session("Carrito") = ListaCarrito
        MostrarDetalle()
    End Sub


    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Response.Redirect("~/inicio_cliente.aspx")
    End Sub

    Protected Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        ListaCarrito.Clear()
        Session("Carrito") = ListaCarrito
        pnlDetalle.Controls.Clear()
        lblTotal.Text = "Total: $0.00"
        lblMensaje.Text = "Carrito limpiado correctamente."
    End Sub
End Class
