using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cv
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["Id"]);

            DataSet1TableAdapters.tbl_egitimTableAdapter dt = new DataSet1TableAdapters.tbl_egitimTableAdapter();
            dt.egitimsil(Convert.ToInt16(id));
            Response.Redirect("AdminEgitim.aspx");
        }
    }
}