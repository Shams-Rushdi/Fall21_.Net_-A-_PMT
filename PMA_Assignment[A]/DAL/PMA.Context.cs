﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PMAEntities : DbContext
    {
        public PMAEntities()
            : base("name=PMAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Member> Members { get; set; }
        public DbSet<ProjectCategory> ProjectCategories { get; set; }
        public DbSet<Supervisor> Supervisors { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<LoginUser> LoginUsers { get; set; }
    }
}