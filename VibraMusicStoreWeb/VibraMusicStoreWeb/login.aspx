<%@ Page Title="Login" Language="VB" MasterPageFile="~/master.master" AutoEventWireup="true" CodeBehind="Login.aspx.vb" Inherits="VibraMusicStoreWeb.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login-container">
        <div class="login-box">
            <h2>Iniciar Sesión</h2>
            <asp:Label ID="lblUsuario" runat="server" Text="Usuario:" AssociatedControlID="txtUsuario"></asp:Label><br />
            <asp:TextBox ID="txtUsuario" runat="server" CssClass="textBoxLogin"></asp:TextBox><br /><br />

            <asp:Label ID="lblContrasena" runat="server" Text="Contraseña:" AssociatedControlID="txtContrasena"></asp:Label><br />
            <asp:TextBox ID="txtContrasena" runat="server" TextMode="Password" CssClass="textBoxLogin"></asp:TextBox><br /><br />

            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="btnLogin" /><br /><br />
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" CssClass="btnLogin" /><br /><br />

            <asp:Label ID="lblMensaje" runat="server" ForeColor="Red" CssClass="mensajeLogin"></asp:Label>
        </div>
    </div>

    <style>
        /* Imagen de fondo cubriendo toda la pantalla */
        html, body {
            height: 100%;
            margin: 0;
            padding: 0;
            font-family: Arial, sans-serif;
        }

        body {
            background-image: url('<%= ResolveUrl("Imagenes/vms.jpg") %>');
            background-size: cover;
            background-position: center;
            background-repeat: no-repeat;
            display: flex;
            justify-content: center;
            align-items: center;
            overflow: hidden; /* evita scroll innecesario */
        }

        .login-container {
            width: 100%;
            height: 100%;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .login-box {
            width: 400px;
            padding: 30px;
            background-color: rgba(0,0,0,0.7);
            color: white;
            border-radius: 10px;
            box-shadow: 0px 0px 10px #555;
        }

        .textBoxLogin {
            width:100%;
            padding:8px;
            border-radius:5px;
            border:1px solid #ccc;
            box-sizing:border-box;
        }
        .btnLogin {
            width:100%;
            padding:10px;
            background-color:#333;
            color:white;
            border:none;
            border-radius:5px;
            cursor:pointer;
        }
        .btnLogin:hover {
            background-color:#555;
        }
        .mensajeLogin {
            display:block;
            text-align:center;
            margin-top:10px;
        }
    </style>
</asp:Content>
