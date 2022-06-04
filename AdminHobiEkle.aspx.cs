using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cv
{
    public partial class WebForm18 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            DataSet1TableAdapters.tbl_hobilerTableAdapter dt = new DataSet1TableAdapters.tbl_hobilerTableAdapter();
            dt.HobiEkle(TextBox1.Text);
            Response.Redirect("AdminHobi.aspx");
        }
    }
}