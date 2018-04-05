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

        }

        protected void btnProximoCad_Click(object sender, EventArgs e)
        {
            var obj = new Comercio();
            obj.NomeComercio = txtNomeRestaurante.Text;
            obj.Cnpj = txtCNPJ.Text;

            Response.Redirect("CadastroAnunciante2.aspx");
        }
    }
}