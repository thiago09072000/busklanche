﻿using BuskLanche.DataAccess;
using BuskLanche.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuskLanche.WebUI
{
    public partial class CadastroAnunciante4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected void btnFinalizar_Click(object sender, EventArgs e)
        {
            var obj = new Comercio();
            obj.Id = Convert.ToInt32(Request.QueryString["id"]);
            obj.EstiloDoLanche = txtEstiloLanches.Text;
            obj.HorarioAbertura = txtAberto.Text;
            obj.HorarioEncerramento = txtEncerramento.Text;
            obj.DescricaoComercio = txtDescrevaComercio.Text;

            if (string.IsNullOrWhiteSpace(obj.EstiloDoLanche))
            {
                pnlMSG.Visible = true;
                lblMSG.Text = "Todos os campos devem ser preenchidos";
                txtEstiloLanches.Focus();
                return;
            }

            new ComercioDAO().Atualizar4(obj);

            Response.Redirect("Login.aspx");
        }
    }
}