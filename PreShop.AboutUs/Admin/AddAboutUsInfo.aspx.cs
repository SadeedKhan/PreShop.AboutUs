﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PreShop.AboutUs.BL;
using System.Drawing;
using Helper;
using PreShop.BasePages;
namespace PreShop.AboutUs.Admin
{
    public partial class AddAboutUsInfo : AdminBasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadInfo();
            }
        }

        private void LoadInfo()
        {
            AboutUsInfo info = BL_AddAboutUsInfo.GetAboutUs();
            txtAbout.Text = info.About;
            txtMission.Text = info.Mission;
            txtHistory.Text = info.History;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            BL_AddAboutUsInfo obj = new BL_AddAboutUsInfo();
            obj.About = txtAbout.Text;
            obj.Mission = txtMission.Text;
            obj.History = txtHistory.Text;
            obj.SaveAbout();
            SpartansHelper.ClearInputs(this.Controls);
            lblmsg.ForeColor = Color.Green;
            lblmsg.Text = "Successfully Saved";
            LoadInfo();
        }
    }
}