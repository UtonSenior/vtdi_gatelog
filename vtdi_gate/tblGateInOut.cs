//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tblGateInOut
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PlateNumber { get; set; }
        public Nullable<System.DateTime> DateTimeIn { get; set; }
        public Nullable<System.DateTime> DateTimeOut { get; set; }
        public int VehicleTypeId { get; set; }
        public int PurposeId { get; set; }
        public int ItemsToDeclareId { get; set; }
        public int UserId { get; set; }
    
        public virtual tblItemsToDeclare tblItemsToDeclare { get; set; }
        public virtual tblPurposeOfVisit tblPurposeOfVisit { get; set; }
        public virtual tblUser tblUser { get; set; }
        public virtual tblVehicleType tblVehicleType { get; set; }
    }
}
