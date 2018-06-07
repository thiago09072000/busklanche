<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroCardapio.aspx.cs" Inherits="BuskLanche.WebUI.CadastroCardapio" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-lg-12">
            <form runat="server" class="form-horizontal">

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



                <asp:HiddenField ID="hdfIdComercio" runat="server" Value="0" />
                <div class="form-group">
                    <div class="col-lg-12 text-center">
                        <h1 style="font-weight: bold; color: red; font-size: 50px">Cardápio</h1>
                        <hr />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-lg-12">
                        <asp:Label ID="lblNomeLanche" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Nome:</asp:Label>
                        <asp:TextBox ID="txtNomeLanche" runat="server" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-lg-12">
                        <asp:Label ID="lblIngredientes" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Ingredientes:</asp:Label>
                        <asp:TextBox ID="txtIngredientes" runat="server" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-lg-12">
                        <asp:Label ID="lblPreco" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Preço:</asp:Label>
                        <asp:TextBox ID="txtPreco" runat="server" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-lg-12 text-right">
                        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" class="btn btn-danger" Style="font-size: large; margin-top: 100px" OnClick="btnSalvar_Click" />
                        <asp:Button ID="btnVoltar" runat="server" Text="Voltar" class="btn btn-danger" Style="font-size: large; margin-top: 100px" OnClick="btnVoltar_Click" />
                    </div>
                </div>
            </form>
        </div>
    </div>

      <script type="text/javascript">
        $(document).ready(function () {
            $("#MainContent_txtPreco").setMask("decimal");
        });
    </script>

</asp:Content>
