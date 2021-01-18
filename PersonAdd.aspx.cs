using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TurkishExporter
{
    public partial class PersonAdd : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8L9FOKA;Initial Catalog=LuckyPersons;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBL_NAMES (NAMESURNAME) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", TextBox2.Text);
            komut.ExecuteNonQuery();
            Response.Redirect("Default.aspx");
        }
    }
}