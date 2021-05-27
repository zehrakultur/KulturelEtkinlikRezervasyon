using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Proje.Web
{
    public partial class test2 : System.Web.UI.Page
    {

        static public List<Proje.Business.KullaniciBilgi> kullaniciListeleri = new List<Business.KullaniciBilgi>();

        protected void Page_Load(object sender, EventArgs e)
        {
            int[] sayilar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //QUERY
            var sonuc = from sayi in sayilar where sayi > 5 select sayi;
            //foreach(var item in sonuc)
            // {
            //     lst.Items.Add(item.ToString());
            //}
            //Method ile
            List<int> sonuc1 = sayilar.Where(p => p > 5).ToList();
            foreach (var item in sonuc1)
            {
                lst.Items.Add(item.ToString());
            }


            for (int i = 0; i < 3; i++)
            {
                Proje.Business.KullaniciBilgi kullanici = new Business.KullaniciBilgi();
                kullanici.KullaniciAd = (i + 1).ToString() + "kullanici";
                kullanici.KullaniciSoyad = (i + 1).ToString() + "deneme";
                kullanici.KullaniciSifre = new Random().Next().ToString();
                kullanici.KullaniciEmail = (i + 1).ToString() + "deneme";
                kullaniciListeleri.Add(kullanici);
            }


        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Proje.Business.KullaniciBilgi> sonuc = kullaniciListeleri.Where(y => y.KullaniciAd == "2.Öğrenci").ToList();


            //ADO.NET
            string isim = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["baglanti"].ConnectionString;
            SqlConnection baglan = new SqlConnection(isim);
            //baglan.Open();

            //string sorgu = "select * from KullaniciBilgi";
            //SqlCommand com = new SqlCommand(sorgu, baglan);
            //SqlDataReader dr = com.ExecuteReader();
            //while (dr.Read())
            //{
            //    var ad = dr.GetValue(1).ToString();
            //    var soyad = dr.GetValue(2).ToString();
            //}
            //baglan.Close();

            string sorgu1 = "insert into KullaniciBilgi values('deneme','deneme','deneme','deneme')";
            string sorgu2 = "update KullaniciBilgi set KullaniciAd='Zehra Kültür' where KullaniciAd='deneme'";
            string sorgu3 = "delete from KullaniciBilgi where KullaniciAd='Zehra Kültür'";

            baglan.Open();
            SqlCommand com1 = new SqlCommand(sorgu3, baglan);
            var deger = com1.ExecuteNonQuery();

            //GridView1.DataSource = dr;
            //GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Proje.Business.KullaniciBilgi nesne = new Business.KullaniciBilgi();
            //var sonuc = nesne.Listele();
            //GridView1.DataSource = sonuc;
            //GridView1.DataBind();
            

            //Veri ekleme entity
            //Proje.Business.KullaniciBilgi nesne = new Business.KullaniciBilgi();
            //Proje.DataAccess.KullaniciBilgi nesne1 = new DataAccess.KullaniciBilgi();
            //nesne1.KullaniciAd = TextBox1.Text;
            //nesne1.KullaniciSoyad = TextBox2.Text;
            //nesne1.KullaniciEmail = TextBox3.Text;
            //nesne1.KullaniciSifre = TextBox4.Text;
            //var deger = nesne.VeriEkleme(nesne1);


            //Proje.Business.KullaniciBilgi


            //Veri Güncelleme entity
            //Proje.Business.KullaniciBilgi ara = new Business.KullaniciBilgi();
            //Proje.DataAccess.KullaniciBilgi nesne3 = new DataAccess.KullaniciBilgi();
            //nesne3.KullaniciAd = TextBox1.Text;
            //nesne3.KullaniciSoyad = TextBox2.Text;
            //nesne3.KullaniciEmail = TextBox3.Text;


            //var sonuc = ara.VeriGuncelleme(TextBox5.Text, nesne3);

            //Veri Silme entity
            Proje.Business.KullaniciBilgi ara = new Business.KullaniciBilgi();
            Proje.DataAccess.KullaniciBilgi nesne3 = new DataAccess.KullaniciBilgi();
            nesne3.KullaniciAd = TextBox1.Text;
            nesne3.KullaniciSoyad = TextBox2.Text;
            nesne3.KullaniciEmail = TextBox3.Text;


            var sonuc = ara.VeriSilme(TextBox5.Text, nesne3);
        }
    }
}