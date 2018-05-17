<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListagemCardapio.aspx.cs" Inherits="BuskLanche.WebUI.ListagemCardapio" %>

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
                    <div class="col-lg-12 text-left">
                        <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" class="btn btn-danger" Style="font-size: large; margin-top: 25px" OnClick="btnCadastrar_Click" />
                        <asp:Button ID="btnVoltar" runat="server" Text="Voltar" class="btn btn-danger" Style="font-size: large; margin-top: 25px" OnClick="btnVoltar_Click" />
                    </div>
                    <div class="col-lg-12">
                        <asp:GridView ID="grdCardapio" runat="server" AutoGenerateColumns="false" Width="100%" CssClass="Grid" AlternatingRowStyle-CssClass="alt" PagerStyle-CssClass="pgr">
                            <Columns>
                                <asp:TemplateField HeaderText="Nome">
                                    <HeaderStyle Width="30%" />
                                    <ItemStyle Width="30%" />
                                    <ItemTemplate>
                                        <asp:Label ID="lblNomeIngrediente" runat="server" Text='<%# Bind("Nome") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Ingrediente">
                                    <HeaderStyle Width="40%" />
                                    <ItemStyle Width="40%" />
                                    <ItemTemplate>
                                        <asp:Label ID="lblIngrediente" runat="server" Text='<%# Bind("Ingrediente") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Preço">
                                    <HeaderStyle Width="20%" />
                                    <ItemStyle Width="20%" />
                                    <ItemTemplate>
                                        <asp:Label ID="lblPreco" runat="server" Text='<%# Bind("Preco") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="&nbsp;" ShowHeader="False">
                                    <HeaderStyle Width="10%" />
                                    <ItemStyle Width="10%" />
                                    <ItemTemplate>
                                        <asp:LinkButton ID="btnEditar" runat="server" Width="16px" Height="16px"
                                            ToolTip="Editar" OnClick="btnEditar_Click" CommandArgument='<%# Eval("Id") %>'>
                                            <span class="glyphicon glyphicon-pencil" aria-hidden="true"></span>
                                        </asp:LinkButton>
                                        <asp:LinkButton ID="btnExcluir" runat="server" Width="16px" Height="16px"
                                            ToolTip="Excluir" OnClick="btnExcluir_Click" CommandArgument='<%# Eval("Id") %>'
                                            OnClientClick='if (!confirm("Deseja realmente remover este registro?")) return false;'>
                                            <span class="glyphicon glyphicon-remove" aria-hidden="true"></span>
                                        </asp:LinkButton>
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