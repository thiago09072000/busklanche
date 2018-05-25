<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Avaliacao.aspx.cs" Inherits="BuskLanche.WebUI.Avaliacao" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-lg-12">
            <form runat="server" class="form-horizontal">
                <asp:HiddenField ID="lblNotaAvaliacao" runat="server" Value="0" />
                <div class="form-group">
                    <div class="col-md-3">
                        <asp:Label ID="lblAvaliacaoSobre" runat="server" CssClass="control-label" Style="font-size: 30px; margin-left: 20px; color: red">Avaliação Sobre:</asp:Label>
                    </div>
                    <div class="col-md-9">
                        <asp:Label ID="lblNomeComercio" runat="server" CssClass="control-label" Style="font-size: 30px; margin-top: 10px">Nome do Comércio</asp:Label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-lg-7">
                        <asp:Label ID="lblFazerComentario" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Fazer Comentário:</asp:Label>
                        <asp:TextBox ID="txtFazerComentario" runat="server" TextMode="Multiline" CssClass="form-control" Rows="5"></asp:TextBox>
                    </div>
                    <div class="col-lg-5">
                        <asp:Label ID="lblAvaliar" runat="server" CssClass="control-label" Style="font-size: x-large; margin-top: 50px">Avaliar:</asp:Label>
                        <table>
                            <tr>
                                <td>
                                    <asp:LinkButton ID="lnkEstrela1" runat="server" OnClick="lnkEstrela1_Click">
                                        <img id="imgEstrela1" runat="server" src="Images/estrela2.jpg" style="width: 75px; height: 75px;" />
                                    </asp:LinkButton>
                                </td>
                                <td>
                                    <asp:LinkButton ID="lnkEstrela2" runat="server" OnClick="lnkEstrela2_Click">
                                        <img id="imgEstrela2" runat="server" src="Images/estrela2.jpg" style="width: 75px; height: 75px;" />
                                    </asp:LinkButton>
                                </td>
                                <td>
                                    <img id="imgEstrela3" runat="server" src="Images/estrela2.jpg" style="width: 75px; height: 75px;" />
                                </td>
                                <td>
                                    <img id="imgEstrela4" runat="server" src="Images/estrela2.jpg" style="width: 75px; height: 75px;" />
                                </td>
                                <td>
                                    <img id="imgEstrela5" runat="server" src="Images/estrela2.jpg" style="width: 75px; height: 75px;" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-lg-12 text-right">
                        <asp:Button ID="btnEnviarAvaliacao" runat="server" CssClass="btn btn-danger" Style="font-size: large" Text="Enviar Avaliação" OnClick="btnEnviarAvaliacao_Click" />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-12">
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
            </form>
        </div>
    </div>

</asp:Content>
