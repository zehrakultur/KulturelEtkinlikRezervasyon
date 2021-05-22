using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace Proje.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Proje.Business.FilmBilgi filmVeri = new Proje.Business.FilmBilgi();

            rptFilm.DataSource = filmVeri.Listele();
            rptFilm.DataBind();

            //Image1.ImageUrl("Tasarim/assets/img/social.jpg");

            //filmVeri.Next().filmNextAciklama;

        }
    }
}