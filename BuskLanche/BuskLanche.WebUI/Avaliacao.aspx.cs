using BuskLanche.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuskLanche.WebUI
{
    public partial class Avaliacao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                var id = Convert.ToInt32(Request.QueryString["id"]);

                var obj = new ComercioDAO().BuscarPorId(id);

                lblNomeComercio.Text = obj.NomeComercio;

            }
        }

        protected void btnSelecionar_Click(object sender, EventArgs e)
        {
            var idComercio = Convert.ToInt32(Request.QueryString["id"]);
            Response.Redirect(string.Format("exibicaoComercio.aspx?id={0}", idComercio));
        }
    }
}