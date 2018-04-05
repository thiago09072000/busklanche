<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EscolhaCadastro.aspx.cs" Inherits="BuskLanche.WebUI.EscolhaCadastro" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-lg-12 text-center">
            <h1 style="font-weight: bold; color: red">Escolha de Cadastro</h1>
        </div>
    </div>
    <div class="row">
        <form id="Form2" runat="server" class="form-horizontal">
            <div class="form-group">
                <div class="col-md-6 text-center">
                     <asp:Button ID="btnConsumidor" runat="server" Text="Consuimidor" class="btn btn-danger" style="font-size: large; margin-top: 100px" OnClick="btnConsumidor_Click" />
                </div>
                <div class="col-md-6 text-center">
                     <asp:Button ID="BtnAnunciante" runat="server" Text="Anúncinate" class="btn btn-danger" style="font-size: large; margin-top: 100px" OnClick="BtnAnunciante_Click" />
                </div>

                <div class="form-group">
                    <div class="col-md-12">
                   <asp:Label ID="lblValido" runat="server" CssClass="control-label" style="margin-top: 200px; color: red">* Somente válido para Curitiba e Região Metropolitana</asp:Label>
                    </div>
                </div>
            </div>
        </form>
    </div>

</asp:Content>
