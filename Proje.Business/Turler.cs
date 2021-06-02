using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class Turler
    {
        public string TurAdi { get; set; }

        public List<Proje.DataAccess.Turler> TurListele()
        {
            Proje.DataAccess.KulturelEtkinlikEntities1 tur = new DataAccess.KulturelEtkinlikEntities1();
            var sonuc = tur.Turler.ToList();
            return sonuc;
        }


        public Proje.DataAccess.Turler TurNext()
        {

            Proje.DataAccess.KulturelEtkinlikEntities1 entF = new DataAccess.KulturelEtkinlikEntities1();
            var sonuc = entF.Turler.OrderBy(p => p.TurId);
            return sonuc.FirstOrDefault();

        }

        public Proje.DataAccess.Turler TurPrev()
        {
            Proje.DataAccess.KulturelEtkinlikEntities1 entF = new DataAccess.KulturelEtkinlikEntities1();
            var sonuc = entF.Turler.OrderByDescending(p => p.TurId);
            return sonuc.FirstOrDefault();
        }
    }
}
