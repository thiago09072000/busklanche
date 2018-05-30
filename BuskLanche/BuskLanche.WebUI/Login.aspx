﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BuskLanche.WebUI.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-12 text-center">
            <h1 style="font-weight: bold; color: red; font-size: 50px">Login</h1>
        </div>
    </div>
    <div class="row">
        <form id="Form2" runat="server" class="form-horizontal">
            <asp:Panel ID="pnlMSG" runat="server" Visible="false">
                <div class="form-group">
                    <div class="col-md-12">
                        <div class="alert alert-danger" role="alert">
                            <strong>Alerta!</strong>
                            <asp:Label ID="lblMSG" runat="server" />
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <div class="form-group">
                <div class="col-lg-12">
                    <asp:Label ID="lblEmail" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Email:</asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-12">
                    <asp:Label ID="lblSenha" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Senha:</asp:Label>
                    <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control" TextMode="Password" Style="font-size: x-large"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-4">
                    <asp:Label ID="lblUsuario" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Usuário: </asp:Label>
                </div>
                <div class="col-lg-4">
                    <asp:RadioButton ID="rdoAnunciante" GroupName="usuario" Text="Anunciante" runat="server" Checked="true" />
                </div>
                <div class="col-lg-4">
                    <asp:RadioButton ID="rdoUsuario" GroupName="usuario" Text="Consumidor" runat="server" />
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-12 text-right">
                    <asp:Button ID="btnCadastro" runat="server" CssClass="btn btn-danger" Style="font-size: large; margin-right: 100px" Text="Cadastrar" OnClick="btnCadastro_Click" />
                    <asp:Button ID="btnLogar" runat="server" CssClass="btn btn-danger" Style="font-size: large; margin-right: 100px" Text="Entrar" OnClick="btnLogar_Click" />
                </div>
            </div>
        </form>
    </div>
</asp:Content>
