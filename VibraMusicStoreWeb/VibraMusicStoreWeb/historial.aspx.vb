Imports System.Data.SqlClient

Public Class Historial
    Inherits System.Web.UI.Page

    Public Property IdUsuarioActual As Integer
    Public Property TipoUsuarioActual As String
    Private conexion As String = "Server=C4RL0S_5ILVA\SQLEXPRESS;Database=VibraMusicStore;Integrated Security=True;"

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If IdUsuarioActual = 0 Then
                lblMensaje.Text = "No hay usuario seleccionado."
                Exit Sub
            End If

            RegistrarAcceso()  ' Inserta automáticamente en HistorialAccesos
            CargarHistorial()  ' Carga todos los accesos del usuario actual
        End If
    End Sub

    Private Sub RegistrarAcceso()
        Using cnx As New SqlConnection(conexion)
            Dim sql As String = "INSERT INTO HistorialAccesos (IdUsuario) VALUES (@IdUsuario)"
            Using cmd As New SqlCommand(sql, cnx)
                cmd.Parameters.AddWithValue("@IdUsuario", IdUsuarioActual)
                cnx.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub CargarHistorial()
        Using cnx As New SqlConnection(conexion)
            Dim sql As String = "SELECT h.IdAcceso, u.Nombre, u.TipoUsuario, h.FechaHora
                                 FROM HistorialAccesos h
                                 INNER JOIN Usuarios u ON h.IdUsuario = u.IdUsuario
                                 WHERE h.IdUsuario = @IdUsuario
                                 ORDER BY h.FechaHora DESC"

            Using cmd As New SqlCommand(sql, cnx)
                cmd.Parameters.AddWithValue("@IdUsuario", IdUsuarioActual)
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                gvIngresos.DataSource = dt
                gvIngresos.DataBind()
            End Using
        End Using
    End Sub

    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        If TipoUsuarioActual = "Empleado" Then
            Response.Redirect("~/inicio_empleado.aspx")
        Else
            Response.Redirect("~/inicio_cliente.aspx")
        End If
    End Sub
End Class
