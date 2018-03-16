<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroConsumidor.aspx.cs" Inherits="BuskLanche.WebUI.CadastroConsumidor" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="form-horizontal">
            <div class="form-group">
                <div class="col-md-3">
                    <label class="control-label" style="font-size: 40px; margin-left: 20px; color: red">Cadastro:</label>
                </div>
                <div class="col-md-9">
                    <label class="control-label" style="font-size: 20px; margin-top: 20px; color: cornflowerblue">Usuário Consumidor</label>
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-12">
                    <label class="control-label" style="font-size: x-large; margin-top: 50px">Nome completo:</label>
                    <input type="text" class="form-control" style="font-size: x-large" />
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-4">
                    <label class="control-label" style="font-size: x-large; margin-top: 50px">Data de nascimento:</label>
                    <input type="date" class="form-control" style="font-size: x-large" />
                </div>

                <div class="col-lg-8">
                    <label class="control-label" style="font-size: x-large; margin-top: 50px">CPF:</label>
                    <input type="text" class="form-control" style="font-size: x-large" />
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-8">
                    <label class="control-label" style="font-size: x-large; margin-top: 50px">Email:</label>
                    <input type="email" class="form-control" style="font-size: x-large" />
                </div>

                <div class="col-lg-4">
                    <label class="control-label" style="font-size: x-large; margin-top: 50px">Senha:</label>
                    <input type="password" class="form-control" style="font-size: x-large" />
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-6">
                    <label class="control-label" style="color: red; margin-top: 100px">*Todos os campos são obrigatórios</label>
                </div>
                <div class="col-lg-6 text-right">
                    <button type="button" class="btn btn-danger" style="font-size: large; margin-top: 100px">Finalizar</button>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
