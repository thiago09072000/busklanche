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

        }

        protected void btnProximoCad_Click(object sender, EventArgs e)
        {
            var obj = new Comercio();
            obj.Bairro = txtBairro.Text;
            obj.Cep = txtCEP.Text;
            obj.Numero = Convert.ToInt32(txtNumero);
            obj.Rua = txtRua.Text;
            obj.Complemeneto = txtComplemento.Text;

            Response.Redirect("CadastroAnunciante3.aspx");
        }
    }
}