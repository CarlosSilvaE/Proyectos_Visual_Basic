Imports System.Data.SqlClient
Public Class Videogames
    Dim conexion As String =
            "Server=C4RL0S_5ILVA\SQLEXPRESS; " &
            "database=Videogames;" &
            "Integrated Security=True;"

#Region "Definicion de propiedades"
    Private MstrId As String
    Private MstrNombre As String
    Private MstrGenero As String
    Private MstrCompañia As String
    Private MstrPrecio As String
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

    Public Property Genero() As String
        Get
            Return MstrGenero
        End Get
        Set(ByVal value As String)
            MstrGenero = value
        End Set
    End Property

    Public Property Compañia() As String
        Get
            Return MstrCompañia
        End Get
        Set(ByVal value As String)
            MstrCompañia = value
        End Set
    End Property

    Public Property Precio() As String
        Get
            Return MstrPrecio
        End Get
        Set(ByVal value As String)
            MstrPrecio = value
        End Set
    End Property
#End Region
#Region "Definicion de metodos"
    Public Function videogamesAlta() As Boolean

        Dim cnx As New SqlConnection(conexion)
        Dim cmd As New SqlCommand("dbo.vidAlta", cnx)


        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cmd.Parameters.Add(New SqlParameter("@Nombre", MstrNombre))
        cmd.Parameters.Add(New SqlParameter("@Genero", MstrGenero))
        cmd.Parameters.Add(New SqlParameter("@Compañia", MstrCompañia))
        cmd.Parameters.Add(New SqlParameter("@Precio", MstrPrecio))

        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()

    End Function

    Public Function videogamesBaja() As Boolean

        Dim cnx As New SqlConnection(conexion)
        Dim cmd As New SqlCommand("dbo.vidBaja", cnx)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))

        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()

    End Function

    Public Function videogamesModificar() As Boolean

        Dim cnx As New SqlConnection(conexion)
        Dim cmd As New SqlCommand("dbo.vidModificar", cnx)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Nombre", MstrNombre))
        cmd.Parameters.Add(New SqlParameter("@Genero", MstrGenero))
        cmd.Parameters.Add(New SqlParameter("@Compañia", MstrCompañia))
        cmd.Parameters.Add(New SqlParameter("@Precio", MstrPrecio))
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))

        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()

    End Function

    Public Function videogamesConsultar() As Boolean

        Dim cnx As New SqlConnection(conexion)
        Dim cmd As New SqlCommand("dbo.vidConsultar", cnx)

        cmd.CommandType = CommandType.StoredProcedure

        Dim vidNombre, vidGenero, vidCompañia, vidPrecio As String
        Dim pasar As Boolean

        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))

        cnx.Open()
        Dim leer As SqlDataReader
        leer = cmd.ExecuteReader

        If leer.Read() Then
            vidNombre = leer(1).ToString
            vidGenero = leer(2).ToString
            vidCompañia = leer(3).ToString
            vidPrecio = leer(4).ToString

            Nombre = vidNombre
            Genero = vidGenero
            Compañia = vidCompañia
            Precio = vidPrecio

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
