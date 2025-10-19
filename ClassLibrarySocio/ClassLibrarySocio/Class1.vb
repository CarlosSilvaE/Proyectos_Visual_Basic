Imports System.Data.SqlClient
Public Class Socio
    'PONEMOS LA CONEXION GLOBAL PARA NO ESTAR REPITIENDO TANTO CODIGO'
    Dim conexion As String =
            "Server=C4RL0S_5ILVA\SQLEXPRESS; " &
            "database=Socio;" &
            "Integrated Security=True;"

#Region "Definicion de propiedades"
    Private MstrId As String
    Private MstrNombre As String
    Private MstrApellido As String
    Private MstrDireccion As String
    Private MstrTelefono As String
#End Region
#Region "Hacer publico el acceso a las propiedades"
    Public Property Id() As String
        Get
            Return MstrId
        End Get
        Set(ByVal value As String)
            MstrId = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return MstrNombre
        End Get
        Set(ByVal value As String)
            MstrNombre = value
        End Set
    End Property

    Public Property Apellido() As String
        Get
            Return MstrApellido
        End Get
        Set(ByVal value As String)
            MstrApellido = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return MstrDireccion
        End Get
        Set(ByVal value As String)
            MstrDireccion = value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return MstrTelefono
        End Get
        Set(ByVal value As String)
            MstrTelefono = value
        End Set
    End Property

#End Region
#Region "Definicion de metodos"

    Public Function socioAlta() As Boolean

        Dim cnx As New SqlConnection(conexion)
        Dim cmd As New SqlCommand("dbo.socAlta", cnx)


        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cmd.Parameters.Add(New SqlParameter("@Nombre", MstrNombre))
        cmd.Parameters.Add(New SqlParameter("@Apellido", MstrApellido))
        cmd.Parameters.Add(New SqlParameter("@Direccion", MstrDireccion))
        cmd.Parameters.Add(New SqlParameter("@Telefono", MstrTelefono))

        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()

    End Function

    Public Function socioBaja() As Boolean

        Dim cnx As New SqlConnection(conexion)
        Dim cmd As New SqlCommand("dbo.socEliminar", cnx)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))

        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()

    End Function

    Public Function socioModificar() As Boolean

        Dim cnx As New SqlConnection(conexion)
        Dim cmd As New SqlCommand("dbo.socActualizar", cnx)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Nombre", MstrNombre))
        cmd.Parameters.Add(New SqlParameter("@Apellido", MstrApellido))
        cmd.Parameters.Add(New SqlParameter("@Direccion", MstrDireccion))
        cmd.Parameters.Add(New SqlParameter("@Telefono", MstrTelefono))
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))

        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()

    End Function

    Public Function socioConsultar() As Boolean

        Dim cnx As New SqlConnection(conexion)
        Dim cmd As New SqlCommand("dbo.socConsultar", cnx)

        cmd.CommandType = CommandType.StoredProcedure

        Dim socNombre, socApellido, socDireccion, socTelefono As String
        Dim pasar As Boolean

        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))

        cnx.Open()
        Dim leer As SqlDataReader
        leer = cmd.ExecuteReader

        If leer.Read() Then
            socNombre = leer(1).ToString
            socApellido = leer(2).ToString
            socDireccion = leer(3).ToString
            socTelefono = leer(4).ToString

            Nombre = socNombre
            Apellido = socApellido
            Direccion = socDireccion
            Telefono = socTelefono

            cnx.Close()
        End If

        If pasar Then
            Return False
        Else
            Return True
        End If
    End Function
#End Region

End Class
