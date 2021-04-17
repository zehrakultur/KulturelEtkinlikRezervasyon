using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Proje.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

           
        {
            Proje.Business.KullaniciBilgi kullaniciBilgi = new Business.KullaniciBilgi();
            List<Proje.Business.KullaniciBilgi> KullaniciListe = new List<Business.KullaniciBilgi>();
            List<Proje.Business.KullaniciBilgi> sonuc = KullaniciListe.Where(y => y.KullaniciAd == "kullanici").ToList();

            Label1.Text = "Deneme";
            string isim = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["baglanti"].ConnectionString;
            SqlConnection baglan = new SqlConnection(isim);
            baglan.Open();

            string sorgu = "select * from KullaniciBilgi";
            SqlCommand com = new SqlCommand(sorgu, baglan);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                var ad = dr.GetValue(1).ToString();
                //var soyad = dr.GetValue(1).ToString();
            }

            
        }
    }
}