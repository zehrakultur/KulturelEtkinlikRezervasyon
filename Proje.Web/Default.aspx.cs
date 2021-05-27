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


            

            var next= filmVeri.Next();

            filmNextAdi.Text = next.FilmAdi;
            filmNextYonetmen.Text = next.FilmYonetmeni;
            filmNextAciklama.Text = next.Aciklama;
            nextSure.Text = next.Sure;
            nextImage.ImageUrl = "Tasarim/assets/img/"+next.Resim+"";


            var prev = filmVeri.Prev();

            filmPrevAdi.Text = prev.FilmAdi;
            filmYonetmenPrev.Text = prev.FilmYonetmeni;
            filmPrevAciklama.Text = prev.Aciklama;
            prevSure.Text = prev.Sure;
            prevImage.ImageUrl = "Tasarim/assets/img/" + prev.Resim + "";


        }


    }



}