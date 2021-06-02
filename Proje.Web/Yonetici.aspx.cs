using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje.Web
{
    public partial class Yonetici : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["emailSession"] != null)
            {
                Proje.Business.KullaniciBilgi klnc = new Business.KullaniciBilgi();
                var kullanici = klnc.EmailIdGetir(Session["emailSession"].ToString());
                if (kullanici.KullaniciRol != "Yönetici")
                {
                    Response.Redirect("Default.aspx");
                }

            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
        }
    }
}