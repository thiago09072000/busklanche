using BuskLanche.DataAccess;
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
            if (IsPostBack)
                return;

            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                var id = Convert.ToInt32(Request.QueryString["id"]);

                var obj = new ComercioDAO().BuscarPorId(id);

                //preencher os campos nome do comércio e nome do representado
                lblNomeRepresentante.Text = obj.Nome;
                lblNomeComercio.Text = obj.NomeComercio;
            }
        }

        protected void btnDados_Click(object sender, EventArgs e)
        {
            //verifica se existe o id do comércio na url do navegador
            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                //se existir, converte para inteiro
                var id = Convert.ToInt32(Request.QueryString["id"]);

                //redireciona para a pagina desejada, passando o id do comercio por parametro
                Response.Redirect(string.Format("DadosCadastrados.aspx?id={0}", id));
            }
        }

        protected void btnCardápio_Click(object sender, EventArgs e)
        {
            //verifica se existe o id do comércio na url do navegador
            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                //se existir, converte para inteiro
                var id = Convert.ToInt32(Request.QueryString["id"]);

                //redireciona para a pagina desejada, passando o id do comercio por parametro
                Response.Redirect(string.Format("ListagemCardapio.aspx?id={0}", id));
            }
        }

        protected void btnAvaliações_Click(object sender, EventArgs e)
        {
            //verifica se existe o id do comércio na url do navegador
            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                //se existir, converte para inteiro
                var id = Convert.ToInt32(Request.QueryString["id"]);

                //redireciona para a pagina desejada, passando o id do comercio por parametro
                Response.Redirect(string.Format("ResultadoAvaliacao.aspx?id={0}", id));
            }
        }
    }
}