using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuskLanche.WebUI
{
    public partial class GerenciamentoComercio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDados_Click(object sender, EventArgs e)
        {
            Response.Redirect("DadosCadastrados.aspx");
        }

        protected void btnCardápio_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastroCardapio.aspx");
        }

        protected void btnAvaliações_Click(object sender, EventArgs e)
        {
            Response.Redirect("ResultadoAvaliacao.aspx");
        }
    }
}