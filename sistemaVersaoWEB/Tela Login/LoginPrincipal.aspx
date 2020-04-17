<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginPrincipal.aspx.cs" Inherits="sistemaVersaoWEB.Tela_Login.LoginPrincipal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="Content/bootstrap.css" rel="stylesheet" />

    <style type="text/css">
        #DivConteudo {
            /*margin:20px;*/
            padding: 20px;
            background: #808080;
        }

        #Label1, #Label2 {
            width: 25%;
        }

        #txtNome, #txtsenha {
            width: 70%;
            margin-left: 6px;
            height: 35px;
            border-radius: 5px;
        }

        #btnLogar {
            width: 40%;
        }


        input[type=text], input[type=password] {
            width: 100%;
            padding: 12px 20px;
            margin: 8px 0;
            display: inline-block;
            border: 1px solid #ccc;
            box-sizing: border-box;
        }

        #Button1 {
            background-color: #4CAF50;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            border: none;
            cursor: pointer;
            width: 100%;
        }

        button:hover {
            opacity: 0.8;
        }

        .cancelbtn {
            width: auto;
            padding: 10px 18px;
            background-color: #f44336;
        }

        .imgcontainer {
            text-align: center;
            margin: 24px 0 12px 0;
        }

        img.avatar {
            width: 40%;
            border-radius: 50%;
        }

        .container {
            padding: 16px;
        }

        span.psw {
            float: right;
            padding-top: 16px;
        }

        /* Change styles for span and cancel button on extra small screens */
        @media screen and (max-width: 300px) {
            span.psw {
                display: block;
                float: none;
            }

            .cancelbtn {
                width: 100%;
            }
        }

        .divMaior {
            background-image: url("Imagens/Pegasus.jpg");
        }

        .auto-style1 {
            font-size: 16px;
            font-weight: bold;
        }

        .auto-style2 {
            font-size: 13px;
        }

        .auto-style3 {
            font-size: 15px;
        }

        $("#menu-toggle").click(function (e) {
            e.preventPainelPrincipal();
            $("#wrapper").toggleClass("toggled");
        });


        body {
            overflow-x: hidden;
        }

        #wrapper {
            padding-left: 0;
            -webkit-transition: all 0.5s ease;
            -moz-transition: all 0.5s ease;
            -o-transition: all 0.5s ease;
            transition: all 0.5s ease;
        }

            #wrapper.toggled {
                padding-left: 250px;
            }

        #sidebar-wrapper {
            z-index: 1000;
            position: fixed;
            left: 250px;
            width: 0;
            height: 100%;
            margin-left: -250px;
            overflow-y: auto;
            background: #000;
            -webkit-transition: all 0.5s ease;
            -moz-transition: all 0.5s ease;
            -o-transition: all 0.5s ease;
            transition: all 0.5s ease;
        }

        #wrapper.toggled #sidebar-wrapper {
            width: 250px;
        }

        #page-content-wrapper {
            width: 100%;
            position: absolute;
            padding: 15px;
        }

        #wrapper.toggled #page-content-wrapper {
            position: absolute;
            margin-right: -250px;
        }


        /* Sidebar Styles */

        .sidebar-nav {
            position: absolute;
            top: 0;
            width: 250px;
            margin: 0;
            padding: 0;
            list-style: none;
        }

            .sidebar-nav li {
                text-indent: 20px;
                line-height: 40px;
            }

                .sidebar-nav li a {
                    display: block;
                    text-decoration: none;
                    color: #999999;
                }

                    .sidebar-nav li a:hover {
                        text-decoration: none;
                        color: #fff;
                        background: rgba(255, 255, 255, 0.2);
                    }

                    .sidebar-nav li a:active, .sidebar-nav li a:focus {
                        text-decoration: none;
                    }

            .sidebar-nav > .sidebar-brand {
                height: 65px;
                font-size: 18px;
                line-height: 60px;
            }

                .sidebar-nav > .sidebar-brand a {
                    color: #999999;
                }

                    .sidebar-nav > .sidebar-brand a:hover {
                        color: #fff;
                        background: none;
                    }

        @media(min-width:768px) {
            #wrapper {
                padding-left: 0;
            }

                #wrapper.toggled {
                    padding-left: 250px;
                }

            #sidebar-wrapper {
                width: 0;
            }

            #wrapper.toggled #sidebar-wrapper {
                width: 250px;
            }

            #page-content-wrapper {
                padding: 20px;
                position: relative;
            }

            #wrapper.toggled #page-content-wrapper {
                position: relative;
                margin-right: 0;
            }
        }
    </style>
    <div id="page-content-wrapper">
        <div class="container-fluid" style="height: 639px; text-align: center;">
            <asp:Image ID="Image1" CssClass="img-circle" runat="server" Width="300px" Height="103px" img src="../Imagens/Pegasus.png" />
            <br />
            <p class="auto-style3"><strong>Para acessar a comanda eletrônica informe abaixo seus dados de acesso:</strong></p>
            <label for="uname"><span class="auto-style1">E-mail:</span></label>
            <asp:TextBox placeholder="Digite seu E-mail" ID="txtLogin" runat="server" CssClass="auto-style2"></asp:TextBox>

            <label for="psw"><span class="auto-style1">Senha:</span></label>
            <asp:TextBox placeholder="Digite sua senha" TextMode="Password" ID="psw" runat="server" CssClass="auto-style2"></asp:TextBox>

            <strong><em>
                <asp:Button ID="btnFinalizar" CssClass="btn btn-small btn-block btn-success BordaBranco" ToolTip="Clique aqui para Finalizar Pedido" runat="server" OnClientClick="Confirm()" Text="Logar"  Style="font-weight: bold; font-style: italic; font-size: 20px" />
                <
            </em></strong>
            <label runat="server" id="lblMensagem"></label>
            <br />
            <asp:Label Text="" ID="lblMensagemIP" ForeColor="white" Font-Bold="true" Style="margin: 10px; border-bottom: 1px solid #808080;" Font-Names="Comic Sans" runat="server" CssClass="auto-style3" />
        </div>
    </div>
</asp:Content>
