using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cv
{
    public partial class WebForm16 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            DataSet1TableAdapters.tbl_projelerTableAdapter dt = new DataSet1TableAdapters.tbl_projelerTableAdapter();
            dt.ProjeSil(Convert.ToInt16(id));
            Response.Redirect("AdminProje.aspx");
        }
    }
}