﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TLR_EDI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EDISecureCoreEntities : DbContext
    {
        public EDISecureCoreEntities()
            : base("name=EDISecureCoreEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agency> Agencies { get; set; }
        public virtual DbSet<Factory> Factories { get; set; }
        public virtual DbSet<OperationalArea> OperationalAreas { get; set; }
        public virtual DbSet<OrderInfo> OrderInfoes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrdersDetail> OrdersDetails { get; set; }
        public virtual DbSet<Planet> Planets { get; set; }
        public virtual DbSet<Priority> Priorities { get; set; }
        public virtual DbSet<Reference> References { get; set; }
    }
}
