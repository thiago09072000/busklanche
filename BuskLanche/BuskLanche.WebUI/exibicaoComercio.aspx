<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="exibicaoComercio.aspx.cs" Inherits="BuskLanche.WebUI.exibicaoComercio" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-lg-12">
            <form id="Form2" runat="server" class="form-horizontal">
                <div class="form-group">
                    <div class="col-lg-12">
                        <h1 style="font-weight: bold; color: red; font-size: 35px">NomeDoComércio</h1>
                        <hr />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-lg-5">
                        <asp:Label ID="lblTelefone" runat="server" CssClass="control-label" style="font-size: 20px">Telefone: Telefone do Comercio</asp:Label>
                        <asp:Label ID="lblHorarios" runat="server" CssClass="control-label" style="font-size: 20px; margin-top: 5px">Horario de Funcionamento</asp:Label>
                    </div>
                    <div class="col-lg-7 text-center">
                        <table>
                            <tr>
                                <td>
                                    <img src="Images/estrela1.jpg" style="width: 75px; height: 75px;" />
                                </td>
                                <td>
                                    <img src="Images/estrela1.jpg"  style="width: 75px; height: 75px;" />
                                </td>
                                <td>
                                    <img src="Images/estrela1.jpg"  style="width: 75px; height: 75px;" />
                                </td>
                                <td>
                                    <img src="Images/estrela2.jpg"  style="width: 75px; height: 75px;" />
                                </td>
                                <td>
                                    <img src="Images/estrela2.jpg"  style="width: 75px; height: 75px;" />
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
                        <asp:Button ID="btnVoltar" runat="server" CssClass="btn btn-danger" Style="font-size: large; margin-right: 100px" Text="Avaliar e Comentar" OnClick="btnVoltar_Click" />
                        <asp:Button ID="btnSelecionar" runat="server" CssClass="btn btn-danger" Style="font-size: large" Text="Fechar" OnClick="btnSelecionar_Click" />
                    </div>
                </div>
            </form>
        </div>
    </div>

</asp:Content>
