//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proje.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class FilmSeans
    {
        public int FilmSeansId { get; set; }
        public Nullable<int> FilmIdFK { get; set; }
        public Nullable<int> SeansIdFK { get; set; }
    
        public virtual Filmler Filmler { get; set; }
        public virtual Seans Seans { get; set; }
    }
}
