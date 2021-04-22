using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje.Business
{
    public class KullaniciBilgi
    {
        
        public string KullaniciAd { get; set; }
        public string KullaniciSoyad { get; set; }
        public string KullaniciEmail { get; set; }
        public string KullaniciSifre { get; set; }

        //Entity Framework

        public List<Proje.DataAccess.KullaniciBilgi> Listele()
        {
            Proje.DataAccess.KulturelEtkinlikEntities1 ent = new DataAccess.KulturelEtkinlikEntities1();
            //ent.Database.Connection.Open();
            var sonuc = ent.KullaniciBilgi.ToList();

            //Baştan Sona Doğru Sıralama
            //var sonuc1 = ent.KullaniciBilgi.OrderBy(p=> p.KullaniciAd).ToList();

            //Sondan Başa Doğru Sıralama
            //var sonuc2 = ent.KullaniciBilgi.OrderByDescending(p => p.KullaniciAd).ToList();
            return sonuc;
        }





        public Proje.DataAccess.KullaniciBilgi GetById(string KullaniciAd)
        {
            Proje.DataAccess.KulturelEtkinlikEntities1 ent = new DataAccess.KulturelEtkinlikEntities1();

            var sonuc = ent.KullaniciBilgi.Where(p => p.KullaniciAd == KullaniciAd);
            return sonuc.FirstOrDefault();
        }

        //Entity Framework Veri Ekleme
        public string VeriEkleme(Proje.DataAccess.KullaniciBilgi nesne)
        {
            //Proje.DataAccess.KulturelEtkinlikEntities1 ekleme = new DataAccess.KulturelEtkinlikEntities1();
            //Proje.DataAccess.KullaniciBilgi yeni = new DataAccess.KullaniciBilgi();

            //yeni.KullaniciAd = nesne.KullaniciAd;
            //yeni.KullaniciSoyad = nesne.KullaniciSoyad;
            //yeni.KullaniciEmail = nesne.KullaniciEmail;
            //yeni.KullaniciSifre = nesne.KullaniciSifre;
            //ekleme.KullaniciBilgi.Add(yeni);
            //ekleme.SaveChanges();
            //var verileriGetir = Listele();


            //yeni.KullaniciAd = "Ayşe";
            //yeni.KullaniciSoyad = "Kim";
            //yeni.KullaniciEmail = "aysekim@gmail.com";
            //yeni.KullaniciSifre = "12345";
            //ekleme.KullaniciBilgi.Add(yeni);
            //ekleme.SaveChanges();
            //var verileriGetir = Listele();

            return "1";
        }
        //Entity Framework Veri Güncelleme
        public string VeriGuncelleme(string KullaniciSifre, Proje.DataAccess.KullaniciBilgi nesne)
        {
            Proje.DataAccess.KulturelEtkinlikEntities1 ekleme = new DataAccess.KulturelEtkinlikEntities1();
            Proje.DataAccess.KullaniciBilgi yeni = new DataAccess.KullaniciBilgi();
            var aranan = ekleme.KullaniciBilgi.Where(p => p.KullaniciSifre == KullaniciSifre).FirstOrDefault();

            aranan.KullaniciAd = nesne.KullaniciAd;
            aranan.KullaniciSoyad = nesne.KullaniciSoyad;
            aranan.KullaniciEmail = nesne.KullaniciEmail;
            
            //ekleme.KullaniciBilgi.Add(aranan);
            ekleme.SaveChanges();
            var verileriGetir = Listele();


            

            return "1";
        }
        //Entity Framework Veri Silme
        public string VeriSilme(string KullaniciSifre, Proje.DataAccess.KullaniciBilgi nesne)
        {
            Proje.DataAccess.KulturelEtkinlikEntities1 ekleme = new DataAccess.KulturelEtkinlikEntities1();
            Proje.DataAccess.KullaniciBilgi yeni = new DataAccess.KullaniciBilgi();
            var aranan = ekleme.KullaniciBilgi.Where(p => p.KullaniciSifre == KullaniciSifre).FirstOrDefault();

            aranan.KullaniciAd = nesne.KullaniciAd;
            aranan.KullaniciSoyad = nesne.KullaniciSoyad;
            aranan.KullaniciEmail = nesne.KullaniciEmail;

            ekleme.KullaniciBilgi.Remove(aranan);
            ekleme.SaveChanges();
            var verileriGetir = Listele();




            return "1";
        }
    }
}
