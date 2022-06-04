using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cv
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.tbl_hakkımdaTableAdapter dthakkimda = new DataSet1TableAdapters.tbl_hakkımdaTableAdapter();
            Repeater1.DataSource = dthakkimda.HakkımdaListele();
            Repeater1.DataBind();

            DataSet1TableAdapters.tbl_egitimTableAdapter dtegitim = new DataSet1TableAdapters.tbl_egitimTableAdapter();
            Repeater2.DataSource = dtegitim.EgitimListele();
            Repeater2.DataBind();

            DataSet1TableAdapters.tbl_SertifikalarTableAdapter dtsertifika = new DataSet1TableAdapters.tbl_SertifikalarTableAdapter();
            Repeater3.DataSource = dtsertifika.SertifikaListele();
            Repeater3.DataBind();

            DataSet1TableAdapters.tbl_projelerTableAdapter dtproje = new DataSet1TableAdapters.tbl_projelerTableAdapter();
            Repeater4.DataSource = dtproje.ProjeListele();
            Repeater4.DataBind();

            DataSet1TableAdapters.tbl_hobilerTableAdapter dthobi = new DataSet1TableAdapters.tbl_hobilerTableAdapter();
            Repeater5.DataSource = dthobi.HobiListele();
            Repeater5.DataBind();

            DataSet1TableAdapters.tbl_yeteneklerTableAdapter dtyetenek = new DataSet1TableAdapters.tbl_yeteneklerTableAdapter();
            Repeater6.DataSource = dtyetenek.YetenekListele();
            Repeater6.DataBind();

            DataSet1TableAdapters.tbl_hakkımdaTableAdapter dtfotograf = new DataSet1TableAdapters.tbl_hakkımdaTableAdapter();
            Repeater7.DataSource = dtfotograf.HakkımdaListele();
            Repeater7.DataBind();

        }
    }
}