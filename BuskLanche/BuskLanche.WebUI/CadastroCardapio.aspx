<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroCardapio.aspx.cs" Inherits="BuskLanche.WebUI.CadastroCardapio" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-lg-12">
            <form id="Form2" runat="server" class="form-horizontal">
                <div class="form-group">
                    <div class="col-lg-12 text-center">
                        <h1 style="font-weight: bold; color: red; font-size: 50px">Cardápio</h1>
                        <hr />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-lg-4">
                        <asp:Label ID="lblNomeLanche" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Nome:</asp:Label>
                        <asp:TextBox ID="txtNomeLanche" runat="server" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                    </div>
                    <div class="col-lg-5">
                        <asp:Label ID="lblIngredientes" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Ingredientes:</asp:Label>
                        <asp:TextBox ID="txtIngredientes" runat="server" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                    </div>
                    <div class="col-lg-3">
                        <asp:Label ID="lblPreco" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Preço:</asp:Label>
                        <asp:TextBox ID="txtPreco" runat="server" CssClass="form-control" Style="font-size: x-large"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-lg-12 text-center">
                        <asp:Button ID="btnInserir" runat="server" Text="Inserir" class="btn btn-danger" Style="font-size: large; margin-top: 100px; margin-right: 100px" />
                        <asp:Button ID="btnAlterar" runat="server" Text="Alterar" class="btn btn-danger" Style="font-size: large; margin-top: 100px; margin-right: 100px" />
                        <asp:Button ID="btnExcluir" runat="server" Text="Excluir" class="btn btn-danger" Style="font-size: large; margin-top: 100px" />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-lg-12 text-right">
                        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" class="btn btn-danger" Style="font-size: large; margin-top: 100px" OnClick="btnSalvar_Click" />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-lg-12">
                        <asp:GridView ID="grdComercio" runat="server" AutoGenerateColumns="false" Width="100%" CssClass="Grid" AlternatingRowStyle-CssClass="alt" PagerStyle-CssClass="pgr">
                            <Columns>
                                <asp:TemplateField HeaderText="Nome">
                                    <HeaderStyle Width="30%" />
                                    <ItemStyle Width="30%" />
                                    <ItemTemplate>
                                        <asp:Label ID="lblNomeIngrediente" runat="server" Text='<%# Bind("Nome") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Ingrediente">
                                    <HeaderStyle Width="15%" />
                                    <ItemStyle Width="15%" />
                                    <ItemTemplate>
                                        <asp:Label ID="lblIngrediente" runat="server" Text='<%# Bind("Ingrediente") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Preço">
                                    <HeaderStyle Width="15%" />
                                    <ItemStyle Width="15%" />
                                    <ItemTemplate>
                                        <asp:Label ID="lblPreco" runat="server" Text='<%# Bind("Preco") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </form>
        </div>
    </div>

</asp:Content>
