using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cv
{
    public partial class WebForm17 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.tbl_hobilerTableAdapter dt1 = new DataSet1TableAdapters.tbl_hobilerTableAdapter();
            Repeater1.DataSource = dt1.HobiListele();
            Repeater1.DataBind();
        }
    }
}