<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BuskLanche.WebUI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <div class="col-md-8 col-md-offset-2">
            <div class="form-group">
                <div class="col-md-12 text-center">
                    <h1 style="font-weight: bold; color: red; font-size: 50px;">BuskLanche</h1>
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
                <div class="col-md-12">
                    <asp:Label ID="lblInfCEP" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">INFORME SEU CEP:</asp:Label>
                    <div class="input-group">
                        <asp:TextBox ID="txtInfCEP" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                        <span class="input-group-btn">
                            <asp:LinkButton ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-danger btn-lg" OnClick="btnBuscar_Click">
                                <span class="glyphicon glyphicon-search" aria-hidden="true"/>
                            </asp:LinkButton>
                        </span>
                    </div>
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-12">
                    <asp:Label ID="lblListarPor" runat="server" CssClass="control-label" Style="font-size: large;">Listar por:</asp:Label>
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-4">
                    <asp:RadioButton ID="rdoMaisProx" GroupName="usuario" Text="" runat="server" Checked="true" />
                    <asp:Label ID="lblMaisProx" runat="server" CssClass="control-label" Style="font-size: large">Mais Próximos</asp:Label>
                </div>
                <div class="col-md-4">
                    <asp:RadioButton ID="rdoMenorDuracao" GroupName="usuario" Text="" runat="server" Checked="false" />
                    <asp:Label ID="lblMenorPreco" runat="server" CssClass="control-label" Style="font-size: large">Menor Duração</asp:Label>
                </div>
                <div class="col-md-4">
                    <asp:RadioButton ID="rdoMelhorAva" GroupName="usuario" Text="" runat="server" Checked="false" />
                    <asp:Label ID="lblMelhorAva" runat="server" CssClass="control-label" Style="font-size: large">Melhores Avaliações</asp:Label>
                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#MainContent_txtInfCEP").setMask("cep");
        });
    </script>
</asp:Content>
