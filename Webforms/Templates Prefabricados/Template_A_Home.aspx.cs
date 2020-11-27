﻿using Modelo;
using System;

namespace WebForms.Templates_Prefabricados
{
    public partial class Template_A_Home : System.Web.UI.Page
    {
        public Relleno RellenoVariable { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["relleno"] != null)
            {
                RellenoVariable = (Relleno)Session["relleno"];
            }
        }
    }
}