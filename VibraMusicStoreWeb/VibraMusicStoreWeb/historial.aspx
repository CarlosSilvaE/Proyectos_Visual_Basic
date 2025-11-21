<%@ Page Title="Ingresos de usuarios" Language="VB" MasterPageFile="~/master.master" AutoEventWireup="true" CodeBehind="historial.aspx.vb" Inherits="VibraMusicStoreWeb.historial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ingresos-container">

        <!-- Panel derecho con logo y botón -->
        <div class="side-panel">
            <div class="logo">
                <img src='<%= ResolveUrl("~/Imagenes/Groovy.png") %>' alt="Vibra Logo" />
            </div>

            <div class="botones-verticales">
                <asp:Button ID="btnRegresar" runat="server" Text="Regresar" CssClass="btnRegresar" />
            </div>
        </div>

        <!-- Panel izquierdo con registros -->
        <div class="main-panel">
            <div class="registros-container">
                <asp:Label ID="lblTitulo" runat="server" Text="A continuación se muestran los registros de ingreso:" CssClass="titulo-label" />
                
                <!-- Label para mensajes -->
                <asp:Label ID="lblMensaje" runat="server" CssClass="mensajeLabel" />

                <asp:GridView ID="gvIngresos" runat="server" AutoGenerateColumns="False" CssClass="gridView">
                    <Columns>
                        <asp:BoundField DataField="IdUsuario" HeaderText="ID Usuario" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="Correo" HeaderText="Correo" />
                        <asp:BoundField DataField="FechaIngreso" HeaderText="Fecha de ingreso" DataFormatString="{0:dd/MM/yyyy HH:mm}" />
                        <asp:BoundField DataField="Nivel" HeaderText="Nivel de usuario" />
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

        .ingresos-container {
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

        .botones-verticales .btnRegresar {
            background-color: gray;
            color: black;
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

        .registros-container {
            background-color: #222;
            padding: 20px;
            border-radius: 10px;
            border: 1px solid #555;
        }

        .titulo-label {
            font-size: 18px;
            margin-bottom: 10px;
            display: block;
        }

        .mensajeLabel {
            display: block;
            margin-bottom: 10px;
            font-weight: bold;
            color: yellow;
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
            .ingresos-container {
                flex-direction: column;
                align-items: center;
            }
        }
    </style>
</asp:Content>
