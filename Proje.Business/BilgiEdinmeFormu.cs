using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje.Business
{
    public class BilgiEdinmeFormu
    {

        public string AdSoyad { get; set; }
        public string Email { get; set; }
        public string Mesaj { get; set; }
        public string Telefon { get; set; }

        public List<Proje.DataAccess.BilgiEdinmeFormu> Listele()
        {
            Proje.DataAccess.KulturelEtkinlikEntities1 ent = new DataAccess.KulturelEtkinlikEntities1();
            var sonuc = ent.BilgiEdinmeFormu.ToList();
            return sonuc;
        }


        public string MesajEkle(Proje.DataAccess.BilgiEdinmeFormu bilgiMesaj)
        {
            Proje.DataAccess.KulturelEtkinlikEntities1 ekleme = new DataAccess.KulturelEtkinlikEntities1();
            Proje.DataAccess.BilgiEdinmeFormu yeni = new DataAccess.BilgiEdinmeFormu();

            yeni.AdSoyad = bilgiMesaj.AdSoyad;
            yeni.Email = bilgiMesaj.Email;
            yeni.Mesaj = bilgiMesaj.Mesaj;
            yeni.Telefon = bilgiMesaj.Telefon;
            ekleme.BilgiEdinmeFormu.Add(yeni);
            ekleme.SaveChanges();
            var verileriGetir = Listele();

            return "1";
        }
    }
}
