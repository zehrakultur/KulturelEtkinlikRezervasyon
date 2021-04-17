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

        public List<Proje.DataAccess.KullaniciBilgi> Listele()
        {
            Proje.DataAccess.KulturelEtkinlikEntities1 ent = new DataAccess.KulturelEtkinlikEntities1();
            //ent.Database.Connection.Open();
            var sonuc = ent.KullaniciBilgi.ToList();
            return sonuc;
        }
    }
}
