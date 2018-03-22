<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cardapio.aspx.cs" Inherits="BuskLanche.WebUI.Cardapio" %>

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
                <div class="form-group">
                    <div class="col-lg-12 text-center">
                        <button type="button" class="btn btn-danger" style="font-size: large; margin-top: 100px; margin-right: 100px">Inserir</button>
                        <button type="button" class="btn btn-danger" style="font-size: large; margin-top: 100px; margin-right: 100px">Alterar</button>
                        <button type="button" class="btn btn-danger" style="font-size: large; margin-top: 100px">Excluir</button>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-lg-12 text-right">
                        <button type="button" class="btn btn-danger" style="font-size: large; margin-top: 100px">Salvar</button>
                    </div>
                </div>


            </form>
        </div>
    </div>


</asp:Content>
