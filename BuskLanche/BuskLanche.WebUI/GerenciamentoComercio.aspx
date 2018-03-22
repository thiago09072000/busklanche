<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GerenciamentoComercio.aspx.cs" Inherits="BuskLanche.WebUI.GerenciamentoComercio" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="form-horizontal">
            <div class="form-group">
                <div class="col-md-3">
                    <label class="control-label" style="font-size: 40px; margin-left: 20px; color: red">Comercío:</label>
                </div>
                <div class="col-md-9">
                    <label class="control-label" style="font-size: 20px; margin-top: 20px">NomeComercío</label>
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-4">
                    <label class="control-label" style="font-size: 40px; margin-left: 20px; color: red">Representante:</label>
                </div>
                <div class="col-md-8">
                    <label class="control-label" style="font-size: 20px; margin-top: 20px">NomeRepresentante</label>
                </div>
            </div>


            <div class="form-group">
                <div class="col-lg-12 text-left">
                    <button type="button" class="btn btn-danger" style="font-size: large; margin-top: 100px; margin-right: 100px">Dados</button>
                    <button type="button" class="btn btn-danger" style="font-size: large; margin-top: 100px; margin-right: 100px">Cardápio</button>
                    <button type="button" class="btn btn-danger" style="font-size: large; margin-top: 100px">Avaliações</button>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
