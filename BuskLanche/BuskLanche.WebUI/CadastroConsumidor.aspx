<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroConsumidor.aspx.cs" Inherits="BuskLanche.WebUI.CadastroConsumidor" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <form id="Form2" runat="server" class="form-horizontal">
            <div class="form-group">
                <div class="col-md-3">
                    <asp:Label ID="lblCadastro" runat="server" CssClass="control-label" style="font-size: 40px; margin-left: 20px; color: red">Cadastro:</asp:Label>
                </div>
                <div class="col-md-9">
                    <asp:Label ID="lblUsuarioConsumidor" runat="server" CssClass="control-label" style="font-size: 20px; margin-top: 20px; color: cornflowerblue">Usuário Consumidor</asp:Label>
                </div>
            </div>
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
                    <asp:Label ID="lblNomeConsumidor" runat="server" CssClass="control-label" style="font-size: x-large; margin-top: 50px">Nome completo:</asp:Label>
                    <asp:TextBox ID="txtNomeConsumidor" runat="server" CssClass="form-control" style="font-size: x-large" ></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-12">
                    <asp:Label ID="lblEmail" runat="server" CssClass="control-label" style="font-size: x-large; margin-top: 50px">Email:</asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" style="font-size: x-large" ></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-4">
                    <asp:Label ID="lblSenha" runat="server" CssClass="control-label" style="font-size: x-large; margin-top: 50px">Senha:</asp:Label>
                    <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control" TextMode="Password" style="font-size: x-large" ></asp:TextBox>
                </div>
                <div class="col-lg-8">
                    <asp:Label ID="lblCPF" runat="server" CssClass="control-label" style="font-size: x-large; margin-top: 50px">CPF:</asp:Label>
                    <asp:TextBox ID="txtCPF" runat="server" CssClass="form-control" style="font-size: x-large"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-12">
                    <asp:Label ID="lblcamposObrigatorios" runat="server" CssClass="control-label" style="color: red; margin-top: 100px">*Todos os campos são obrigatórios</asp:Label>
                </div>
            </div>
            <div class="form-group">
                  <div class="col-lg-12 text-right">
                    <asp:Button ID="btnVoltar" runat="server" Text="Voltar" class="btn btn-danger" style="font-size: large; margin-top: 100px" OnClick="btnVoltar_Click" />
                    <asp:Button ID="btnFinalizar" runat="server" Text="Finalizar" class="btn btn-danger" style="font-size: large; margin-top: 100px" OnClick="btnFinalizar_Click" />
                </div>
            </div>
        </form>
    </div>
     <script type="text/javascript">
        $(document).ready(function () {
            $("#MainContent_txtCPF").setMask("cpf");
        });
    </script>

</asp:Content>
