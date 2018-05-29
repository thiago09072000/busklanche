using BuskLanche.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuskLanche.WebUI
{
    public partial class ResultadoAvaliacao : System.Web.UI.Page
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

                var lstAvaliacoes = new AvaliacoesDAO().BuscaPorComercio(id);
                gridView.DataSource = lstAvaliacoes;
                gridView.DataBind();
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            var idComercio = Convert.ToInt32(Request.QueryString["id"]);
            Response.Redirect(string.Format("GerenciamentoComercio.aspx?id={0}", idComercio));
        }
    }
}