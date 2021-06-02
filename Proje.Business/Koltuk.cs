using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class Koltuk
    {

        public string KoltukNo { get; set; }

        public List<Proje.DataAccess.Koltuk> KoltukListele()
        {
            Proje.DataAccess.KulturelEtkinlikEntities1 koltuk = new DataAccess.KulturelEtkinlikEntities1();
            var sonuc = koltuk.Koltuk.ToList();
            return sonuc;
        }

        public Proje.DataAccess.Koltuk KoltukIdGetir()
        {
            Proje.DataAccess.KulturelEtkinlikEntities1 ent = new DataAccess.KulturelEtkinlikEntities1();
            var koltuk = ent.Koltuk.Where(r => r.KoltukNo == KoltukNo).FirstOrDefault();
            return koltuk;
        }
    }
}
