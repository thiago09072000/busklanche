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
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            //var obj = new Cardapio();
            //obj.Nome = txtNomeLanche.Text;
            //obj.Ingrediente = txtIngredientes.Text;
            //obj.Preco = Convert.ToDecimal(txtPreco.Text);
            Response.Redirect("ListagemCardapio.aspx");
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListagemCardapio.aspx");
        }
    }
}

