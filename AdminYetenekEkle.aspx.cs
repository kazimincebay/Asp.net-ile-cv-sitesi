﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cv
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.tbl_yeteneklerTableAdapter dt = new DataSet1TableAdapters.tbl_yeteneklerTableAdapter();
            dt.YetenekEkle(TextBox1.Text);
            Response.Redirect("AdminYetenek.aspx");
        }
    }
}