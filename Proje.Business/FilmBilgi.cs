using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class FilmBilgi
    {

        public string FilmAdi { get; set; }
        public int FilmTurIdFK { get; set; }
        public string FilmYonetmeni { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public string Sure { get; set; }

        public List<Proje.DataAccess.Filmler> Listele()
        {
            Proje.DataAccess.KulturelEtkinlikEntities1 ent = new DataAccess.KulturelEtkinlikEntities1();
            var sonuc = ent.Filmler.ToList();
            return sonuc;
        }

        public Proje.DataAccess.Filmler Next()
        {
            Proje.DataAccess.KulturelEtkinlikEntities1 entF = new DataAccess.KulturelEtkinlikEntities1();
            var sonuc = entF.Filmler.OrderByDescending(p => p.FilmId);
            return sonuc.FirstOrDefault();
        }

        public Proje.DataAccess.Filmler Prev()
        {
            Proje.DataAccess.KulturelEtkinlikEntities1 entF = new DataAccess.KulturelEtkinlikEntities1();
            var sonuc = entF.Filmler.OrderBy(p => p.FilmId);
            return sonuc.FirstOrDefault();
        }

        public List<Proje.DataAccess.Filmler> TumFilmler()
        {
            Proje.DataAccess.KulturelEtkinlikEntities1 tum = new DataAccess.KulturelEtkinlikEntities1();
            var sonuc = tum.Filmler.ToList();
            return sonuc;
        }
    }
}
