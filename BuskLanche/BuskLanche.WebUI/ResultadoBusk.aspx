<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ResultadoBusk.aspx.cs" Inherits="BuskLanche.WebUI.ResultadoBusk" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <div class="col-lg-12 text-center">
            <h1 style="font-weight: bold; color: red; font-size: 50px">Busk</h1>
            <hr />
        </div>
    </div>
    <div class="form-group">
        <div class="col-lg-12">
            <asp:GridView ID="grdComercio" runat="server" AutoGenerateColumns="false" Width="100%" 
                CssClass="Grid" AlternatingRowStyle-CssClass="alt" PagerStyle-CssClass="pgr">
                <Columns>
                    <asp:TemplateField HeaderText="Nome">
                        <HeaderStyle Width="25%" />
                        <ItemStyle Width="25%" />
                        <ItemTemplate>
                            <asp:Label ID="lblNomeComercio" runat="server" Text='<%# Bind("NomeComercio") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Distância">
                        <HeaderStyle Width="20%" />
                        <ItemStyle Width="20%" />
                        <ItemTemplate>
                            <asp:Label ID="lblDistancia" runat="server" Text='<%# Bind("Distancia") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Duração">
                        <HeaderStyle Width="20%" />
                        <ItemStyle Width="20%" />
                        <ItemTemplate>
                            <asp:Label ID="lblDuracao" runat="server" Text='<%# Bind("Duracao") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Disponibilidade">
                        <HeaderStyle Width="15%" />
                        <ItemStyle Width="15%" />
                        <ItemTemplate>
                            <asp:Label ID="lblDisponibilidade" runat="server" Text='<%# Bind("Disponibilidade") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Média de avaliações">
                        <HeaderStyle Width="10%" />
                        <ItemStyle Width="10%" />
                        <ItemTemplate>
                            <asp:Label ID="lblAvaliacao" runat="server" Text='<%# Bind("NotaMedia") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Visualizar" ShowHeader="False">
                        <HeaderStyle Width="10%" CssClass="text-center" />
                        <ItemStyle Width="10%" CssClass="text-center" />
                        <ItemTemplate>
                            <asp:LinkButton ID="btnVisualizar" runat="server" Width="16px" Height="16px" ToolTip="Visualizar" OnClick="btnVisualizar_Click" CommandArgument='<%# Eval("Id") %>'>
                                            <span class="glyphicon glyphicon-search" aria-hidden="true"></span>
                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
    <div class="form-group">
        <div class="col-lg-12 text-right">
            <asp:Button ID="btnVoltar" runat="server" CssClass="btn btn-danger" Style="font-size: large" Text="Voltar" OnClick="btnVoltar_Click" />
        </div>
    </div>
</asp:Content>
