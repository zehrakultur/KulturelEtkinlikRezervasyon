using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class Seans
    {
        public string SeansSaati { get; set; }


        public List<Proje.DataAccess.Seans> SeansListele()
        {
            Proje.DataAccess.KulturelEtkinlikEntities1 seans = new DataAccess.KulturelEtkinlikEntities1();
            var sonuc = seans.Seans.ToList();
            return sonuc;
        }
        public Proje.DataAccess.Seans SeansIdGetir()
        {
            Proje.DataAccess.KulturelEtkinlikEntities1 entSeans = new DataAccess.KulturelEtkinlikEntities1();
            var seans = entSeans.Seans.Where(r => r.SeansSaati == SeansSaati).FirstOrDefault();
            return seans;
        }
    }
}
