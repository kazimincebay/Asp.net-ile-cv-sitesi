using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cv
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            DataSet1TableAdapters.tbl_SertifikalarTableAdapter dt = new DataSet1TableAdapters.tbl_SertifikalarTableAdapter();
            dt.SertifikaEkle(TextBox1.Text,TextBox2.Text, TextBox4.Text);
            Response.Redirect("AdminSertifika.aspx");
        }
    }
}