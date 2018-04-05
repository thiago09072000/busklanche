<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BuskLanche.WebUI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-lg-12 text-center">
            <h1 style="font-weight: bold; color: red; font-size: 50px">Busk</h1>
        </div>
    </div>
    <div class="col-lg-12">
        <form id="Form2" runat="server" class="form-horizontal">
            <div class="form-group">
                <div class="col-lg-12">
                    <asp:Label ID="lblInfCEP" runat="server" CssClass="control-label" style="font-size: x-large; margin-top: 50px">Informe seu CEP atual</asp:Label>
                    <asp:TextBox ID="txtInfCEP" runat="server" CssClass="form-control" style="font-size: x-large" ></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-12">
                    <asp:Label ID="lblListarPor" runat="server" CssClass="control-label" style="font-size: x-large; margin-top: 50px">Listar por:</asp:Label>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-4">
                    <asp:CheckBox ID="txtMaisProx" runat="server" style="font-size: x-large" />
                    <asp:Label ID="lblMaisProx" runat="server" CssClass="control-label" style="font-size: large">Mais Proxímos</asp:Label>
                </div>
                <div class="col-lg-4">
                    <asp:CheckBox ID="txtMenorPreco" runat="server" style="font-size: x-large" />
                    <asp:Label ID="lblMenorPreco" runat="server" CssClass="control-label" style="font-size: large">Menor Preço</asp:Label>
                </div>
                <div class="col-lg-4">
                    <asp:CheckBox ID="txtMelhorAva" runat="server" style="font-size: x-large" />
                    <asp:Label ID="lblMelhorAva" runat="server" CssClass="control-label" style="font-size: large">Melhores Avaliações</asp:Label>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-12 text-right">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-danger" style="font-size: large; margin-top: 100px" OnClick="btnBuscar_Click" />
                </div>
            </div>
        </form>
    </div>

</asp:Content>
