using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cv
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            DataSet1TableAdapters.tbl_projelerTableAdapter dt = new DataSet1TableAdapters.tbl_projelerTableAdapter();
            dt.ProjeEkle(TextBox1.Text, TextBox2.Text, TextBox4.Text,TextBox3.Text);
            Response.Redirect("AdminProje.aspx");
        }
    }
}