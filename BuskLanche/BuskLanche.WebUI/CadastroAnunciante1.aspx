<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroAnunciante1.aspx.cs" Inherits="BuskLanche.WebUI.CadastroAnunciante1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <form id="Form2" runat="server" class="form-horizontal">
            <div class="form-group">
                <div class="col-md-3">
                    <asp:Label ID="lblCadastro" runat="server" CssClass="control-label" Style="font-size: 40px; margin-left: 20px; color: red">Cadastro:</asp:Label>
                </div>
                <div class="col-md-9">
                    <asp:Label ID="lblUsuarioAnunciante" runat="server" CssClass="control-label" Style="font-size: 20px; margin-top: 20px; color: cornflowerblue">Usuário Anúnciante</asp:Label>
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-12">
                    <asp:Label ID="lblDadosComercio" runat="server" CssClass="control-label" Style="font-size: 30px; margin-left: 30px; color: black">Inserir: Dados do comércio</asp:Label>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-12">
                    <asp:Label ID="lblNomeRestaurante" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Nome do Restaurante:</asp:Label>
                    <asp:TextBox ID="txtNomeRestaurante" runat="server" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-12">
                    <asp:Label ID="lblCNPJ" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">CNPJ:</asp:Label>
                    <asp:TextBox ID="txtCNPJ" runat="server" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-6">
                    <asp:Label ID="lblCamposObrigatorios" runat="server" CssClass="control-label" Style="color: red; margin-top: 100px">*Todos os campos são obrigatórios</asp:Label>
                </div>
                <div class="col-lg-6 text-right">
                    <asp:Button ID="btnProximoCad" runat="server" Text="Proxímo" class="btn btn-danger" Style="font-size: large; margin-top: 100px" OnClick="btnProximoCad_Click" />
                </div>
            </div>
        </form>
    </div>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#MainContent_txtCNPJ").setMask("cnpj");
        });
    </script>
</asp:Content>
