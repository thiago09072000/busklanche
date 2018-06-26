<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ResultadoAvaliacao.aspx.cs" Inherits="BuskLanche.WebUI.ResultadoAvaliacao" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <div class="col-md-3">
            <asp:Label ID="lblAvalSobre" runat="server" CssClass="control-label" Style="font-size: 30px; margin-left: 20px; color: red">Avaliação Sobre:</asp:Label>
        </div>
        <div class="col-md-6">
            <asp:Label ID="lblNomeComercio" runat="server" CssClass="control-label" Style="font-size: 30px; margin-top: 7px">Nome do Comércio</asp:Label>
        </div>
        <div class="col-lg-3 text-right">
            <asp:Button ID="btnVoltar" runat="server" CssClass="btn btn-danger" Style="font-size: large" Text="Voltar" OnClick="btnVoltar_Click" />
        </div>
    </div>
    <div class="form-group">
        <div class="col-lg-12">
            <label class="control-label" style="font-size: x-large; margin-top: 10px">Média de avaliações:</label>
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
        <div class="col-lg-12">
            <asp:DataList ID="gridView" CssClass="table text-center" runat="server" RepeatColumns="1" RepeatLayout="Table">
                <ItemTemplate>
                    <div class="form-group">
                        <div class="col-md-2">
                            <img class="img-circle" src="Images/avatar_2x.png" style="width: 100px;" />
                        </div>
                        <div class="col-md-10 text-left">
                            <div class="form-group">
                                <div class="col-md-12">
                                    <label><%# Eval("Consumidor.Nome") %></label>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-12">
                                    <label><%# Eval("DataHora") %></label>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-12">
                                    <span><%# Eval("Comentario") %></span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <hr />
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
</asp:Content>
