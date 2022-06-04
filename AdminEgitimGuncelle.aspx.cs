using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cv
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["Id"]);
            TextBox5.Enabled = false;
            TextBox5.Text = x.ToString();
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.tbl_egitimTableAdapter dt = new DataSet1TableAdapters.tbl_egitimTableAdapter();
                TextBox1.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].Baslik;
                TextBox2.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].Altbaslik;
                TextBox3.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].Aciklama;
                TextBox4.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].Tarih;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.tbl_egitimTableAdapter dt = new DataSet1TableAdapters.tbl_egitimTableAdapter();
            dt.egitimguncelle(TextBox1.Text,TextBox2.Text,TextBox3.Text,TextBox4.Text,Convert.ToInt16(TextBox5.Text));
            Response.Redirect("AdminEgitim.aspx");
        }
    }
}