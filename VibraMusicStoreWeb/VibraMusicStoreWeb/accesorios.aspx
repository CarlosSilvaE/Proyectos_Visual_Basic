<%@ Page Title="Accesorios" Language="VB" MasterPageFile="~/master.master" AutoEventWireup="true" CodeBehind="accesorios.aspx.vb" Inherits="VibraMusicStoreWeb.accesorios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="instrumentos-container">

        <!-- Panel derecho con logo y botones -->
        <div class="side-panel">
            <div class="logo">
                <img src='<%= ResolveUrl("~/Imagenes/Groovy.png") %>' alt="Vibra Logo" />
            </div>

            <div class="botones-verticales">
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btnAgregar" />
                <asp:Button ID="btnComprar" runat="server" Text="Comprar" CssClass="btnComprar" />
                <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" CssClass="btnLimpiar" />
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btnBuscar" />
                <asp:Button ID="btnRegresar" runat="server" Text="Regresar" CssClass="btnRegresar" />
            </div>
        </div>

        <!-- Panel izquierdo con formulario y GridView -->
        <div class="main-panel">
            <!-- Formulario -->
            <div class="form-container">
                <asp:Label Text="Tipo de accesorio:" AssociatedControlID="ddlTipo" runat="server"></asp:Label>
                <asp:DropDownList ID="ddlTipo" runat="server" CssClass="textBoxInput">
                    <asp:ListItem Text="Tali" Value="Tali" />
                    <asp:ListItem Text="Cuerdas" Value="Cuerdas" />
                    <asp:ListItem Text="Baquetas" Value="Baquetas" />
                    <asp:ListItem Text="Estuches" Value="Estuches" />
                    <asp:ListItem Text="Afinadores" Value="Afinadores" />
                    <asp:ListItem Text="Atriles" Value="Atriles" />
                </asp:DropDownList>

                <asp:Label Text="Precio:" AssociatedControlID="txtPrecio" runat="server"></asp:Label>
                <asp:TextBox ID="txtPrecio" runat="server" CssClass="textBoxInput"></asp:TextBox>

                <asp:Label Text="Marca:" AssociatedControlID="txtMarca" runat="server"></asp:Label>
                <asp:TextBox ID="txtMarca" runat="server" CssClass="textBoxInput"></asp:TextBox>
            </div>

            <!-- Label para mensajes -->
            <asp:Label ID="lblMensaje" runat="server" CssClass="mensajeLabel" />

            <!-- GridView -->
            <div class="grid-container">
                <asp:GridView ID="gvAccesorios" runat="server" AutoGenerateColumns="False" 
              CssClass="gridView" OnSelectedIndexChanged="gvAccesorios_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" HeaderText="Seleccionar" />
                    <asp:BoundField DataField="IdAccesorio" HeaderText="ID" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                    <asp:BoundField DataField="Marca" HeaderText="Marca" />
                    <asp:BoundField DataField="Precio" HeaderText="Precio" DataFormatString="{0:C}" />
                </Columns>
            </asp:GridView>

            </div>
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

        .instrumentos-container {
            display: flex;
            gap: 20px;
            padding: 20px;
        }

        /* Panel derecho */
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

        .botones-verticales .btnAgregar { background-color: yellow; color: black; }
        .botones-verticales .btnComprar { background-color: peachpuff; color: black; }
        .botones-verticales .btnLimpiar { background-color: springgreen; color: black; }
        .botones-verticales .btnBuscar { background-color: deepskyblue; color: black; }
        .botones-verticales .btnRegresar { background-color: gray; color: black; }

        .botones-verticales button {
            padding: 10px;
            border: none;
            cursor: pointer;
            border-radius: 5px;
        }

        /* Panel izquierdo */
        .main-panel {
            flex: 1;
            display: flex;
            flex-direction: column;
            gap: 20px;
        }

        .form-container {
            display: flex;
            gap: 10px;
            align-items: center;
        }

        .textBoxInput, select {
            padding: 5px;
            border-radius: 5px;
            border: 1px solid #555;
            background-color: #222;
            color: white;
        }

        .mensajeLabel {
            display: block;
            margin: 10px 0;
            font-weight: bold;
            color: yellow;
        }

        .grid-container {
            flex: 1;
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

        @media (max-width: 768px) {
            .instrumentos-container {
                flex-direction: column;
                align-items: center;
            }
        }
    </style>
</asp:Content>
