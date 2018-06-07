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
            obj.Nome = txtNomeCompleto.Text;
            obj.Email = txtEmail.Text;
            obj.Senha = txtSenha.Text;
            obj.CpfRepresentante = txtCPF.Text;
            obj.TelefoneRepresentante = txtCelular.Text;

            if (string.IsNullOrWhiteSpace(obj.Nome))
            {
                pnlMSG.Visible = true;
                lblMSG.Text = "O campo Nome deve ser preenchido";
                txtNomeCompleto.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(obj.Email))
            {
                pnlMSG.Visible = true;
                lblMSG.Text = "O campo Email deve ser preenchido";
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(obj.Senha))
            {
                pnlMSG.Visible = true;
                lblMSG.Text = "O campo Email deve ser preenchido";
                txtSenha.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(obj.CpfRepresentante))
            {
                pnlMSG.Visible = true;
                lblMSG.Text = "O campo Email deve ser preenchido";
                txtCPF.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(obj.TelefoneRepresentante))
            {
                pnlMSG.Visible = true;
                lblMSG.Text = "O campo Email deve ser preenchido";
                txtCelular.Focus();
                return;
            }

            new ComercioDAO().Atualizar3(obj);

            Response.Redirect(string.Format("CadastroAnunciante4.aspx?id={0}", obj.Id));
        }
    }
}