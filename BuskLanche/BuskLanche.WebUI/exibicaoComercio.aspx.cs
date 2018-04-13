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
    public partial class exibicaoComercio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Avaliacao.aspx");
        }

        protected void btnSelecionar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ResultadoBusk.aspx");
        }
    }
}