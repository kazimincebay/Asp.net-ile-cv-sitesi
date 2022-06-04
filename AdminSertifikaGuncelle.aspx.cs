using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cv
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            TextBox5.Enabled = false;
            TextBox5.Text = x.ToString();
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.tbl_SertifikalarTableAdapter dt = new DataSet1TableAdapters.tbl_SertifikalarTableAdapter();
                TextBox1.Text = dt.SertifikaGetir(Convert.ToInt16(x))[0].Sertifikaadi;
                TextBox2.Text = dt.SertifikaGetir(Convert.ToInt16(x))[0].Alinankurum;
                TextBox4.Text = dt.SertifikaGetir(Convert.ToInt16(x))[0].Alinantarih;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.tbl_SertifikalarTableAdapter dt = new DataSet1TableAdapters.tbl_SertifikalarTableAdapter();
            dt.SertifikaGuncelle(TextBox1.Text, TextBox2.Text,TextBox4.Text, Convert.ToInt16(TextBox5.Text));
            Response.Redirect("AdminSertifika.aspx");
        }
    }
}