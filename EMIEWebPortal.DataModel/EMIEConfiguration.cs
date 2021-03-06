//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMIEWebPortal.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMIEConfiguration
    {
        public int Id { get; set; }
        public string SandboxEnvironment { get; set; }
        public string SandboxUserName { get; set; }
        public string SandboxPassword { get; set; }
        public string ProductionEnvironment { get; set; }
        public string ProductionUserName { get; set; }
        public string ProductionPassword { get; set; }
        public Nullable<System.DateTime> FreezeProductionChangeStartDate { get; set; }
        public Nullable<System.DateTime> FreezeProductionChangeEndDate { get; set; }
        public Nullable<int> CreatedById { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedById { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string SandboxUserDomain { get; set; }
        public string ProductionUserDomain { get; set; }
    }
}
