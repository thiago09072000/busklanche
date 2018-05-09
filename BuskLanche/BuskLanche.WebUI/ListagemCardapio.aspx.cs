using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuskLanche.WebUI
{
    public partial class ListagemCardapio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                //se existir, converte para inteiro
                var id = Convert.ToInt32(Request.QueryString["id"]);

                //redireciona para a pagina desejada, passando o id do comercio por parametro
                Response.Redirect(string.Format("CadastroCardapio.aspx?id={0}", id));
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("GerenciamentoComercio.aspx");
        }
    }
}