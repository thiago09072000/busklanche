<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sobre.aspx.cs" Inherits="BuskLanche.WebUI.Sobre" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <div class="col-lg-12 text-center">
            <h1 style="font-weight: bold; color: red; font-size: 50px;">O que é o BuskLanche ?</h1>
            <p style="font-weight: bold; font-size: 40px; margin-top: 30px;">
                O Busk Lanche é um sistema focado em comércios ambulantes, que pretender ajudar os seus usúarios anunciantes a fazer a 
                divulgação de seus comércios de maneira mais efetiva e principalmente ajudar os usuários consumidores a comer um bom lanche!
            </p>
        </div>
    </div>
    <div class="form-group">
        <div class="col-md-12 text-right">
            <asp:Button ID="btnVoltar" runat="server" Text="Voltar" class="btn btn-danger" Style="font-size: large; margin-top: 50px" OnClick="btnVoltar_Click" />
        </div>
    </div>
</asp:Content>
