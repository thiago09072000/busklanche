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
    public partial class CadastroAnunciante1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected void btnProximoCad_Click(object sender, EventArgs e)
        {
            var obj = new Comercio();
            obj.NomeComercio = txtNomeRestaurante.Text;
            obj.Cnpj = txtCNPJ.Text;

            if (string.IsNullOrWhiteSpace(obj.NomeComercio))
            {
                pnlMSG.Visible = true;
                lblMSG.Text = "O campo Nome Comercio deve ser preenchido";
                txtNomeRestaurante.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(obj.Cnpj))
            {
                pnlMSG.Visible = true;
                lblMSG.Text = "O campo CNPJ deve ser preenchido";
                txtCNPJ.Focus();
                return;
            }
            var vdCnpj = new ComercioDAO().ValidarCNPJ(txtCNPJ.Text);

            if (vdCnpj == false)
            {
                pnlMSG.Visible = true;
                lblMSG.Text = "O CNPJ é Invalido";
                txtCNPJ.Focus();
                return;
            }

            var id = new ComercioDAO().Inserir(obj);
            Response.Redirect(string.Format("CadastroAnunciante2.aspx?id={0}", id));
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("EscolhaCadastro.aspx");
        }
    }
}