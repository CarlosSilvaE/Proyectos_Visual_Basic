<%@ Page Title="Agregar Servicios" Language="VB" MasterPageFile="~/master.master" AutoEventWireup="true" CodeBehind="add_servicios.aspx.vb" Inherits="VibraMusicStoreWeb.add_servicios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="servicios-container">

        <!-- Logo -->
        <div class="logo">
            <img src='<%= ResolveUrl("~/Imagenes/Groovy.PNG") %>' alt="Logo Groovy" />
        </div>

        <!-- Contenedor principal -->
        <div class="main-panel">

            <!-- Formulario -->
            <div class="form-container">
                <h2>Registro de Servicios</h2>

                <asp:Label Text="ID:" AssociatedControlID="txtId" runat="server" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtId" runat="server" CssClass="textBoxInput"></asp:TextBox>

                <asp:Label Text="Cliente:" AssociatedControlID="txtCliente" runat="server" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtCliente" runat="server" CssClass="textBoxInput"></asp:TextBox>

                <asp:Label Text="Tipo de servicio:" AssociatedControlID="ddlTipoServicio" runat="server" CssClass="label"></asp:Label>
                <asp:DropDownList ID="ddlTipoServicio" runat="server" CssClass="textBoxInput">
                    <asp:ListItem Text="Mantenimiento" Value="Mantenimiento" />
                    <asp:ListItem Text="Reparación" Value="Reparación" />
                    <asp:ListItem Text="Personalizado" Value="Personalizado" />
                </asp:DropDownList>

                <asp:Label Text="Detalles:" AssociatedControlID="txtDetalles" runat="server" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtDetalles" runat="server" CssClass="textBoxInput"></asp:TextBox>

                <asp:Label Text="Instrumento:" AssociatedControlID="ddlInstrumento" runat="server" CssClass="label"></asp:Label>
                <asp:DropDownList ID="ddlInstrumento" runat="server" CssClass="textBoxInput">
                    <asp:ListItem Text="Guitarra" Value="Guitarra" />
                    <asp:ListItem Text="Acordeón" Value="Acordeón" />
                    <asp:ListItem Text="Bajo" Value="Bajo" />
                </asp:DropDownList>

                <asp:Label Text="Precio:" AssociatedControlID="txtPrecio" runat="server" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtPrecio" runat="server" CssClass="textBoxInput"></asp:TextBox>

                <asp:Label Text="Imagen:" AssociatedControlID="fuImagen" runat="server" CssClass="label"></asp:Label>
                <asp:FileUpload ID="fuImagen" runat="server" CssClass="textBoxInput" />

                <asp:Image ID="imgPreview" runat="server" Width="200px" Height="200px" CssClass="preview" />
            </div>

            <!-- Botones -->
            <div class="botones-container">
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-agregar" />
                <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" CssClass="btn btn-limpiar" />
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-buscar" />
                <asp:Button ID="btnRegresar" runat="server" Text="Regresar" CssClass="btn btn-regresar" />
            </div>

            <!-- GridView -->
            <div class="grid-container">
                <asp:GridView ID="gvServicios" runat="server" AutoGenerateColumns="False" CssClass="gridView"
                              OnSelectedIndexChanged="gvServicios_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" HeaderText="Seleccionar" />
                        <asp:BoundField DataField="IdServicio" HeaderText="ID" />
                        <asp:BoundField DataField="Cliente" HeaderText="Cliente" />
                        <asp:BoundField DataField="TipoServicio" HeaderText="Tipo de servicio" />
                        <asp:BoundField DataField="Detalles" HeaderText="Detalles" />
                        <asp:BoundField DataField="Instrumento" HeaderText="Instrumento" />
                        <asp:BoundField DataField="Total" HeaderText="Precio" DataFormatString="{0:C}" />
                    </Columns>
                </asp:GridView>
            </div>

        </div>
    </div>

    <!-- 🎨 Estilos -->
    <style>
        body, html {
            margin: 0;
            padding: 0;
            font-family: Arial, sans-serif;
            background-color: #000;
            color: #fff;
        }

        .servicios-container {
            width: 90%;
            margin: 0 auto;
            padding: 20px;
        }

        .logo {
            text-align: center;
            margin-bottom: 20px;
        }

        .logo img {
            max-width: 200px;
        }

        .main-panel {
            display: flex;
            flex-direction: column;
            gap: 20px;
        }

        .form-container {
            background-color: #111;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0px 0px 10px #444;
        }

        .form-container h2 {
            text-align: center;
            margin-bottom: 15px;
            color: #ffcc00;
        }

        .label {
            font-weight: bold;
            margin-top: 10px;
            display: block;
        }

        .textBoxInput, .textBoxInput:focus, select {
            width: 100%;
            padding: 8px;
            margin-bottom: 10px;
            border-radius: 5px;
            border: 1px solid #555;
            background-color: #222;
            color: #fff;
        }

        .preview {
            margin-top: 10px;
            border: 2px solid #555;
            border-radius: 5px;
        }

        .botones-container {
            display: flex;
            justify-content: space-around;
            gap: 10px;
        }

        .btn {
            flex: 1;
            padding: 12px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            font-weight: bold;
            transition: 0.3s;
        }

        .btn-agregar { background-color: #28a745; color: #fff; }
        .btn-limpiar { background-color: #ffc107; color: #000; }
        .btn-buscar { background-color: #17a2b8; color: #fff; }
        .btn-regresar { background-color: #6c757d; color: #fff; }

        .btn:hover {
            opacity: 0.8;
            transform: scale(1.05);
        }

        .grid-container {
            margin-top: 20px;
        }

        .gridView {
            width: 100%;
            border-collapse: collapse;
            background-color: #111;
        }

        .gridView th {
            background-color: #333;
            color: #fff;
            padding: 10px;
        }

        .gridView td {
            border: 1px solid #555;
            padding: 8px;
            color: #fff;
        }

        .gridView tr:nth-child(even) {
            background-color: #222;
        }
    </style>
</asp:Content>
