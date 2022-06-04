using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cv
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.tbl_yeteneklerTableAdapter dt1 = new DataSet1TableAdapters.tbl_yeteneklerTableAdapter();
            Repeater1.DataSource = dt1.YetenekListele();
            Repeater1.DataBind();
        }
    }
}