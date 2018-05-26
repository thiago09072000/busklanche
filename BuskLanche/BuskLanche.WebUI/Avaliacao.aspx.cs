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

                var lstAvaliacoes = new AvaliacoesDAO().BuscaPorComercio(id);
                gridView.DataSource = lstAvaliacoes;
                gridView.DataBind();
            }
        }

        protected void btnEnviarAvaliacao_Click(object sender, EventArgs e)
        {
            var idComercio = Convert.ToInt32(Request.QueryString["id"]);

            var obj = new Avaliacoes()
            {
                Comercio = new Comercio() { Id = idComercio },
                Consumidor = new Consumidor() { Id = ((Usuario)HttpContext.Current.User).Id },
                DataHora = DateTime.Now,
                Comentario = txtFazerComentario.Text,
                Avaliacao = Convert.ToInt32(lblNotaAvaliacao.Value)
            };

            new AvaliacoesDAO().Inserir(obj);

            Response.Redirect(string.Format("Avaliacao.aspx?id={0}", idComercio));
        }

        protected void lnkEstrela1_Click(object sender, EventArgs e)
        {
            imgEstrela1.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
            imgEstrela2.Attributes.Add("src", ResolveUrl("~/Images/estrela2.jpg"));
            imgEstrela3.Attributes.Add("src", ResolveUrl("~/Images/estrela2.jpg"));
            imgEstrela4.Attributes.Add("src", ResolveUrl("~/Images/estrela2.jpg"));
            imgEstrela5.Attributes.Add("src", ResolveUrl("~/Images/estrela2.jpg"));
            lblNotaAvaliacao.Value = "1";
        }

        protected void lnkEstrela2_Click(object sender, EventArgs e)
        {
            imgEstrela1.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
            imgEstrela2.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
            imgEstrela3.Attributes.Add("src", ResolveUrl("~/Images/estrela2.jpg"));
            imgEstrela4.Attributes.Add("src", ResolveUrl("~/Images/estrela2.jpg"));
            imgEstrela5.Attributes.Add("src", ResolveUrl("~/Images/estrela2.jpg"));
            lblNotaAvaliacao.Value = "2";
        }

        protected void lnkEstrela3_Click(object sender, EventArgs e)
        {
            imgEstrela1.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
            imgEstrela2.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
            imgEstrela3.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
            imgEstrela4.Attributes.Add("src", ResolveUrl("~/Images/estrela2.jpg"));
            imgEstrela5.Attributes.Add("src", ResolveUrl("~/Images/estrela2.jpg"));
            lblNotaAvaliacao.Value = "3";
        }

        protected void lnkEstrela4_Click(object sender, EventArgs e)
        {
            imgEstrela1.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
            imgEstrela2.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
            imgEstrela3.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
            imgEstrela4.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
            imgEstrela5.Attributes.Add("src", ResolveUrl("~/Images/estrela2.jpg"));
            lblNotaAvaliacao.Value = "2";
        }

        protected void lnkEstrela5_Click(object sender, EventArgs e)
        {
            imgEstrela1.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
            imgEstrela2.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
            imgEstrela3.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
            imgEstrela4.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
            imgEstrela5.Attributes.Add("src", ResolveUrl("~/Images/estrela1.jpg"));
            lblNotaAvaliacao.Value = "3";
        }
    }
}