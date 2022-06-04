﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cv
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            TextBox5.Enabled = false;
            TextBox5.Text = x.ToString();
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.tbl_yeteneklerTableAdapter dt = new DataSet1TableAdapters.tbl_yeteneklerTableAdapter();
                TextBox1.Text = dt.YetenekGetir(Convert.ToInt16(x))[0].Yetenek;
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.tbl_yeteneklerTableAdapter dt = new DataSet1TableAdapters.tbl_yeteneklerTableAdapter();
            dt.YetenekGuncelle(TextBox1.Text,Convert.ToInt16(TextBox5.Text));
            Response.Redirect("AdminYetenek.aspx");
        }
    }
}