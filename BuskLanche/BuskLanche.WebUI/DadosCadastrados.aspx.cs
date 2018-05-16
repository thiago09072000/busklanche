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
                txtComplemento.Text = obj.Complemento;
                txtEstiloLanche.Text = obj.EstiloDoLanche;
                txtAberto.Text = obj.HorarioAbertura;
                txtEncarramento.Text = obj.HorarioEncerramento;
                txtDescricao.Text = obj.DescricaoComercio;

            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            var obj = new Comercio();
            obj.Id = string.IsNullOrWhiteSpace(Request.QueryString["id"]) ? 0 : Convert.ToInt32(Request.QueryString["id"]);
            obj.NomeComercio = txtNomeRestaurante.Text;
            obj.Cnpj = txtCNPJ.Text;
            obj.Bairro = txtBairro.Text;
            obj.Rua = txtRua.Text;
            obj.Numero = Convert.ToInt32(txtNumero.Text);
            obj.Cep = txtCEP.Text;
            obj.Complemento = txtComplemento.Text;
            obj.EstiloDoLanche = txtEstiloLanche.Text;
            obj.HorarioAbertura = txtAberto.Text;
            obj.HorarioEncerramento = txtEncarramento.Text;

            new ComercioDAO().AlterarDados(obj);

            Response.Redirect("GerenciamentoComercio.aspx");
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("GerenciamentoComercio.aspx");
        }
    }
}