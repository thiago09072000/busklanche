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
    public partial class CadastroAnunciante3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected void btnProximoCad3_Click(object sender, EventArgs e)
        {
            var obj = new Comercio();
            obj.Id = Convert.ToInt32(Request.QueryString["id"]);
            obj.NomeRepresentante = txtNomeCompleto.Text;
            obj.EmailRepresentante = txtEmail.Text;
            obj.SenhaRepresentante = txtSenha.Text;
            obj.CpfRepresentante = txtCPF.Text;
            obj.TelefoneRepresentante = txtCelular.Text;

            new ComercioDAO().Atualizar2(obj);

            Response.Redirect(string.Format("CadastroAnunciante4.aspx?id={0}", obj.Id));
        }
    }
}