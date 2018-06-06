<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroAnunciante3.aspx.cs" Inherits="BuskLanche.WebUI.CadastroAnunciante3" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

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
                <div class="col-md-3">
                    <asp:Label ID="lblCadastro" runat="server" CssClass="control-label" Style="font-size: 40px; margin-left: 20px; color: red">Cadastro:</asp:Label>
                </div>
                <div class="col-md-9">
                    <asp:Label ID="lblUsuarioAnunciane" runat="server" CssClass="control-label" Style="font-size: 20px; margin-top: 20px; color: cornflowerblue">Usuário Anunciante </asp:Label>
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-12">
                    <asp:Label ID="lblRepresentanteComercio" runat="server" CssClass="control-label" Style="font-size: 30px; margin-left: 30px; color: black">Inserir: Representante do comércio</asp:Label>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-12">
                    <asp:Label ID="lblNomeCompleto" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Nome completo:</asp:Label>
                    <asp:TextBox ID="txtNomeCompleto" runat="server" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-8">
                    <asp:Label ID="lblEmail" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Email:</asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                </div>

                <div class="col-lg-4">
                    <asp:Label ID="lblSenha" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Senha:</asp:Label>
                    <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control"  TextMode="Password" Style="font-size: x-large"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-6">
                    <asp:Label ID="lblCelular" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Celular:</asp:Label>
                    <asp:TextBox ID="txtCelular" runat="server" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                </div>

                <div class="col-lg-6">
                    <asp:Label ID="lblCPF" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">CPF:</asp:Label>
                    <asp:TextBox ID="txtCPF" runat="server" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                </div>
            </div>



            <div class="form-group">
                <div class="col-lg-6">
                    <asp:Label ID="lblAlerta" runat="server" CssClass="control-label" Style="color: red; margin-top: 100px">*Todos os campos são obrigatórios</asp:Label>
                </div>
                <div class="col-lg-6 text-right">

                    <asp:Button ID="btnProximoCad3" runat="server" Text="Proxímo" class="btn btn-danger" Style="font-size: large; margin-top: 100px" OnClick="btnProximoCad3_Click" />
                </div>
            </div>
        </form>
    </div>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#MainContent_txtCPF").setMask("cpf");
        });
    </script>
        <script type="text/javascript">
        $(document).ready(function () {
            $("#MainContent_txtCelular").setMask("phone");
        });
    </script>

</asp:Content>
