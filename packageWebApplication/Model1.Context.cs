﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace packageWebApplication
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ApplicationDatabaseEntities3 : DbContext
    {
        public ApplicationDatabaseEntities3()
            : base("name=ApplicationDatabaseEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PackageList> PackageLists { get; set; }
        public virtual DbSet<PackageTable> PackageTables { get; set; }
        public virtual DbSet<ResidentTable> ResidentTables { get; set; }
    }
}
