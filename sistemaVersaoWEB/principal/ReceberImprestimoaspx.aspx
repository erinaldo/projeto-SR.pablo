<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReceberImprestimoaspx.aspx.cs" Inherits="sistemaVersaoWEB.principal.ReceberImprestimoaspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        function Confirm() {
            var confirm_value = document.createElement("INPUT");
            confirm_value.type = "hidden";
            confirm_value.name = "confirm_value";
            if (confirm("Para confimar pagamento!\n" +
                "Deseja acrescenta uma parcela para o proximo mes?...\n" +
                "(Se |SIM| irá adiconar mas um pagamento para o proximo mes com o valor de juros do valor imprestado)\n\n\n" +
                "(se |NAO| o sistema interde que nao queres mas gerenciar este contrato, automaticamento ira ser cancelado)" )) {
                confirm_value.value = "Yes";
            } else {
                confirm_value.value = "No";
            }
            document.forms[0].appendChild(confirm_value);
        }
    </script>
    <h1>Recebimento de (Ímprestimos | juros)</h1>
    <div>
        <asp:Label ID="LbNumeroParcela" runat="server" Text="Nº da parcela "></asp:Label>
        <br />
        <asp:Label ID="LbNomeCliente" runat="server" Text="Cliente"></asp:Label>
        <br />
        <asp:Label ID="LbSituacao" runat="server" Text="Situacao"></asp:Label>
        <br />
        <asp:Label ID="LbPlano" runat="server" Text="Plano"></asp:Label>
        <br />
        <asp:Label ID="LbValorAtual" runat="server" Text="R$"></asp:Label>
        <asp:Label ID="LbValorFrcionado" runat="server" Text="R$"></asp:Label>
        <asp:Label ID="LbValorJuros" runat="server" Text="R$"></asp:Label>
        <br />
        <asp:Label ID="LbDataVencimento" runat="server" Text="Vencimento: "></asp:Label>
        <br />
    </div>

    <div class="text-center">


        <asp:Label ID="Label1" runat="server" Text="Valor á receber "></asp:Label>
        <asp:TextBox ID="txtvalorPago" runat="server" class="form-control mr-sm-2" placeholder="Valor á receber"></asp:TextBox>

        <div class="text-center">
            <asp:Label ID="Label5" runat="server" Text="Situação "></asp:Label>
            <asp:DropDownList class="form-control mr-sm-2" ID="ListaSituacao" OnSelectedIndexChanged="ListaSituacao_SelectedIndexChanged" runat="server" AutoPostBack="True">
                <asp:ListItem>Selecione...</asp:ListItem>
                <asp:ListItem>PAGO</asp:ListItem>
                <%--     <asp:ListItem>NAO PAGO</asp:ListItem>
                <asp:ListItem>CANCELADO</asp:ListItem>
                <asp:ListItem>JUROS</asp:ListItem>--%>
                <asp:ListItem>FRACIONADO</asp:ListItem>
            </asp:DropDownList>

            <asp:Label ID="Label8" runat="server" Text="Forma Pagamento "></asp:Label>
            &nbsp;<asp:DropDownList class="form-control mr-sm-2" ID="ListaFormaPagamento" runat="server">
                <asp:ListItem>Selecione...</asp:ListItem>
                <asp:ListItem>CREDITO</asp:ListItem>
                <asp:ListItem>DEBITO</asp:ListItem>
                <asp:ListItem>VALE_COMPRA</asp:ListItem>
                <asp:ListItem>DINHEIRO</asp:ListItem>
                <asp:ListItem>Transferência bancária;</asp:ListItem>
                <asp:ListItem>Depósito em espécie;</asp:ListItem>
                <asp:ListItem>Depósito em envelope;</asp:ListItem>
                <asp:ListItem>Loja (Dinheiro);</asp:ListItem>
                <asp:ListItem>Loja (Cartão)</asp:ListItem>
                <asp:ListItem>BOLETO</asp:ListItem>
            </asp:DropDownList>
        </div>

        <asp:Label ID="Label10" runat="server" Text="Data Pagamento "></asp:Label>&nbsp;
        <input type="date" class="form-control mr-sm-2" placeholder="Data de pagamento" data-mask="dd/MM/yyyy" id="txtDataPagamento" runat="server" />

        <strong><em>
            <br />
            <asp:Button ID="BtnFinalizar" CssClass="btn btn btn-large btn-block btn btn-success " runat="server" OnClick="BtnFinalizar_Click"  Text="Receber Completo" Font-Bold="True" Style="font-size: 20px; font-style: italic" />
            <asp:Button ID="BtnFracionado" CssClass="btn btn-large btn-block btn btn-danger " runat="server" OnClick="BtnFracionado_Click"  Text="Receber Fracionado" Font-Bold="True" Style="font-size: 20px; font-style: italic" />
            <asp:Button ID="BtnJuros" CssClass="btn btn-large btn-block btn  btn-success " runat="server" OnClick="BtnJuros_Click" OnClientClick="Confirm()" Text="Receber Juros" Font-Bold="True" Style="font-size: 20px; font-style: italic" />
            <asp:Button ID="BtnVoltar" CssClass="btn btn-large btn-block btn btn-inverse  " OnClick="BtnVoltar_Click"  runat="server" Text="Voltar" Font-Bold="True" Style="font-size: 20px; font-style: italic" />
        </em>
        </strong>
    </div>
</asp:Content>
