using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Proje.Web
{
    public partial class Test1 : System.Web.UI.Page
    {
        static public List<Proje.Business.KullaniciBilgi> kullaniciListeleri = new List<Business.KullaniciBilgi>();

        protected void Page_Load(object sender, EventArgs e)
        {
            

            int[] sayilar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //QUERY
            var sonuc = from sayi in sayilar where sayi > 5 select sayi;
            //foreach(var item in sonuc)
           // {
           //     lst.Items.Add(item.ToString());
            //}
            //Method ile
            List<int> sonuc1 = sayilar.Where(p => p > 5).ToList();


            for(int i=0; i<3; i++)
            {
                Proje.Business.KullaniciBilgi kullanici = new Business.KullaniciBilgi();
            }
            
        }

    }
}