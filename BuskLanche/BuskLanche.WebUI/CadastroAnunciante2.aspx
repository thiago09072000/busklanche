<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroAnunciante2.aspx.cs" Inherits="BuskLanche.WebUI.CadastroAnunciante2" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="form-horizontal">
            <div class="form-group">
                <div class="col-md-3">
                    <label class="control-label" style="font-size: 40px; margin-left: 20px; color: red">Cadastro:</label>
                </div>
                <div class="col-md-9">
                    <label class="control-label" style="font-size: 20px; margin-top: 20px; color: cornflowerblue">Usuário Anúnciante</label>
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-12">
                    <label class="control-label" style="font-size: 30px; margin-left: 30px; color: black">Inserir: Endereço do comércio</label>
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-12">
                    <label class="control-label" style="font-size: x-large; margin-top: 50px">*Bairro:</label>
                    <input type="text" class="form-control" style="font-size: x-large" />
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-12">
                    <label class="control-label" style="font-size: x-large; margin-top: 50px">Rua:</label>
                    <input type="text" class="form-control" style="font-size: x-large" />
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-4">
                    <label class="control-label" style="font-size: x-large; margin-top: 50px">Número:</label>
                    <input type="text" class="form-control" style="font-size: x-large" />
                </div>
                <div class="col-lg-8">
                    <label class="control-label" style="font-size: x-large; margin-top: 50px">*CEP:</label>
                    <input type="text" class="form-control" style="font-size: x-large" />
                </div>

            </div>

            <div class="col-lg-12">
                <label class="control-label" style="font-size: x-large; margin-top: 50px">Complemento:</label>
                <input type="text" class="form-control" style="font-size: x-large" />
            </div>

            <div class="form-group">
                <div class="col-lg-6">
                    <label class="control-label" style="color: red; margin-top: 100px">*Todos os campos são obrigatórios</label>
                </div>
                <div class="col-lg-6 text-right">
                    <button type="button" class="btn btn-danger" style="font-size: large; margin-top: 100px">Proxímo</button>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
