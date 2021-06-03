using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Proje.Business
{
    public class Servis
    {
        public List<string> ServisGetir()
        {
            var servis = new Proje.Web.WebServis.test().AdlariListe(25);
            return servis;
        }
    }
}
