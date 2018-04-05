using BuskLanche.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuskLanche.WebUI
{
    public partial class CadastroAnunciante4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFinalizar_Click(object sender, EventArgs e)
        {
            var obj = new Comercio();
            obj.EstiloDoLanche = txtEstiloLanches.Text;
            //obj.HorarioAbertura = ;
            //obj.HorarioEncerramento = ;
            obj.DescricaoComercio = txtDescrevaComercio.Text;

            Response.Redirect("Login.aspx");
        }
    }
}