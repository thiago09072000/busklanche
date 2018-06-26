<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="exibicaoComercio.aspx.cs" Inherits="BuskLanche.WebUI.exibicaoComercio" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <div class="col-lg-12">
            <asp:Label ID="lblNomeComercio" runat="server" CssClass="control-label" Style="font-weight: bold; color: red; font-size: 35px"></asp:Label>
            <hr />
        </div>
    </div>
    <div class="form-group">
        <div class="col-lg-5">
            <div class="for-group">
                <div class="col-lg-5">
                    <asp:Label ID="lblTel" runat="server" CssClass="control-label" Style="font-size: 20px">Telefone:</asp:Label>
                </div>
                <div class="col-lg-7">
                    <asp:Label ID="lblTelefone" runat="server" CssClass="control-label" Style="font-size: 20px"></asp:Label>
                </div>
            </div>
            <div class="for-group">
                <div class="col-lg-7">
                    <asp:Label ID="lblDispo" runat="server" CssClass="control-label" Style="font-size: 20px">Disponibilidade:</asp:Label>
                </div>
                <div class="col-lg-5">
                    <asp:Label ID="lblDisponibilidade" runat="server" CssClass="control-label" Style="font-size: 20px"></asp:Label>
                </div>
            </div>
        </div>
        <div class="col-lg-7 text-center">
            <table>
                <tr>
                    <td>
                        <asp:LinkButton ID="lnkEstrela1" runat="server">
                            <img id="imgEstrela1" runat="server" src="Images/estrela2.jpg" style="width: 75px; height: 75px;" />
                        </asp:LinkButton>
                    </td>
                    <td>
                        <asp:LinkButton ID="lnkEstrela2" runat="server">
                            <img id="imgEstrela2" runat="server" src="Images/estrela2.jpg" style="width: 75px; height: 75px;" />
                        </asp:LinkButton>
                    </td>
                    <td>
                        <asp:LinkButton ID="lnkEstrela3" runat="server">
                            <img id="imgEstrela3" runat="server" src="Images/estrela2.jpg" style="width: 75px; height: 75px;" />
                        </asp:LinkButton>
                    </td>
                    <td>
                        <asp:LinkButton ID="lnkEstrela4" runat="server">
                            <img id="imgEstrela4" runat="server" src="Images/estrela2.jpg" style="width: 75px; height: 75px;" />
                        </asp:LinkButton>
                    </td>
                    <td>
                        <asp:LinkButton ID="lnkEstrela5" runat="server">
                            <img id="imgEstrela5" runat="server" src="Images/estrela2.jpg" style="width: 75px; height: 75px;" />
                        </asp:LinkButton>
                    </td>
                </tr>
            </table>
        </div>
    </div>
    <div class="form-group">
        <div class="col-lg-5">
            <iframe height="450" frameborder="0" style="border: 0; width: 100%;" src="https://www.google.com/maps/embed/v1/place?q=place_id:ChIJu9SrHHLj3JQRpWGqaGH5P48&key=AIzaSyAqehYTz56_xwTse58k50EXxXZqCAtewsA"></iframe>
        </div>
        <div class="col-lg-7">
            <h2 style="color: red; text-align: center">Cardápio</h2>
            <asp:GridView ID="grdCardapio" runat="server" AutoGenerateColumns="false" Width="100%" CssClass="Grid" AlternatingRowStyle-CssClass="alt" PagerStyle-CssClass="pgr">
                <Columns>
                    <asp:TemplateField HeaderText="Nome">
                        <HeaderStyle Width="33%" />
                        <ItemStyle Width="33%" />
                        <ItemTemplate>
                            <asp:Label ID="lblNomeCardapio" runat="server" Text='<%# Bind("Nome") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Ingredientes">
                        <HeaderStyle Width="33%" />
                        <ItemStyle Width="33%" />
                        <ItemTemplate>
                            <asp:Label ID="lblIngredientes" runat="server" Text='<%# Bind("Ingrediente") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Preço">
                        <HeaderStyle Width="33%" />
                        <ItemStyle Width="33%" />
                        <ItemTemplate>
                            <asp:Label ID="lblPreco" runat="server" Text='<%# Bind("Preco") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
    <div class="form-group">
        <div class="col-lg-12 text-right">
            <asp:Button ID="btnAvaliar" runat="server" CssClass="btn btn-danger" Style="font-size: large; margin-right: 100px" Text="Avaliar e Comentar" OnClick="btnAvaliar_Click" />
            <asp:Button ID="btnFechar" runat="server" CssClass="btn btn-danger" Style="font-size: large" Text="Fechar" OnClick="btnFechar_Click" />
        </div>
    </div>
    <div class="form-group">
        <div class="col-lg-12">
            <asp:Label ID="lblDes" runat="server" CssClass="control-label" Style="font-size: 20px">Descrição do Comércio:</asp:Label>
            <asp:Label ID="lblDescricao" runat="server" CssClass="control-label" Style="font-size: 20px"></asp:Label>
        </div>
    </div>
</asp:Content>
