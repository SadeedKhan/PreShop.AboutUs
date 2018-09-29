using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Helper;
using System.Data;

namespace PreShop.AboutUs.BL
{

    public struct AboutUsInfo
    {
        public string About;
        public string Mission;
        public string History;
    }

    public class BL_AddAboutUsInfo : SpartansHelper
    {

        public int Aid { get; set; }
        public string About { get; set; }
        public string Mission { get; set; }
        public string History { get; set; }
        public int Status { get; set; }

        public bool SaveAbout()
        {
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@Aid", Aid);
            prm[1] = new SqlParameter("@About", About);
            prm[2] = new SqlParameter("@Mission", Mission);
            prm[3] = new SqlParameter("@History", History);
            ExecuteQuery("sp_saveabout", prm);
            return true;
        }

        public static AboutUsInfo GetAboutUs()
        {
            AboutUsInfo info = new AboutUsInfo();
            DataTable dt = ExecutePlainQuery("select * from tbl_AboutUs");
            if (dt.Rows.Count > 0)
            {
                info.About = dt.Rows[0]["About"].toString();
                info.Mission = dt.Rows[0]["Mission"].toString();
                info.History = dt.Rows[0]["History"].toString();
            }
            else
            {
                info.About = "Not in the system";
                info.Mission = "Not in the system";
                info.History = "Not in the system";
            }
            return info;
        }
    }
}