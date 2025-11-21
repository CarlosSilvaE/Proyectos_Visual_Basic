<%@ Page Title="Inicio Cliente" Language="VB" MasterPageFile="~/master.master" AutoEventWireup="true" CodeBehind="inicio_cliente.aspx.vb" Inherits="VibraMusicStoreWeb.inicio_cliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Botón cerrar sesión arriba a la derecha -->
    <div class="logout-button">
        <asp:Button ID="btnCerrar" runat="server" Text="Cerrar sesión" CssClass="btnCerrar" />
    </div>

    <div class="cliente-container">
        <!-- Menú superior -->
        <nav class="menuStrip">
            <ul>
                <li><asp:Button ID="btnInstrumentos" runat="server" Text="Instrumentos" CssClass="btnMenu" /></li>
                <li><asp:Button ID="btnAccesorios" runat="server" Text="Accesorios" CssClass="btnMenu" /></li>
            </ul>
        </nav>

        <!-- Logo de la empresa -->
        <div class="logo">
            <img src='<%= ResolveUrl("~/Imagenes/Groovy.PNG") %>' alt="Logo Groovy" />
        </div>

        <!-- Nombre del usuario -->
        <div class="usuario-info">
            <asp:Label ID="lblNombre" runat="server" CssClass="usuarioLabel" />
        </div>

        <!-- GridView de instrumentos más vendidos -->
        <div class="grid-container">
            <asp:GridView ID="gvInstrumentosVendidos" runat="server" AutoGenerateColumns="False" CssClass="gridView">
                <Columns>
                    <asp:BoundField DataField="Instrumento" HeaderText="Instrumento" />
                    <asp:BoundField DataField="Marca" HeaderText="Marca" />
                    <asp:BoundField DataField="TotalVendido" HeaderText="Ventas" />
                    <asp:BoundField DataField="TipoProducto" HeaderText="Tipo" />
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

        .cliente-container {
            width: 90%;
            margin: 0 auto;
            padding: 20px;
        }

        /* MenuStrip estilo horizontal */
        .menuStrip ul {
            list-style: none;
            margin: 0;
            padding: 0;
            background-color: #333;
            overflow: hidden;
        }

        .menuStrip ul li {
            float: left;
            margin-right: 5px;
        }

        .btnMenu {
            background-color: #333;
            color: white;
            border: none;
            padding: 12px 20px;
            cursor: pointer;
        }

        .btnMenu:hover {
            background-color: #555;
        }

        /* Logo */
        .logo {
            margin: 20px 0;
            text-align: center;
        }

        .logo img {
            max-width: 200px;
        }

        /* Botón cerrar sesión alineado arriba a la derecha */
        .logout-button {
            position: absolute;
            top: 10px;
            right: 20px;
        }

        .btnCerrar {
            padding: 8px 16px;
            background-color: #333;
            color: white;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }

        .btnCerrar:hover {
            background-color: #555;
        }

        /* Usuario */
        .usuarioLabel {
            font-size: 16px;
            font-weight: bold;
            display: block;
            text-align: center;
            margin-bottom: 10px;
        }

        /* GridView */
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
    </style>
</asp:Content>
