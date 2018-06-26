<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EscolhaCadastro.aspx.cs" Inherits="BuskLanche.WebUI.EscolhaCadastro" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <div class="col-lg-12 text-center">
            <h1 style="font-weight: bold; color: red">Escolha de Cadastro</h1>
        </div>
    </div>
    <div class="form-group">
        <div class="col-md-6 text-center">
            <asp:Button ID="btnConsumidor" runat="server" Text="Consumidor" class="btn btn-danger btn-lg btn-block" Style="font-size: large; margin-top: 50px" OnClick="btnConsumidor_Click1" />
        </div>
        <div class="col-md-6 text-center">
            <asp:Button ID="btnAnunciante" runat="server" Text="Anunciante" class="btn btn-danger btn-lg btn-block" Style="font-size: large; margin-top: 50px" OnClick="btnAnunciante_Click" />
        </div>
    </div>
    <div class="form-group">
        <div class="col-md-12 text-right">
            <asp:Button ID="btnVoltar" runat="server" Text="Voltar" class="btn btn-danger" Style="font-size: large; margin-top: 50px" OnClick="btnVoltar_Click" />
        </div>
    </div>
    <div class="form-group">
        <div class="col-md-12 text-left">
            <asp:Label ID="lblValido" runat="server" CssClass="control-label" Style="margin-top: 200px; color: red">* Somente válido para Curitiba e Região Metropolitana</asp:Label>
        </div>
    </div>
</asp:Content>
