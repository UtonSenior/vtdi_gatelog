﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vtdi_gate
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class vtdi_gatelog_dbEntities : DbContext
    {
        public vtdi_gatelog_dbEntities()
            : base("name=vtdi_gatelog_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblGateInOut> tblGateInOuts { get; set; }
        public virtual DbSet<tblGender> tblGenders { get; set; }
        public virtual DbSet<tblItemsToDeclare> tblItemsToDeclares { get; set; }
        public virtual DbSet<tblPurposeOfVisit> tblPurposeOfVisits { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<tblVehicleType> tblVehicleTypes { get; set; }
    }
}
