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
    public partial class Iletisim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Proje.Business.BilgiEdinmeFormu mesajBilgi = new Business.BilgiEdinmeFormu();
            var sonuc = mesajBilgi.Listele();
            GridView1.DataSource = sonuc;
            GridView1.DataBind();

            //Veri ekleme entity
            Proje.Business.BilgiEdinmeFormu nesne = new Business.BilgiEdinmeFormu();
            Proje.DataAccess.BilgiEdinmeFormu nesne1 = new DataAccess.BilgiEdinmeFormu();
            nesne1.AdSoyad = TextBox1.Text;
            nesne1.Email = TextBox2.Text;
            nesne1.Telefon = TextBox3.Text;
            nesne1.Mesaj=TextBox4.Text;
            var deger = nesne.MesajEkle(nesne1);

        }
    }
}