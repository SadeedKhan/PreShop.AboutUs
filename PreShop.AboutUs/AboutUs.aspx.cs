using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PreShop.AboutUs.BL;

namespace PreShop.AboutUs
{
    public partial class AboutUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AboutUsInfo info = BL_AddAboutUsInfo.GetAboutUs();
                lblabout.Text = info.About;
                lblhistory.Text = info.History;
                lblMission.Text = info.Mission;
            }
        }
    }
}