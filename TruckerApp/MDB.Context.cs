﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TruckerApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TruckersEntities : DbContext
    {
        public TruckersEntities()
            : base("name=TruckersEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Commission> Commissions { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<LoadType> LoadTypes { get; set; }
        public virtual DbSet<Queue> Queues { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Cash> Cashes { get; set; }
        public virtual DbSet<SeriesPrice> SeriesPrices { get; set; }
    }
}
