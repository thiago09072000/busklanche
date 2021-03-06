﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GerenciamentoComercio.aspx.cs" Inherits="BuskLanche.WebUI.GerenciamentoComercio" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <div class="col-md-3">
            <asp:Label ID="lblComercio" runat="server" CssClass="control-label" Style="font-size: 40px; margin-left: 20px; color: red">Comercío:</asp:Label>
        </div>
        <div class="col-md-9">
            <asp:Label ID="lblNomeComercio" runat="server" CssClass="control-label" Style="font-size: 40px; margin-top: 20px"></asp:Label>
        </div>
    </div>
    <div class="form-group">
        <div class="col-md-4">
            <asp:Label ID="lblRepresentante" runat="server" CssClass="control-label" Style="font-size: 40px; margin-left: 20px; color: red">Representante:</asp:Label>
        </div>
        <div class="col-md-8">
            <asp:Label ID="lblNomeRepresentante" runat="server" CssClass="control-label" Style="font-size: 40px; margin-top: 20px"></asp:Label>
        </div>
    </div>
    <div class="form-group">
        <div class="col-lg-12 text-left">
            <asp:Button ID="btnDados" runat="server" Text="Dados" class="btn btn-danger" Style="font-size: large; margin-top: 100px; margin-right: 100px" OnClick="btnDados_Click" />
            <asp:Button ID="btnCardápio" runat="server" Text="Cardápio" class="btn btn-danger" Style="font-size: large; margin-top: 100px; margin-right: 100px" OnClick="btnCardápio_Click" />
            <asp:Button ID="btnAvaliações" runat="server" Text="Avaliações" class="btn btn-danger" Style="font-size: large; margin-top: 100px" OnClick="btnAvaliações_Click" />
        </div>
    </div>
</asp:Content>
