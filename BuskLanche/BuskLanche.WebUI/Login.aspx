<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BuskLanche.WebUI.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-12 text-center">
            <h1 style="font-weight: bold; color: red; font-size: 50px">Login</h1>
        </div>
    </div>
    <div class="row">
        <form class="form-horizontal">
            <div class="form-group">
                <div class="col-lg-12">
                    <label class="control-label" style="font-size: x-large; margin-top: 50px">Email:</label>
                    <input type="email" class="form-control" style="font-size: x-large" />
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-12">
                    <label class="control-label" style="font-size: x-large; margin-top: 50px">Senha:</label>
                       <input type="password" class="form-control" style="font-size: x-large" />
                </div>
            </div>
            <div class="form-group">
                <div class="col-lg-4">
                       <label class="control-label" style="font-size: x-large; margin-top: 50px">Usuário: </label>
                </div>
                <div class="col-lg-4">
                    <input type="radio" style="font-size: x-large; margin-top: 70px" name="usuario" />
                    <label class="control-label" style="font-size: large">Anúnciante</label>
                </div>
                <div class="col-lg-4">
                    <input type="radio" style="font-size: x-large; margin-top: 70px" name="usuario" />
                    <label class="control-label" style="font-size: large">Consumidor</label>
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
