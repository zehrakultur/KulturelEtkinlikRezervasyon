using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje.Business
{
    public class Salon
    {
        public string SalonAdi { get; set; }

        public List<Proje.DataAccess.Salon> Listele()
        {
            Proje.DataAccess.KulturelEtkinlikEntities1 ent = new DataAccess.KulturelEtkinlikEntities1();
            var sonuc = ent.Salon.ToList();
            return sonuc;
        }

        public Proje.DataAccess.Salon SalonIdGetir()
        {
            Proje.DataAccess.KulturelEtkinlikEntities1 ent = new DataAccess.KulturelEtkinlikEntities1();
            var salon = ent.Salon.Where(r => r.SalonAdi == SalonAdi).FirstOrDefault();
            return salon;
        }
    }
}
