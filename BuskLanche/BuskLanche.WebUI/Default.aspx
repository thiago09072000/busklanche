<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BuskLanche.WebUI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-lg-12 text-center">
            <h1 style="font-weight: bold; color: red; font-size: 50px">Busk</h1>
        </div>
    </div>
    <div class="col-lg-12">
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
                    <asp:Label ID="lblInfCEP" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Informe seu CEP atual</asp:Label>
                    <asp:TextBox ID="txtInfCEP" runat="server" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-12">
                    <asp:Label ID="lblListarPor" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Listar por:</asp:Label>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-4">
                    <asp:RadioButton ID="rdoMaisProx" GroupName="usuario" Text="" runat="server" Checked="true" />
                    <asp:Label ID="lblMaisProx" runat="server" CssClass="control-label" Style="font-size: large">Mais Proxímos</asp:Label>
                </div>
                <div class="col-lg-4">
                    <asp:RadioButton ID="rdoMenorDuracao" GroupName="usuario" Text="" runat="server" Checked="false" />
                    <asp:Label ID="lblMenorPreco" runat="server" CssClass="control-label" Style="font-size: large">Menor Duração </asp:Label>
                </div>
                <div class="col-lg-4">
                    <asp:RadioButton ID="rdoMelhorAva" GroupName="usuario" Text="" runat="server" Checked="false" />
                    <asp:Label ID="lblMelhorAva" runat="server" CssClass="control-label" Style="font-size: large">Melhores Avaliações</asp:Label>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-12 text-right">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-danger" Style="font-size: large; margin-top: 100px" OnClick="btnBuscar_Click" />
                </div>
            </div>
        </form>
    </div>

    <script type="text/javascript">
        $(document).ready(function () {
            $("#MainContent_txtInfCEP").setMask("cep");
        });
    </script>

</asp:Content>
