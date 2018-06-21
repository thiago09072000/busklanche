using BuskLanche.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuskLanche.WebUI
{
    public partial class ResultadoBusk : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            if (!string.IsNullOrWhiteSpace(Request.QueryString["cep"]) && !string.IsNullOrWhiteSpace(Request.QueryString["criterio"]))
            {
                var cep = Request.QueryString["cep"];
                var criterio = Request.QueryString["criterio"];
                var lst = new ComercioDAO().BuscarTodos();

                lst.ForEach(c =>
                {
                    double distancia, duracao;
                    DirectionsAPI.CalcularDistanciaEDuracao(cep.OnlyNumbers(), c.Cep.OnlyNumbers(), out distancia, out duracao);
                    c.Distancia = string.Format("{0:n2} km", distancia / 1000);
                    c.Duracao = string.Format("{0:n2} min", duracao / 60);
                });

                if (criterio == "MaisProx")
                {
                    grdComercio.DataSource = lst.OrderBy(c => c.Distancia).ToList();
                    grdComercio.DataBind();
                }
                else if (criterio == "MenorDur")
                {
                    grdComercio.DataSource = lst.OrderBy(c => c.Duracao).ToList();
                    grdComercio.DataBind();
                }
                else
                {
                    grdComercio.DataSource = lst.OrderByDescending(c => c.NotaMedia).ToList();
                    grdComercio.DataBind();
                }
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(((LinkButton)sender).CommandArgument))
            {
                var id = Convert.ToInt32(((LinkButton)sender).CommandArgument);
                if (id > 0)
                {
                    Response.Redirect("exibicaoComercio.aspx?id=" + id);
                }
            }
        }
    }
}