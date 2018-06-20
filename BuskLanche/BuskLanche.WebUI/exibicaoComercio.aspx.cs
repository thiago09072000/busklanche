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
            if (IsPostBack)
                return;

            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                var id = Convert.ToInt32(Request.QueryString["id"]);

                var obj = new ComercioDAO().BuscarPorId(id);
                obj.Cardapio = new CardapioDAO().BuscarPorComercio(id);

                lblNomeComercio.Text = obj.NomeComercio;
                lblTelefone.Text = obj.TelefoneRepresentante;
                lblDisponibilidade.Text = obj.Disponibilidade;
                lblDescricao.Text = obj.DescricaoComercio;

                if (obj.NotaMedia >= 0 && obj.NotaMedia <= 1)
                {
                    imgEstrela1.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
                    imgEstrela2.Attributes.Add("src", ResolveUrl("~/Images/estrela2.jpg"));
                    imgEstrela3.Attributes.Add("src", ResolveUrl("~/Images/estrela2.jpg"));
                    imgEstrela4.Attributes.Add("src", ResolveUrl("~/Images/estrela2.jpg"));
                    imgEstrela5.Attributes.Add("src", ResolveUrl("~/Images/estrela2.jpg"));
                }
                else if (obj.NotaMedia > 1 && obj.NotaMedia <= 2)
                {
                    imgEstrela1.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
                    imgEstrela2.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
                    imgEstrela3.Attributes.Add("src", ResolveUrl("~/Images/estrela2.jpg"));
                    imgEstrela4.Attributes.Add("src", ResolveUrl("~/Images/estrela2.jpg"));
                    imgEstrela5.Attributes.Add("src", ResolveUrl("~/Images/estrela2.jpg"));
                }
                else if (obj.NotaMedia > 2 && obj.NotaMedia <= 3)
                {
                    imgEstrela1.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
                    imgEstrela2.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
                    imgEstrela3.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
                    imgEstrela4.Attributes.Add("src", ResolveUrl("~/Images/estrela2.jpg"));
                    imgEstrela5.Attributes.Add("src", ResolveUrl("~/Images/estrela2.jpg"));
                }
                else if (obj.NotaMedia > 3 && obj.NotaMedia <= 4)
                {
                    imgEstrela1.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
                    imgEstrela2.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
                    imgEstrela3.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
                    imgEstrela4.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
                    imgEstrela5.Attributes.Add("src", ResolveUrl("~/Images/estrela2.jpg"));
                }
                else if (obj.NotaMedia > 4 && obj.NotaMedia <= 5)
                {
                    imgEstrela1.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
                    imgEstrela2.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
                    imgEstrela3.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
                    imgEstrela4.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
                    imgEstrela5.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
                }
                grdCardapio.DataSource = obj.Cardapio;
                grdCardapio.DataBind();
            }
        }

        protected void btnFechar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnAvaliar_Click(object sender, EventArgs e)
        {
            var idComercio = Convert.ToInt32(Request.QueryString["id"]);
            Response.Redirect(string.Format("Avaliacao.aspx?id={0}", idComercio));
        }
    }
}