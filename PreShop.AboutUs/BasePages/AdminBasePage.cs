using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Helper;

namespace PreShop.BasePages
{
    public class AdminBasePage : SpartansHelper
    {
        public static bool DeveloperAccount { get { return HttpContext.Current.Session["DeveloperAccount"].ToBoolean(); } }
        protected override void OnLoad(EventArgs e)
        {
            if (Session["AdminID"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            base.OnLoad(e);
        }
    }
}