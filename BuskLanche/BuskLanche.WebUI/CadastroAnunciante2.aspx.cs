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

            if (obj.Bairro == "")
            {
                pnlMSG.Visible = true;
                lblMSG.Text = "Todos os campos devem ser preenchidos";
                txtBairro.Focus();
                return;
            }

            new ComercioDAO().Atualizar2(obj);

            Response.Redirect(string.Format("CadastroAnunciante3.aspx?id={0}", obj.Id));
        }
    }
}