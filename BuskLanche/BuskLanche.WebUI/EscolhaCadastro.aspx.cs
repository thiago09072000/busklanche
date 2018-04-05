using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuskLanche.WebUI
{
    public partial class EscolhaCadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsumidor_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastroConsumidor.aspx");
        }

        protected void BtnAnunciante_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastroAnunciante1.aspx");
        }
    }
}