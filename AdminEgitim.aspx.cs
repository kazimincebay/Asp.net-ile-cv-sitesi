using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cv
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.tbl_egitimTableAdapter dt1 = new DataSet1TableAdapters.tbl_egitimTableAdapter();
            Repeater1.DataSource = dt1.EgitimListele();
            Repeater1.DataBind();
            

        }
    }
}