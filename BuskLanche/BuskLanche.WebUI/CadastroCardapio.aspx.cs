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
    public partial class CadastroCardapio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                var id = Convert.ToInt32(Request.QueryString["id"]);
                var cardapio = new CardapioDAO().BuscarPorId(id);

                if (cardapio != null)
                {
                    txtNomeLanche.Text = cardapio.Nome;
                    txtIngredientes.Text = cardapio.Ingrediente;
                    txtPreco.Text = string.Format("{0:N2}", cardapio.Preco);
                    hdfIdComercio.Value = cardapio.Comercio.Id.ToString();
                }
            }
        }



        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            var obj = new Cardapio();
            obj.Id = string.IsNullOrWhiteSpace(Request.QueryString["id"]) ? 0 : Convert.ToInt32(Request.QueryString["id"]);
            obj.Nome = txtNomeLanche.Text;
            obj.Ingrediente = txtIngredientes.Text;
            obj.Preco = !string.IsNullOrWhiteSpace(txtPreco.Text) ? Convert.ToDecimal(txtPreco.Text) : decimal.Zero;

            if (obj.Nome == "")
            {
                pnlMSG.Visible = true;
                lblMSG.Text = "O campo nome deve ser preenchido";
                txtNomeLanche.Focus();
                return;
            }
            if (obj.Ingrediente == "")
            {
                pnlMSG.Visible = true;
                lblMSG.Text = "O campo Ingrediente deve ser preenchido";
                txtIngredientes.Focus();
                return;
            }
            if (obj.Preco == 0)
            {
                pnlMSG.Visible = true;
                lblMSG.Text = "O campo Preço deve ser preenchido";
                txtPreco.Focus();
                return;
            }
            //pegando valor do id do comercio da url do navegador e vinculando ao objeto cardápio
            var idComercio = Convert.ToInt32(Request.QueryString["idComercio"]);
            obj.Comercio = new Comercio() { Id = idComercio };

            if (obj != null && obj.Id > 0)
                new CardapioDAO().Atualizar(obj);
            else
                new CardapioDAO().Inserir(obj);

            Response.Redirect(string.Format("ListagemCardapio.aspx?id={0}", obj.Comercio.Id));
        }




        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["idComercio"]))
            {
                var idComercio = Convert.ToInt32(Request.QueryString["idComercio"]);
                Response.Redirect(string.Format("ListagemCardapio.aspx?id={0}", idComercio));
            }
        }
    }
}