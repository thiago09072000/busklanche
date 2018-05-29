<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroAnunciante4.aspx.cs" Inherits="BuskLanche.WebUI.CadastroAnunciante4" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <form id="Form2" runat="server" class="form-horizontal">
            <div class="form-group">
                <div class="col-md-3">
                    <asp:Label ID="lblCadastro" runat="server" CssClass="control-label" Style="font-size: 40px; margin-left: 20px; color: red">Cadastro:</asp:Label>
                </div>
                <div class="col-md-9">
                    <asp:Label ID="lblUsuarioAnunciante" runat="server" CssClass="control-label" Style="font-size: 20px; margin-top: 20px; color: cornflowerblue">Usuário Anunciante</asp:Label>
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-12">
                    <asp:Label ID="lblFuncionamentoComercio" runat="server" CssClass="control-label" Style="font-size: 30px; margin-left: 30px; color: black">Inserir: Funcionamento do comércio</asp:Label>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-12">
                    <asp:Label ID="lblEstiloLanches" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Estilo de lanches:</asp:Label>
                    <asp:TextBox ID="txtEstiloLanches" runat="server" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-4">
                    <asp:Label ID="lblHorariosFuncionamento" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Horários de funcionamento:</asp:Label>
                </div>

                <div class="col-lg-2">
                    <asp:Label ID="lblAberto" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 25px">Aberto das:</asp:Label>
                    <asp:TextBox ID="txtAberto" runat="server" TextMode="Time" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                </div>
                <div class="col-lg-2">
                    <asp:Label ID="lblEncerramento" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 25px">Encerramento:</asp:Label>
                    <asp:TextBox ID="txtEncerramento" runat="server" TextMode="Time" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-12">
                    <asp:Label ID="lblDescrevaComercio" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Descreva o seu comércio:</asp:Label>
                    <asp:TextBox ID="txtDescrevaComercio" runat="server" TextMode="MultiLine" CssClass="form-control" Rows="5"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-6">
                    <asp:Label ID="lblcamposObrigatorios" runat="server" CssClass="control-label" Style="color: red; margin-top: 100px">*Todos os campos são obrigatórios</asp:Label>
                </div>
                <div class="col-lg-6 text-right">
                    <asp:Button ID="btnFinalizar" runat="server" Text="Finalizar" class="btn btn-danger" Style="font-size: large; margin-top: 100px" OnClick="btnFinalizar_Click" />
                </div>
            </div>
        </form>
    </div>

</asp:Content>
