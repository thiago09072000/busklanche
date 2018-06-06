using BuskLanche.DataAccess;
using BuskLanche.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuskLanche.WebUI
{
    public partial class CadastroConsumidor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected void btnFinalizar_Click(object sender, EventArgs e)
        {
            var obj = new Consumidor();

            obj.Nome = txtNomeConsumidor.Text;
            obj.Senha = txtSenha.Text;
            obj.Email = txtEmail.Text;
            obj.Cpf = txtCPF.Text;

            if (obj.Nome == null)
            {
                pnlMSG.Visible = true;
                lblMSG.Text = "alerta!";
                txtNomeConsumidor.Focus();
                return;
            }

            new ConsumidorDAO().Inserir(obj);

            Response.Redirect("Login.aspx");
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("EscolhaCadastro.aspx");
        }
    }
}

