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