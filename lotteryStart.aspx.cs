using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TurkishExporter
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8L9FOKA;Initial Catalog=LuckyPersons;Integrated Security=True");
        private void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack == true)
            {
                Timer1.Enabled = true;
            }
            Timer1.Interval = 1000;
            ListBox1.Items.Clear();
            baglanti.Open();
            string sorgu = "select * from TBL_NAMES";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ListBox1.Items.Add(dr["NAMESURNAME"].ToString());
            }
            dr.Close();

            baglanti.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
        int sayi = 4;
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            if (sayi == 0)
            {
                ListBox1.Items.Clear();
                int adet = ListBox1.Items.Count;
                Random rnd = new Random();
                int sayi = rnd.Next(0, adet);
                ListBox1.SelectedIndex = sayi;
                Label1.Text = ListBox1.SelectedItem.ToString();
                Timer1.Enabled = false;

                baglanti.Open();
                SqlCommand veri = new SqlCommand("insert into TBL_ViewingStaff (Namesoyad) values (@p1)", baglanti);
                veri.Parameters.AddWithValue("@p1", Label1.Text);
                veri.ExecuteNonQuery();

            }
        }
    }
}