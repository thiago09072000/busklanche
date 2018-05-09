using BuskLanche.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuskLanche.WebUI
{
    public partial class DadosCadastrados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                //se existir, converte para inteiro
                var id = Convert.ToInt32(Request.QueryString["id"]);

                var obj = new ComercioDAO().BuscarPorId(id);
                obj.Cardapio = new CardapioDAO().BuscarPorComercio(id);

                txtNomeRestaurante.Text = obj.NomeComercio;
                txtCNPJ.Text = obj.Cnpj;
                txtBairro.Text = obj.Bairro;
                txtRua.Text = obj.Rua;
                txtNumero.Text = Convert.ToString(obj.Numero);
                txtCEP.Text = obj.Cep;
                txtComplemento.Text = obj.Complemeneto;
                txtEstiloLanche.Text = obj.EstiloDoLanche;
                txtAberto.Text = obj.HorarioAbertura;
                txtEncarramento.Text = obj.HorarioEncerramento;
                txtDescricao.Text = obj.DescricaoComercio;

            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Response.Redirect("GerenciamentoComercio.aspx");
        }
    }
}