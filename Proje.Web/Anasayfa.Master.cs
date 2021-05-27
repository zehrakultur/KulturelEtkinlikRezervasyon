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
        protected void Page_Load(object sender, EventArgs e)

        {
            Proje.Business.FilmBilgi filmAdiBilgi = new Business.FilmBilgi();
            var sonuc = filmAdiBilgi.FilmAdiBilgi();
            DropDownList1.DataSource = sonuc;
            DropDownList1.DataBind();

            Proje.Business.Salon salonAdi = new Business.Salon();
            var salonSonuc = salonAdi.Listele();
            DropDownList2.DataSource = salonSonuc;
            DropDownList2.DataBind();

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Proje.Business.KullaniciBilgi kullaniciGiris = new Business.KullaniciBilgi();
            var sonuc = kullaniciGiris.Listele();
            GridView1.DataSource = sonuc;
            GridView1.DataBind();

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BE850R5;Initial Catalog=KulturelEtkinlik;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from KullaniciBilgi Where KullaniciEmail='" + TextBox1.Text + "' and KullaniciSifre='" + TextBox2.Text + "' and KullaniciRol='" + DropDownList4.SelectedItem.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                Session["KullaniciEmail"] = dr["KullaniciEmail"].ToString();
                if (DropDownList4.SelectedItem.Text == "Yönetici")
                {
                    Response.Redirect("Yonetici.aspx");
                }
                else
                    Response.Redirect("Default.aspx");
            }

            if (dr.Read())
            {
                Session["KullaniciEmail"] = dr["KullaniciEmail"].ToString();

                Response.Redirect("Default.aspx");

            }



            if (TextBox1.Text == String.Empty || TextBox2.Text == String.Empty || TextBox3.Text == String.Empty || TextBox4.Text == String.Empty || DropDownList4.SelectedItem.Text == String.Empty)
            {
                Response.Write("<script>alert('Lütfen Boş Alanları Doldurunuz')</script>");
            }
            else

            {
                Response.Write("<script>alert('Giriş Başarılı')</script>");
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
    }
}