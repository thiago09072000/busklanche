<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ResultadoAvaliacao.aspx.cs" Inherits="BuskLanche.WebUI.ResultadoAvaliacao" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-lg-12">
            <form id="Form2" runat="server" class="form-horizontal">
                <div class="form-group">
                    <div class="col-md-3">
                        <label class="control-label" style="font-size: 30px; margin-left: 20px; color: red">Avaliação Sobre:</label>
                        <hr />
                    </div>
                    <div class="col-md-9">
                        <label class="control-label" style="font-size: 20px; margin-top: 7px">Nome do Comércio</label>
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
                                        <asp:Label ID="lblNomeComercio" runat="server" Text='<%# Bind("Nome") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Comentário">
                                    <HeaderStyle Width="15%" />
                                    <ItemStyle Width="15%" />
                                    <ItemTemplate>
                                        <asp:Label ID="lblComentário" runat="server" Text='<%# Bind("Comentario") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Avaliação">
                                    <HeaderStyle Width="15%" />
                                    <ItemStyle Width="15%" />
                                    <ItemTemplate>
                                        <asp:Label ID="lblAvaliação" runat="server" Text='<%# Bind("Avaliacao") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>

                <div class="form-group">

                    <div class="col-lg-12">
                        <label class="control-label" style="font-size: x-large; margin-top: 50px">Média de avaliações:</label>
                        <table>
                            <tr>
                                <td>
                                    <img src="Images/estrela1.jpg" style="width: 75px; height: 75px;" />
                                </td>
                                <td>
                                    <img src="Images/estrela1.jpg" style="width: 75px; height: 75px;" />
                                </td>
                                <td>
                                    <img src="Images/estrela1.jpg" style="width: 75px; height: 75px;" />
                                </td>
                                <td>
                                    <img src="Images/estrela1.jpg" style="width: 75px; height: 75px;" />
                                </td>
                                <td>
                                    <img src="Images/estrela2.jpg" style="width: 75px; height: 75px;" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-lg-12 text-right">
                        <asp:Button ID="btnSelecionar" runat="server" CssClass="btn btn-danger" Style="font-size: large" Text="Voltar" />
                    </div>
                </div>
            </form>
        </div>
    </div>

</asp:Content>
