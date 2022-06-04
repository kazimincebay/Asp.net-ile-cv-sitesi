using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cv
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            DataSet1TableAdapters.tbl_yeteneklerTableAdapter dt = new DataSet1TableAdapters.tbl_yeteneklerTableAdapter();
            dt.YetenekSil(Convert.ToInt16(id));
            Response.Redirect("AdminYetenek.aspx");

        }
    }
}