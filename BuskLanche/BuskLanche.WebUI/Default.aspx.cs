using BuskLanche.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuskLanche.WebUI
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInfCEP.Text))
            {
                pnlMSG.Visible = true;
                lblMSG.Text = "O campo CEP deve ser preenchido!";
                txtInfCEP.Focus();
                return;
            }
            var vdCep = new ComercioDAO().ValidarCEP(txtInfCEP.Text);

            if (vdCep == false)
            {
                pnlMSG.Visible = true;
                lblMSG.Text = "CEP inválido!";
                txtInfCEP.Focus();
                return;
            }
            else
            {
                var criterio = string.Empty;
                if (rdoMaisProx.Checked)
                    criterio = "MaisProx";
                else if (rdoMenorDuracao.Checked)
                    criterio = "MenorDur";
                else
                    criterio = "MelhorAva";
                Response.Redirect(string.Format("ResultadoBusk.aspx?cep={0}&criterio={1}", txtInfCEP.Text, criterio));
            }
        }
    }
}