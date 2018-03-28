<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DadosCadastrados.aspx.cs" Inherits="BuskLanche.WebUI.DadosCadastrados" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="form-horizontal">
            <div class="form-group">
                <div class="col-md-12">
                    <label class="control-label" style="font-size: 40px; margin-left: 20px; color: red">Dados cadastrados sobre o comércio:</label>
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-12">
                    <label class="control-label" style="font-size: x-large; margin-top: 50px">Nome do Restaurante:</label>
                    <input type="text" class="form-control" style="font-size: x-large" />
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-12">
                    <label class="control-label" style="font-size: x-large; margin-top: 50px">CNPJ:</label>
                    <input type="text" class="form-control" style="font-size: x-large" />
                </div>
            </div>



            <div class="form-group">
                <div class="col-lg-12">
                    <label class="control-label" style="font-size: x-large; margin-top: 50px">Bairro:</label>
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
                    <label class="control-label" style="font-size: x-large; margin-top: 50px">CEP:</label>
                    <input type="text" class="form-control" style="font-size: x-large" />
                </div>

            </div>

            <div class="col-lg-12">
                <label class="control-label" style="font-size: x-large; margin-top: 50px">Complemento:</label>
                <input type="text" class="form-control" style="font-size: x-large" />
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

                <div class="col-lg-12 text-right">
                    <button type="button" class="btn btn-danger" style="font-size: large; margin-top: 100px">Salvar</button>
                </div>
            </div>


        </div>
    </div>
</asp:Content>
