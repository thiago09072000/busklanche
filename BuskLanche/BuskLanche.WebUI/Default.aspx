<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BuskLanche.WebUI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-lg-12 text-center">
            <h1 style="font-weight: bold; color: red; font-size: 50px">Busk</h1>
        </div>
    </div>
    <div class="col-lg-12">
        <form class="form-horizontal">
            <div class="form-group">
                <div class="col-lg-12">
                    <label class="control-label" style="font-size: x-large; margin-top: 50px">Informe seu CEP atual</label>
                    <input type="text" class="form-control" style="font-size: x-large" />
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-12">
                    <label class="control-label" style="font-size: x-large; margin-top: 50px">Listar por:</label>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-4">
                    <input type="checkbox" style="font-size: x-large" />
                    <label class="control-label" style="font-size: large">Mais Proxímos</label>
                </div>
                <div class="col-lg-4">
                    <input type="checkbox" style="font-size: x-large" />
                    <label class="control-label" style="font-size: large">Menor Preço</label>
                </div>
                <div class="col-lg-4">
                    <input type="checkbox" style="font-size: x-large" />
                    <label class="control-label" style="font-size: large">Melhores Avaliações</label>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-12 text-right">
                    <button type="button" class="btn btn-danger" style="font-size: large; margin-top: 100px">Buscar</button>
                </div>
            </div>
        </form>
    </div>

</asp:Content>
