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
    public partial class CadastroAnunciante2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected void btnProximoCad_Click(object sender, EventArgs e)
        {
            var obj = new Comercio();
            obj.Id = Convert.ToInt32(Request.QueryString["id"]);
            obj.Bairro = txtBairro.Text;
            obj.Cep = txtCEP.Text;
            obj.Numero = Convert.ToInt32(txtNumero.Text);
            obj.Rua = txtRua.Text;
            obj.Complemento = txtComplemento.Text;

            if (string.IsNullOrWhiteSpace(obj.Bairro))
            {
                pnlMSG.Visible = true;
                lblMSG.Text = "O campo Bairro devem ser preenchidos";
                txtBairro.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(obj.Cep))
            {
                pnlMSG.Visible = true;
                lblMSG.Text = "O campo Cep devem ser preenchidos";
                txtCEP.Focus();
                return;
            }
            if (obj.Numero == 0)
            {
                pnlMSG.Visible = true;
                lblMSG.Text = "O campo Número devem ser preenchidos";
                txtNumero.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(obj.Rua))
            {
                pnlMSG.Visible = true;
                lblMSG.Text = "O campo Rua devem ser preenchidos";
                txtRua.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(obj.Complemento))
            {
                pnlMSG.Visible = true;
                lblMSG.Text = "O campo Complemento devem ser preenchidos";
                txtComplemento.Focus();
                return;
            }
            var vdCep = new ComercioDAO().ValidarCEP(txtCEP.Text);

            if (vdCep == false)
            {
                pnlMSG.Visible = true;
                lblMSG.Text = "O Cep é Invalido";
                txtCEP.Focus();
                return;
            }

            new ComercioDAO().Atualizar2(obj);

            Response.Redirect(string.Format("CadastroAnunciante3.aspx?id={0}", obj.Id));
        }
    }
}