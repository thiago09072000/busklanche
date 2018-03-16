<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EscolhaCadastro.aspx.cs" Inherits="BuskLanche.WebUI.EscolhaCadastro" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-lg-12 text-center">
            <h1 style="font-weight: bold; color: red">Escolha de Cadastro</h1>
        </div>
    </div>
    <div class="row">
        <form class="form-horizontal">
            <div class="form-group">
                <div class="col-md-6 text-center">
                    <button type="button" class="btn btn-warning" style="font-weight: bold; font-size: 65px ; margin-top: 150px">Consumidor</button>
                </div>
                <div class="col-md-6 text-center">
                    <button type="button" class="btn btn-warning" style="font-weight: bold; font-size: 65px ; margin-top: 150px">Anúnciante</button>
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-12">
                    <label class="control-label" style="margin-top: 200px; color: red">* Somente válido para Curitiba e Região Metropolitana</label>
                </div>
            </div>
        </form>
    </div>

 </asp:Content>
