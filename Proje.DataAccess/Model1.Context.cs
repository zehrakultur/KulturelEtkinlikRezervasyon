﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KulturelEtkinlikEntities1 : DbContext
    {
        public KulturelEtkinlikEntities1()
            : base("name=KulturelEtkinlikEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bilet> Bilet { get; set; }
        public virtual DbSet<Filmler> Filmler { get; set; }
        public virtual DbSet<Koltuk> Koltuk { get; set; }
        public virtual DbSet<KullaniciBilgi> KullaniciBilgi { get; set; }
        public virtual DbSet<Salon> Salon { get; set; }
        public virtual DbSet<Seans> Seans { get; set; }
        public virtual DbSet<Turler> Turler { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<FilmSeans> FilmSeans { get; set; }
        public virtual DbSet<SalonSeans> SalonSeans { get; set; }
    }
}
