<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroAnunciante2.aspx.cs" Inherits="BuskLanche.WebUI.CadastroAnunciante2" %>

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
                    <asp:Label ID="lblEnderecoComercio" runat="server" CssClass="control-label" Style="font-size: 30px; margin-left: 30px; color: black">Inserir: Endereço do comércio</asp:Label>
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-12">
                    <asp:Label ID="lblBairro" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">*Bairro:</asp:Label>
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
                    <asp:Label ID="lblCEP" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">*CEP:</asp:Label>
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
                <div class="col-lg-6">
                    <asp:Label ID="lblcamposObrigatorios" runat="server" CssClass="control-label" Style="color: red; margin-top: 100px">*Todos os campos são obrigatórios</asp:Label>
                </div>
                <div class="col-lg-6 text-right">
                    <asp:Button ID="btnProximoCad" runat="server" Text="Proxímo" class="btn btn-danger" Style="font-size: large; margin-top: 100px" />
                </div>
            </div>
        </form>
    </div>

</asp:Content>
