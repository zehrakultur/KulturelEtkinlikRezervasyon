using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Proje.Web
{
    public partial class Anasayfa : System.Web.UI.MasterPage
    {
        public static List<string> koltuklar = new List<string>();
        public static List<string> salonlar = new List<string>();


        protected void Page_Load(object sender, EventArgs e)

        {
            if(Session["emailSession"] != null)
            {
                Proje.Business.KullaniciBilgi klnc = new Business.KullaniciBilgi();
                var kullanici = klnc.EmailIdGetir(Session["emailSession"].ToString());
                LinkButton1.Text = kullanici.KullaniciAd+ kullanici.KullaniciSoyad;
            }


            Proje.Business.FilmBilgi filmAdiBilgi = new Business.FilmBilgi();
            var sonuc = filmAdiBilgi.FilmAdiBilgi();
            //DropDownList1.DataSource = sonuc;
            //DropDownList1.Items.Clear();
            //DropDownList1.DataBind();

            foreach (var item in sonuc)
            {
                DropDownList1.Items.Add(item.FilmAdi);
            }

            Proje.Business.Salon salonAdi = new Business.Salon();
            var salonSonuc = salonAdi.Listele();
            
            foreach (var item in salonSonuc)
            {
                DropDownList2.Items.Add(item.SalonAdi);
            }

            Proje.Business.Koltuk koltukNo = new Business.Koltuk();
            var koltukSonuc = koltukNo.KoltukListele();
            foreach (var item in koltukSonuc)
            {
                DropDownList5.Items.Add(item.KoltukNo.ToString());
                
            }

            Proje.Business.Seans seansSaati = new Business.Seans();
            var seansSaat = seansSaati.SeansListele();
            foreach (var item in seansSaat)
            {
                DropDownList6.Items.Add(item.SeansSaati.ToString());
            }



        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Proje.Business.KullaniciBilgi kullanici = new Business.KullaniciBilgi();
            bool sonuc = kullanici.GirisKontrol(TextBox1.Text, TextBox2.Text);
            if (sonuc)
            {
                Session["emailSession"] = TextBox1.Text;
                Session.Timeout = 120;
                Proje.Business.KullaniciBilgi klnc = new Business.KullaniciBilgi();
                var kullan = klnc.EmailIdGetir(Session["emailSession"].ToString());
                if (kullan.KullaniciRol == "Yönetici")
                {
                    Response.Redirect("Yonetici.aspx");
                }
                else
                {
                    Response.Redirect("Default.aspx");
                }               
            }
            else
            {
                Response.Write("<script>alert('Email ya da şifre hatalıdır.')</script>");
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Proje.Business.KullaniciBilgi kullaniciKayit = new Business.KullaniciBilgi();
            var sonuc = kullaniciKayit.Listele();
            GridView2.DataSource = sonuc;
            GridView2.DataBind();

            if (TextBox3.Text == String.Empty || TextBox4.Text == String.Empty || TextBox5.Text == String.Empty || TextBox6.Text == String.Empty || DropDownList3.SelectedItem.Text == String.Empty)
            {
                Response.Write("<script>alert('Lütfen Boş Alanları Doldurunuz')</script>");
            }
            else
            {
                //Veri ekleme entity
                Proje.Business.KullaniciBilgi nesne = new Business.KullaniciBilgi();
                Proje.DataAccess.KullaniciBilgi nesne1 = new DataAccess.KullaniciBilgi();
                nesne1.KullaniciAd = TextBox3.Text;
                nesne1.KullaniciSoyad = TextBox4.Text;
                nesne1.KullaniciEmail = TextBox5.Text;
                nesne1.KullaniciSifre = TextBox6.Text;
                nesne1.KullaniciRol = DropDownList3.SelectedItem.Text;
                var deger = nesne.VeriEkleme(nesne1);

                Response.Write("<script>alert('Kayıt Başarılı')</script>");
            }

        }

        protected void koltukEkleBtn_Click(object sender, EventArgs e)
        {
            koltuklar.Add(DropDownList5.SelectedValue);
            koltukLabel.Text += DropDownList5.SelectedValue + ",";


        }

        protected void biletAlBtn_Click(object sender, EventArgs e)
        {
            if (Session["emailSession"] != null)
            {


                //Salon
                Proje.Business.Salon sln = new Business.Salon();
                sln.SalonAdi = DropDownList2.SelectedValue;
                var salon = sln.SalonIdGetir();

                //Koltuk



                //Filmler
                Proje.Business.FilmBilgi flm = new Business.FilmBilgi();
                flm.FilmAdi = DropDownList1.SelectedValue;
                var film = flm.FilmIdGetir();

                //Seans
                Proje.Business.Seans sns = new Business.Seans();
                sns.SeansSaati = DropDownList6.SelectedValue;
                var seanssaati = sns.SeansIdGetir();

                //Kullanici
                Proje.Business.KullaniciBilgi klnc = new Business.KullaniciBilgi();
                var kullanici = klnc.EmailIdGetir(Session["emailSession"].ToString());


                foreach (var koltukno in koltuklar)
                {
                    Proje.Business.Koltuk klt = new Business.Koltuk();
                    klt.KoltukNo = koltukno;
                    var koltuk = klt.KoltukIdGetir();

                    Proje.Business.BiletAl biletOlustur = new Business.BiletAl();
                    biletOlustur.BiletAdi = "";
                    biletOlustur.FilmIdFK = film.FilmId;
                    biletOlustur.KoltukIdFK = koltuk.KoltukId;
                    biletOlustur.SeansIdFK = seanssaati.SeansId;
                    biletOlustur.SalonIdFK = salon.SalonId;
                    biletOlustur.KullaniciIdFK = kullanici.KullaniciId;
                    biletOlustur.BiletEkle();

                }
                Response.Write("<script>alert('Bilgileriniz Kaydedildi')</script>");
            }
            else
            {
                Response.Write("<script>alert('Lütfen Giriş Yapınız.')</script>");
            }
        }
    }
}