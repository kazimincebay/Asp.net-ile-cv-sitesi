using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cv
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.tbl_projelerTableAdapter dt1 = new DataSet1TableAdapters.tbl_projelerTableAdapter();
            Repeater1.DataSource = dt1.ProjeListele();
            Repeater1.DataBind();
        }
    }
}