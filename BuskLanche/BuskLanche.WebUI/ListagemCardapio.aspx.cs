using BuskLanche.DataAccess;
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

            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                //se existir, converte para inteiro
                var id = Convert.ToInt32(Request.QueryString["id"]);
                var lstCardapio = new CardapioDAO().BuscarPorComercio(id);

                grdCardapio.DataSource = lstCardapio;
                grdCardapio.DataBind();
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                //se existir, converte para inteiro
                var id = Convert.ToInt32(Request.QueryString["id"]);

                //redireciona para a pagina desejada, passando o id do comercio por parametro
                Response.Redirect(string.Format("CadastroCardapio.aspx?idComercio={0}", id));
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            var idComercio = Convert.ToInt32(Request.QueryString["id"]);
            Response.Redirect(string.Format("GerenciamentoComercio.aspx?id={0}", idComercio));
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(((LinkButton)sender).CommandArgument))
            {
                var id = Convert.ToInt32(((LinkButton)sender).CommandArgument);
                if (id > 0)
                {
                    if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
                    {
                        var idComercio = Convert.ToInt32(Request.QueryString["id"]);
                        Response.Redirect(string.Format("CadastroCardapio.aspx?id={0}&idComercio={1}", id, idComercio));
                    }
                }
            }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(((LinkButton)sender).CommandArgument))
            {
                var id = Convert.ToInt32(((LinkButton)sender).CommandArgument);
                if (id > 0)
                {
                    new CardapioDAO().Excluir(id);

                    var idComercio = Convert.ToInt32(Request.QueryString["id"]);
                    Response.Redirect(string.Format("ListagemCardapio.aspx?id={0}", idComercio));
                }
            }
        }
    }
}