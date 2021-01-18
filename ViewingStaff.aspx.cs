using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TurkishExporter
{
    public partial class ViewingStaff : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8L9FOKA;Initial Catalog=LuckyPersons;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBL_ViewingStaff", baglanti);
            listele.DataSource = komut.ExecuteReader();
            listele.DataBind();
            baglanti.Close();
        }
    }
}