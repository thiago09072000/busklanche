﻿using System;
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




            if (txtInfCEP.Text == "")
            {
                pnlMSG.Visible = true;
                lblMSG.Text = "Todos os campos devem ser preenchidos";
                txtInfCEP.Focus();
                return;
            }
            else
            {
                Response.Redirect("ResultadoBusk.aspx");
            }

            //Response.Redirect("ResultadoBusk.aspx");
        }
    }
}