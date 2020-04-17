<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Imprestimo.aspx.cs" Inherits="sistemaVersaoWEB.principal.Imprestimo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        #fieldset > table {
            height: auto !important;
        }

        @media only screen and (max-width: 600px) {
            #MainContent_dgvMesa {
                font-size: 0.5em !important;
            }
        }

        .auto-stylebtnAtualizar {
            text-align: right;
            font-size: 20px;
            font-style: oblique;
            text-align: center;
        }
    </style>
    <h1>Contas (Imprestimos|Juros)</h1>
    <div class="auto-stylebtnAtualizar">
        <asp:DropDownList ID="ListaClienteCombo" runat="server" AutoPostBack="True"></asp:DropDownList>
        <asp:Button ID="BtnLocalizar" runat="server" Height="33px" AutoPostBack="True" CssClass="btn btn-warning" Text="Localizar" OnClick="BtnLocalizar_Click" />
        <br />
    </div>
    <br />
    <div>
        <asp:Button ID="BtnAtualizar" CssClass="btn btn-success" runat="server" Text="Atualizar tela" Font-Bold="True" OnClick="BtnAtualizar_Click" />
    </div>
    <br />
    <%--grid para todos os clientes de alugueis--%>
    <div>
        <asp:GridView ID="dgvMesa" DataKeyNames="ID_CONTRATO" runat="server"
            OnPageIndexChanging="dgvMesa_PageIndexChanging" AutoGenerateColumns="False" OnRowDataBound="dgvMesa_RowDataBound" OnRowCommand="dgvMesa_RowCommand"
            Height="16px" Width="139px" Style="margin-right: 0px; margin-bottom: 27px; font-size: 1em;"
            BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" PageSize="1000">
            <Columns>
                <%--<asp:BoundField DataField="ID" HeaderText="Id1" Visible="True" />--%>
                <asp:BoundField DataField="ID_CONTRATO" HeaderText="Cód" />
                <asp:BoundField DataField="N_MENSALIDADE" HeaderText="nº" />
                <asp:BoundField DataField="NOME" HeaderText="Nome" />
                <asp:BoundField DataField="PLANO" HeaderText="Plano" />
                <asp:BoundField DataField="DATA_VENCIMENTO" HeaderText="Venci." DataFormatString="{0: dd/MM/yyyy}"/>
                <asp:BoundField DataField="VALOR_PRESTACAO" HeaderText="Valor" />
                <asp:BoundField DataField="VALOR_JUROS" HeaderText="Juros" />
                <asp:BoundField DataField="VALORFRACIONADO" HeaderText="Fracionado" />
                <asp:BoundField DataField="SITUACAO" HeaderText="Status" />

                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:Button ID="btnReceber" CssClass="btn btn-mini btn-info" runat="server" Style="width: 100%;" CausesValidation="false" CommandName="SelecionaLinha"
                            Text="Pagar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" ShowSelectButton="True" />

                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
    </div>
</asp:Content>
