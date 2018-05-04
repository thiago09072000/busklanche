using BuskLanche.DataAccess;
using BuskLanche.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuskLanche.WebUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            if (rdoAnunciante.Checked)
            {
                var usuarioLogado = new ComercioDAO().Logar(txtEmail.Text, txtSenha.Text);

                var userData = new JavaScriptSerializer().Serialize(new Usuario()
                {
                    Id = usuarioLogado.Id,
                    Nome = usuarioLogado.Nome,
                    Email = usuarioLogado.Email
                });

                FormsAuthenticationUtil.SetCustomAuthCookie(usuarioLogado.Email, userData, false);

                Response.Redirect(string.Format("~/GerenciamentoComercio.aspx?id={0}", usuarioLogado.Id));
            }
            else
            {
                var usuarioLogado = new ConsumidorDAO().Logar(txtEmail.Text, txtSenha.Text);

                var userData = new JavaScriptSerializer().Serialize(new Usuario()
                {
                    Id = usuarioLogado.Id,
                    Nome = usuarioLogado.Nome,
                    Email = usuarioLogado.Email
                });

                FormsAuthenticationUtil.SetCustomAuthCookie(usuarioLogado.Email, userData, false);

                Response.Redirect("~/Default.aspx");
            }
        }
    }
}