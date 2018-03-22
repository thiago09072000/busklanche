<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroAnunciante4.aspx.cs" Inherits="BuskLanche.WebUI.CadastroAnunciante4" %>

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
                    <label class="control-label" style="font-size: 30px; margin-left: 30px; color: black">Inserir: Funcionamento do comércio</label>
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-12">
                    <label class="control-label" style="font-size: x-large; margin-top: 50px">Estilo de lanches:</label>
                    <input type="text" class="form-control" style="font-size: x-large" />
                </div>
            </div>

            <div class="form-group">

                <div class="col-lg-4">
                    <label class="control-label" style="font-size: x-large; margin-top: 50px">Horários de funcionamento:</label>
                </div>

                <div class="col-lg-2">
                    <label class="control-label" style="font-size: x-large; margin-top: 25px">Aberto das:</label>
                    <input type="time" class="form-control" style="font-size: x-large" />
                </div>

                <div class="col-lg-2">
                    <label class="control-label" style="font-size: x-large; margin-top: 25px">Encerramento:</label>
                    <input type="time" class="form-control" style="font-size: x-large" />
                </div>



            </div>

            <div class="form-group">
                <div class="col-lg-12">
                    <label class="control-label" style="font-size: x-large; margin-top: 50px">Descreva o seu comércio:</label>
                    <textarea class="form-control" rows="5" id="comment"></textarea>
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
