<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ResultadoBusk.aspx.cs" Inherits="BuskLanche.WebUI.ResultadoBusk" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-lg-12">
            <form id="Form2" runat="server" class="form-horizontal">
                <div class="form-group">
                    <div class="col-lg-12 text-center">
                        <h1 style="font-weight: bold; color: red; font-size: 50px">Busk</h1>
                        <hr />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-lg-12">
                        <asp:GridView ID="grdMarca" runat="server" AutoGenerateColumns="false" Width="100%" CssClass="Grid" AlternatingRowStyle-CssClass="alt" PagerStyle-CssClass="pgr">
                            <Columns>
                                <asp:TemplateField HeaderText="Nome">
                                    <HeaderStyle Width="30%" />
                                    <ItemStyle Width="30%" />
                                    <ItemTemplate>
                                        <asp:Label ID="lblNomeMarca" runat="server" Text='<%# Bind("Nome") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Distância">
                                    <HeaderStyle Width="15%" />
                                    <ItemStyle Width="15%" />
                                    <ItemTemplate>
                                        <asp:Label ID="lblDistancia" runat="server" Text='<%# Bind("Distancia") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Preço">
                                    <HeaderStyle Width="15%" />
                                    <ItemStyle Width="15%" />
                                    <ItemTemplate>
                                        <asp:Label ID="lblPreco" runat="server" Text='<%# Bind("Preco") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Avaliações">
                                    <HeaderStyle Width="20%" />
                                    <ItemStyle Width="20%" />
                                    <ItemTemplate>
                                        <asp:Label ID="lblAvaliações" runat="server" Text='<%# Bind("Avaliações") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Disponibilidade">
                                    <HeaderStyle Width="20%" />
                                    <ItemStyle Width="20%" />
                                    <ItemTemplate>
                                        <asp:Label ID="lblDisponibilidade" runat="server" Text='<%# Bind("Disponibilidade") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-lg-12 text-right">
                        <asp:Button ID="btnVoltar" runat="server" CssClass="btn btn-danger" style="font-size: large" Text="Voltar"/>
                        <asp:Button ID="btnSelecionar" runat="server" CssClass="btn btn-danger" style="font-size: large" Text="Selecionar"/>
                    </div>
                </div>
            </form>
        </div>
    </div>

</asp:Content>