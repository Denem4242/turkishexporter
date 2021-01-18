using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TurkishExporter
{
    public partial class PersonUpdate : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8L9FOKA;Initial Catalog=LuckyPersons;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TBL_NAMES SET NAMESURNAME=@p2 where ID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", TextBox1.Text);
            komut.Parameters.AddWithValue("@p2", TextBox2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Response.Redirect("Default.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("delete from TBL_NAMES where ID=@p1",baglanti);
            komut1.Parameters.AddWithValue("@p1", TextBox1.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            Response.Redirect("Default.aspx");
        }
    }
}