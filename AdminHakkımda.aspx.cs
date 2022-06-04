using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cv
{
    public partial class Hakkımda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {

                DataSet1TableAdapters.tbl_hakkımdaTableAdapter dt = new DataSet1TableAdapters.tbl_hakkımdaTableAdapter();
                TextBox1.Text = dt.HakkımdaListele()[0].Ad;
                TextBox2.Text = dt.HakkımdaListele()[0].Soyad;
                TextBox3.Text = dt.HakkımdaListele()[0].Mail;
                TextBox4.Text = dt.HakkımdaListele()[0].Telefon;
                TextBox5.Text = dt.HakkımdaListele()[0].Fotograf;
                TextBox6.Text = dt.HakkımdaListele()[0].Adres;
                TextBox7.Text = dt.HakkımdaListele()[0].Hakkımda;
            }       
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.tbl_hakkımdaTableAdapter dt1 = new DataSet1TableAdapters.tbl_hakkımdaTableAdapter();
            dt1.HakkımdaGuncelle(TextBox1.Text, TextBox2.Text, TextBox6.Text,TextBox3.Text,TextBox4.Text,TextBox7.Text,TextBox5.Text);
            Response.Redirect("AdminHakkımda.Aspx");

        }
    }
}