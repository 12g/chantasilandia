﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Juegos.DALC
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ChantasilandiaEntities1 : DbContext
    {
        public ChantasilandiaEntities1()
            : base("name=ChantasilandiaEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Cuentas> Cuentas { get; set; }
        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Juegos> Juegos { get; set; }
        public DbSet<JuegosCasuales> JuegosCasuales { get; set; }
        public DbSet<JuegosExtremos> JuegosExtremos { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
    }
}
