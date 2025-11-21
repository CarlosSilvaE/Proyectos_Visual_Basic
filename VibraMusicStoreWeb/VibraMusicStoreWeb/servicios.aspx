<%@ Page Title="Mostrar servicios" Language="VB" MasterPageFile="~/master.master" AutoEventWireup="true" CodeBehind="servicios.aspx.vb" Inherits="VibraMusicStoreWeb.servicios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="servicios-container">

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

        <!-- Panel izquierdo con criterio y resultados -->
        <div class="main-panel">
            <div class="criterio-container">
                <asp:Label Text="Seleccionar criterio:" AssociatedControlID="ddlCriterio" runat="server" />
                <asp:DropDownList ID="ddlCriterio" runat="server" CssClass="textBoxInput">
                    <asp:ListItem Text="Servicios por Cliente" Value="Cliente" />
                    <asp:ListItem Text="Servicios por Instrumento" Value="Instrumento" />
                    <asp:ListItem Text="Servicios Vigentes" Value="Vigentes" />
                    <asp:ListItem Text="Servicios Finalizados" Value="Finalizados" />
                </asp:DropDownList>

                <!-- Campo para ID Cliente -->
                <asp:Label Text="ID Cliente:" AssociatedControlID="txtIdCliente" runat="server" />
                <asp:TextBox ID="txtIdCliente" runat="server" CssClass="textBoxInput" />

                <!-- Campo para Instrumento -->
                <asp:Label Text="Instrumento:" AssociatedControlID="ddlInstrumento" runat="server" />
                <asp:DropDownList ID="ddlInstrumento" runat="server" CssClass="textBoxInput">
                    <asp:ListItem Text="Guitarra" Value="Guitarra" />
                    <asp:ListItem Text="Acordeón" Value="Acordeón" />
                    <asp:ListItem Text="Bajo" Value="Bajo" />
                </asp:DropDownList>
            </div>

            <div class="resultados-container">
                <asp:Label ID="lblInfo" runat="server" Text="A continuación se muestran los servicios:" CssClass="titulo-label" />
                <asp:GridView ID="gvServicios" runat="server" AutoGenerateColumns="False" CssClass="gridView">
                    <Columns>
                        <asp:BoundField DataField="IdServicio" HeaderText="ID Servicio" />
                        <asp:BoundField DataField="Cliente" HeaderText="Cliente" />
                        <asp:BoundField DataField="Instrumento" HeaderText="Instrumento" />
                        <asp:BoundField DataField="Estado" HeaderText="Estado" />
                        <asp:BoundField DataField="Fecha" HeaderText="Fecha" DataFormatString="{0:dd/MM/yyyy}" />
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

        .servicios-container {
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

        .criterio-container {
            display: grid;
            grid-template-columns: auto 1fr;
            gap: 10px 20px;
            align-items: center;
            background-color: #222;
            padding: 15px;
            border-radius: 10px;
            border: 1px solid #555;
        }

        .resultados-container {
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

        .textBoxInput, select {
            padding: 5px;
            border-radius: 5px;
            border: 1px solid #555;
            background-color: #111;
            color: white;
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
            .servicios-container {
                flex-direction: column;
                align-items: center;
            }

            .criterio-container {
                grid-template-columns: 1fr;
            }
        }
    </style>
</asp:Content>
