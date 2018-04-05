<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DadosCadastrados.aspx.cs" Inherits="BuskLanche.WebUI.DadosCadastrados" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <form id="Form2" runat="server" class="form-horizontal">

            <div class="form-group">
                <div class="col-md-12">
                    <asp:Label ID="lblDCSC" runat="server" CssClass="control-label" Style="font-size: 40px; margin-left: 20px; color: red">Dados cadastrados sobre o comércio:</asp:Label>
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
                <div class="col-lg-12">
                    <asp:Label ID="lblBairro" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Bairro:</asp:Label>
                    <asp:TextBox ID="txtBairro" runat="server" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-12">
                    <asp:Label ID="lblRua" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Rua:</asp:Label>
                    <asp:TextBox ID="txtRua" runat="server" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-4">
                    <asp:Label ID="lblNumero" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Número:</asp:Label>
                    <asp:TextBox ID="txtNumero" runat="server" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                </div>
                <div class="col-lg-8">
                    <asp:Label ID="lblCEP" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">CEP:</asp:Label>
                    <asp:TextBox ID="txtCEP" runat="server" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-12">
                    <asp:Label ID="lblComplemento" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Complemento:</asp:Label>
                    <asp:TextBox ID="txtComplemento" runat="server" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-12">
                    <asp:Label ID="lblEstiloLanche" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Estilo de lanches:</asp:Label>
                    <asp:TextBox ID="txtEstiloLanche" runat="server" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-4">
                    <asp:Label ID="lblHoarioFuncionamento" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Horários de funcionamento:</asp:Label>
                </div>
                <div class="col-lg-2">
                    <asp:Label ID="lblAberto" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 25px">Aberto das:</asp:Label>
                    <asp:TextBox ID="TextAberto" runat="server" TextMode="Time" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                </div>
                <div class="col-lg-2">
                    <asp:Label ID="lblEncarramento" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 25px">Encerramento:</asp:Label>
                    <asp:TextBox ID="txtEncarramento" runat="server" TextMode="Time" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-12">
                    <asp:Label ID="lblDescricao" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Descreva o seu comércio:</asp:Label>
                    <asp:TextBox ID="txtDescricao" runat="server" TextMode="Multiline" CssClass="form-control" Rows="5"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-12 text-right">
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" class="btn btn-danger" Style="font-size: large; margin-top: 100px" OnClick="btnSalvar_Click" />
                </div>
            </div>

        </form>
    </div>
</asp:Content>
