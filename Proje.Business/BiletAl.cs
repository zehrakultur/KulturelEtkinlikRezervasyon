using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class BiletAl
    {
        public string BiletAdi { get; set; }
        public int FilmIdFK { get; set; }
        public int KoltukIdFK { get; set; }
        public int SalonIdFK { get; set; }
        public int SeansIdFK { get; set; }
        public int KullaniciIdFK { get; set; }


        public List<Proje.DataAccess.Bilet> DoluKoltukGetir(int salonId)
        {
            Proje.DataAccess.KulturelEtkinlikEntities1 bilet = new DataAccess.KulturelEtkinlikEntities1();
            var sonuc = bilet.Bilet.Where(r=> r.SalonIdFK == salonId).ToList();
            return sonuc;
        }

        public int BiletEkle()
        {
            Proje.DataAccess.KulturelEtkinlikEntities1 ent = new DataAccess.KulturelEtkinlikEntities1();
            Proje.DataAccess.Bilet bilet = new DataAccess.Bilet();
            bilet.BiletAdi = BiletAdi;
            bilet.FilmIdFK = FilmIdFK;
            bilet.KoltukIdFK = KoltukIdFK;
            bilet.SalonIdFK = SalonIdFK;
            bilet.SeansIdFK = SeansIdFK;
            bilet.KullaniciIdFK = KullaniciIdFK;
            ent.Bilet.Add(bilet);
            var sonuc = ent.SaveChanges();
            return sonuc;
        }

        
    }
}
