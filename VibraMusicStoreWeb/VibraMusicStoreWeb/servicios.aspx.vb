Imports System.Data.SqlClient

Public Class servicios
    Inherits System.Web.UI.Page

    Private conexion As String = "Server=C4RL0S_5ILVA\SQLEXPRESS;Database=VibraMusicStore;Integrated Security=True;"

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim sql As String = ""

        Select Case ddlCriterio.SelectedValue
            Case "Cliente"
                If txtIdCliente.Text = "" Then Exit Sub
                sql = "SELECT s.IdServicio, u.Nombre AS Cliente, s.Instrumento, s.Estatus AS Estado, s.FechaIngreso AS Fecha " &
                      "FROM Servicios s INNER JOIN Usuarios u ON s.IdUsuario = u.IdUsuario WHERE s.IdUsuario=@IdUsuario"

            Case "Instrumento"
                If ddlInstrumento.SelectedValue = "" Then Exit Sub
                sql = "SELECT s.IdServicio, u.Nombre AS Cliente, s.Instrumento, s.Estatus AS Estado, s.FechaIngreso AS Fecha " &
                      "FROM Servicios s INNER JOIN Usuarios u ON s.IdUsuario = u.IdUsuario WHERE s.Instrumento=@Instrumento"

            Case "Vigentes"
                sql = "SELECT s.IdServicio, u.Nombre AS Cliente, s.Instrumento, s.Estatus AS Estado, s.FechaIngreso AS Fecha " &
                      "FROM Servicios s INNER JOIN Usuarios u ON s.IdUsuario = u.IdUsuario WHERE s.Estatus='Vigente'"

            Case "Finalizados"
                sql = "SELECT s.IdServicio, u.Nombre AS Cliente, s.Instrumento, s.Estatus AS Estado, s.FechaIngreso AS Fecha " &
                      "FROM Servicios s INNER JOIN Usuarios u ON s.IdUsuario = u.IdUsuario WHERE s.Estatus='Finalizado'"

            Case Else
                Exit Sub
        End Select

        Using cnx As New SqlConnection(conexion)
            Using cmd As New SqlCommand(sql, cnx)
                If ddlCriterio.SelectedValue = "Cliente" Then
                    cmd.Parameters.AddWithValue("@IdUsuario", Convert.ToInt32(txtIdCliente.Text))
                ElseIf ddlCriterio.SelectedValue = "Instrumento" Then
                    cmd.Parameters.AddWithValue("@Instrumento", ddlInstrumento.SelectedValue)
                End If

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                gvServicios.DataSource = dt
                gvServicios.DataBind()
            End Using
        End Using
    End Sub

    Protected Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        gvServicios.DataSource = Nothing
        gvServicios.DataBind()
        ddlCriterio.SelectedIndex = -1
        txtIdCliente.Text = ""
        ddlInstrumento.SelectedIndex = -1
    End Sub

    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Response.Redirect("~/inicio_empleado.aspx")
    End Sub
End Class
