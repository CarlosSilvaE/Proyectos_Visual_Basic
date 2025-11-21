<%@ Page Title="Inicio Empleado" Language="VB" MasterPageFile="~/master.master" AutoEventWireup="true" CodeBehind="inicio_empleado.aspx.vb" Inherits="VibraMusicStoreWeb.inicio_empleado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="empleado-container">

        <nav class="menuStrip">
            <ul>
                <li><asp:LinkButton ID="lnkInstrumentos" runat="server" Text="Instrumentos" /></li>
                <li><asp:LinkButton ID="lnkAccesorios" runat="server" Text="Accesorios" /></li>
                <li><asp:LinkButton ID="lnkServicios" runat="server" Text="Servicios" /></li>
                <li><asp:LinkButton ID="lnkConsultas" runat="server" Text="Consultas" /></li>
                <li><asp:LinkButton ID="lnkHistorial" runat="server" Text="Historial de Acceso" /></li>
                <li><asp:LinkButton ID="lnkClientes" runat="server" Text="Clientes" /></li>
                <li><asp:LinkButton ID="lnkCerrar" runat="server" Text="Cerrar Sesión" /></li>
            </ul>
        </nav>


        <div class="logo">
            <img src='<%= ResolveUrl("~/Imagenes/Groovy.PNG") %>' alt="Logo Groovy" />
        </div>

        <div class="main-content">
            <h2>Bienvenido, Empleado</h2>
            <asp:Label ID="lblBienvenida" runat="server" CssClass="bienvenidaLabel" />
            <p>Desde aquí puedes administrar instrumentos, accesorios, servicios, consultar historial de accesos y gestionar clientes.</p>
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

        .empleado-container {
            width: 90%;
            margin: 0 auto;
            padding: 20px;
        }

        .menuStrip ul {
            list-style: none;
            margin: 0;
            padding: 0;
            background-color: #111;
            overflow: hidden;
        }

        .menuStrip ul li {
            float: left;
        }

        .menuStrip ul li a {
            display: block;
            color: white;
            text-align: center;
            padding: 12px 20px;
            text-decoration: none;
        }

        .menuStrip ul li a:hover {
            background-color: #333;
        }

        .menuStrip ul li:last-child {
            float: right;
            margin-left: auto;
        }

        .logo {
            margin: 20px 0;
            text-align: center;
        }

        .logo img {
            max-width: 200px;
        }

        .main-content {
            background-color: #111;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0px 0px 10px #555;
            margin-top: 20px;
        }

        .main-content h2 {
            margin-top: 0;
        }
    </style>
</asp:Content>
