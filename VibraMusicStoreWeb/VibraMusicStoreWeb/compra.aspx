<%@ Page Title="Compra" Language="VB" MasterPageFile="~/master.master" AutoEventWireup="true" CodeBehind="Compra.aspx.vb" Inherits="VibraMusicStoreWeb.Compra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="compra-container">

        <!-- Panel derecho con logo y botones -->
        <div class="side-panel">
            <div class="logo">
                <img src='<%= ResolveUrl("~/Imagenes/Groovy.png") %>' alt="Vibra Logo" />
            </div>

            <div class="botones-verticales">
                <asp:Button ID="btnPagar" runat="server" Text="Pagar" CssClass="btnPagar" />
                <asp:Button ID="btnRegresar" runat="server" Text="Regresar" CssClass="btnRegresar" />
                <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" CssClass="btnLimpiar" />
            </div>
        </div>

        <!-- Panel izquierdo con área de compra -->
        <div class="main-panel">
            <div class="detalle-compra">
                <asp:Label ID="lblDetalle" runat="server" Text="Detalle de la compra:" CssClass="detalle-label" />
                <asp:Panel ID="pnlDetalle" runat="server" CssClass="detalle-panel">
                    <!-- Aquí puedes agregar controles dinámicos o contenido de la compra -->
                </asp:Panel>

                <!-- Label para mostrar el total -->
                <asp:Label ID="lblTotal" runat="server" Text="Total: $0.00" CssClass="detalle-label" />

                <!-- Label para mensajes -->
                <asp:Label ID="lblMensaje" runat="server" CssClass="mensajeLabel" />
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

        .compra-container {
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

        .botones-verticales .btnPagar { background-color: orange; color: black; }
        .botones-verticales .btnRegresar { background-color: gray; color: black; }
        .botones-verticales .btnLimpiar { background-color: red; color: white; }

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

        .detalle-compra {
            background-color: #222;
            padding: 20px;
            border-radius: 10px;
            border: 1px solid #555;
        }

        .detalle-label {
            font-size: 18px;
            margin-bottom: 10px;
            display: block;
        }

        .detalle-panel {
            min-height: 200px;
            background-color: #111;
            border: 1px solid #444;
            padding: 10px;
            color: white;
        }

        .mensajeLabel {
            display: block;
            margin-top: 10px;
            font-weight: bold;
            color: yellow;
        }

        @media (max-width: 768px) {
            .compra-container {
                flex-direction: column;
                align-items: center;
            }
        }
    </style>
</asp:Content>
