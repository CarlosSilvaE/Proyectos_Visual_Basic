<%@ Page Title="Buscador de usuarios" Language="VB" MasterPageFile="~/master.master" AutoEventWireup="true" CodeBehind="buscar_clientes.aspx.vb" Inherits="VibraMusicStoreWeb.buscar_clientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="buscador-container">

        <!-- Panel derecho con logo y botones -->
        <div class="side-panel">
            <div class="logo">
                <img src='<%= ResolveUrl("~/Imagenes/Groovy.png") %>' alt="Vibra Logo" />
            </div>

            <div class="botones-verticales">
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btnBuscar" />
                <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" CssClass="btnLimpiar" />
                <asp:Button ID="btnRegresar" runat="server" Text="Regresar" CssClass="btnRegresar" />
            </div>
        </div>

        <!-- Panel izquierdo con formulario de búsqueda -->
        <div class="main-panel">
            <div class="form-container">
                <asp:Label Text="Id:" AssociatedControlID="txtId" runat="server" />
                <asp:TextBox ID="txtId" runat="server" CssClass="textBoxInput" />

                <asp:Label Text="Correo:" AssociatedControlID="txtCorreo" runat="server" />
                <asp:TextBox ID="txtCorreo" runat="server" CssClass="textBoxInput" />

                <asp:Label Text="Nombre:" AssociatedControlID="txtNombre" runat="server" />
                <asp:TextBox ID="txtNombre" runat="server" CssClass="textBoxInput" />

                <asp:Label Text="Contraseña:" AssociatedControlID="txtPassword" runat="server" />
                <asp:TextBox ID="txtPassword" runat="server" CssClass="textBoxInput" TextMode="Password" />

                <asp:Label Text="Nivel de usuario:" AssociatedControlID="ddlNivel" runat="server" />
                <asp:DropDownList ID="ddlNivel" runat="server" CssClass="textBoxInput">
                    <asp:ListItem Text="Administrador" Value="Administrador" />
                    <asp:ListItem Text="Empleado" Value="Empleado" />
                    <asp:ListItem Text="Cliente" Value="Cliente" />
                </asp:DropDownList>
            </div>

            <!-- GridView para mostrar resultados -->
            <asp:GridView ID="gvClientes" runat="server" AutoGenerateColumns="False" CssClass="gridView"
                AllowPaging="True" PageSize="10" DataKeyNames="IdUsuario">
                <Columns>
                    <asp:BoundField DataField="IdUsuario" HeaderText="ID" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Correo" HeaderText="Correo" />
                    <asp:BoundField DataField="Contrasena" HeaderText="Contraseña" />
                    <asp:BoundField DataField="TipoUsuario" HeaderText="Nivel" />
                    <asp:CommandField ShowSelectButton="True" SelectText="Seleccionar" />
                </Columns>
            </asp:GridView>
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

        .buscador-container {
            display: flex;
            gap: 20px;
            padding: 20px;
        }

        .side-panel {
            width: 200px;
            display: flex;
            flex-direction: column;
            align-items: center;
            gap: 20px;
        }

        .logo img {
            width: 100px;
        }

        .botones-verticales {
            display: flex;
            flex-direction: column;
            gap: 10px;
            width: 100%;
        }

        .botones-verticales .btnBuscar { background-color: deepskyblue; color: black; }
        .botones-verticales .btnLimpiar { background-color: springgreen; color: black; }
        .botones-verticales .btnRegresar { background-color: gray; color: black; }

        .botones-verticales button {
            padding: 10px;
            border: none;
            cursor: pointer;
            border-radius: 5px;
        }

        .main-panel {
            flex: 1;
            display: flex;
            flex-direction: column;
            gap: 20px;
        }

        .form-container {
            display: grid;
            grid-template-columns: auto 1fr;
            gap: 10px 20px;
            align-items: center;
            background-color: #222;
            padding: 20px;
            border-radius: 10px;
            border: 1px solid #555;
        }

        .gridView {
            margin-top: 20px;
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

        .textBoxInput, select {
            padding: 5px;
            border-radius: 5px;
            border: 1px solid #555;
            background-color: #111;
            color: white;
        }

        @media (max-width: 768px) {
            .buscador-container {
                flex-direction: column;
                align-items: center;
            }

            .form-container {
                grid-template-columns: 1fr;
            }
        }
    </style>
</asp:Content>
