<%@ Page Title="Agregar Instrumentos" Language="VB" MasterPageFile="~/master.master" AutoEventWireup="true" CodeBehind="add_instrumentos.aspx.vb" Inherits="VibraMusicStoreWeb.add_instrumentos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="instrumentos-container">

        <!-- Logo -->
        <div class="logo">
            <img src='<%= ResolveUrl("~/Imagenes/Groovy.PNG") %>' alt="Logo Groovy" />
        </div>

        <!-- Contenedor principal: GridView + Formulario -->
        <div class="main-panel">
            <!-- GridView de instrumentos -->
            <div class="grid-container">
                <asp:GridView ID="gvInstrumentos" runat="server" AutoGenerateColumns="False" CssClass="gridView" DataKeyNames="IdInstrumento" OnSelectedIndexChanged="gvInstrumentos_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="IdInstrumento" HeaderText="ID" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                        <asp:BoundField DataField="Marca" HeaderText="Marca" />
                        <asp:BoundField DataField="Precio" HeaderText="Precio" DataFormatString="{0:C}" />
                    </Columns>
                </asp:GridView>
            </div>

            <!-- Formulario para agregar/editar -->
            <div class="form-container">
                <asp:Label Text="ID:" AssociatedControlID="txtId" runat="server"></asp:Label>
                <asp:TextBox ID="txtId" runat="server" CssClass="textBoxInput"></asp:TextBox>

                <asp:Label Text="Nombre:" AssociatedControlID="txtNombre" runat="server"></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="textBoxInput"></asp:TextBox>

                <asp:Label Text="Tipo:" AssociatedControlID="ddlTipo" runat="server"></asp:Label>
                <asp:DropDownList ID="ddlTipo" runat="server" CssClass="textBoxInput">
                    <asp:ListItem Text="Guitarra" Value="Guitarra" />
                    <asp:ListItem Text="Acordeón" Value="Acordeón" />
                    <asp:ListItem Text="Bajo" Value="Bajo" />
                </asp:DropDownList>

                <asp:Label Text="Marca:" AssociatedControlID="txtMarca" runat="server"></asp:Label>
                <asp:TextBox ID="txtMarca" runat="server" CssClass="textBoxInput"></asp:TextBox>

                <asp:Label Text="Precio:" AssociatedControlID="txtPrecio" runat="server"></asp:Label>
                <asp:TextBox ID="txtPrecio" runat="server" CssClass="textBoxInput"></asp:TextBox>

                <!-- Botones en fila -->
                <div class="botones-container">
                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btnAccion" />
                    <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="btnAccion" />
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btnAccion" />
                    <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" CssClass="btnAccion" />
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btnAccion" />
                    <asp:Button ID="btnRegresar" runat="server" Text="Regresar" CssClass="btnAccion" />
                </div>
            </div>
            <asp:Label ID="lblMensaje" runat="server" CssClass="mensajeLabel" />
        </div>
    </div>

    <style>
        body, html {
            margin: 0;
            padding: 0;
            font-family: Arial, sans-serif;
            background-color: black;
            color: white;
        }

        .mensajeLabel {
            display: block;
            margin-top: 15px;
            font-weight: bold;
            color: yellow;
        }


        .instrumentos-container {
            width: 90%;
            margin: 0 auto;
            padding: 20px;
        }

        /* Logo */
        .logo {
            text-align: center;
            margin-bottom: 20px;
        }

        .logo img {
            max-width: 200px;
        }

        /* Contenedor principal: flex */
        .main-panel {
            display: flex;
            flex-wrap: wrap;      /* permite que se adapten en móviles */
            gap: 20px;
        }

        /* GridView */
        .grid-container {
            flex: 2;              /* ocupa más espacio que el formulario */
            min-width: 300px;
        }

        .gridView {
            width: 100%;
            border-collapse: collapse;
            background-color: #111;
        }

        .gridView th {
            background-color: #333;
            color: white;
            padding: 10px;
        }

        .gridView td {
            border: 1px solid #555;
            padding: 8px;
            color: white;
        }

        .gridView tr:nth-child(even) {
            background-color: #222;
        }

        /* Formulario */
        .form-container {
            flex: 1;
            min-width: 250px;
            background-color: #111;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0px 0px 10px #555;
        }

        .textBoxInput {
            width: 100%;
            padding: 8px;
            margin-bottom: 10px;
            border-radius: 5px;
            border: 1px solid #555;
            box-sizing: border-box;
            background-color: #222;
            color: white;
        }

        /* Botones flex */
        .botones-container {
            display: flex;
            flex-wrap: wrap;
            gap: 10px;
            margin-top: 15px;
        }

        .btnAccion {
            flex: 1;
            min-width: 120px;
            padding: 10px;
            background-color: #333;
            color: white;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }

        .btnAccion:hover {
            background-color: #555;
        }

        /* Responsive */
        @media (max-width: 768px) {
            .main-panel {
                flex-direction: column;
            }
        }
    </style>
</asp:Content>
