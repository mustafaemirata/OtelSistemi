﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtelSistemi.Entitiy
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbOtelEntities1 : DbContext
    {
        public DbOtelEntities1()
            : base("name=DbOtelEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tbl_Birim> Tbl_Birim { get; set; }
        public virtual DbSet<Tbl_Departman> Tbl_Departman { get; set; }
        public virtual DbSet<Tbl_Durum> Tbl_Durum { get; set; }
        public virtual DbSet<Tbl_Gorev> Tbl_Gorev { get; set; }
        public virtual DbSet<Tbl_Kasa> Tbl_Kasa { get; set; }
        public virtual DbSet<Tbl_Kur> Tbl_Kur { get; set; }
        public virtual DbSet<Tbl_Misafir> Tbl_Misafir { get; set; }
        public virtual DbSet<Tbl_Oda> Tbl_Oda { get; set; }
        public virtual DbSet<Tbl_Personel> Tbl_Personel { get; set; }
        public virtual DbSet<Tbl_Telefon> Tbl_Telefon { get; set; }
        public virtual DbSet<Tbl_Ulke> Tbl_Ulke { get; set; }
        public virtual DbSet<Tbl_Urun> Tbl_Urun { get; set; }
        public virtual DbSet<Tbl_UrunGrup> Tbl_UrunGrup { get; set; }
    }
}
