//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Commission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Commission()
        {
            this.Queues = new HashSet<Queue>();
        }
    
        public short CommissionID { get; set; }
        public byte Groups_FK { get; set; }
        public int CommissionPrice { get; set; }
        public System.DateTime DataRegister { get; set; }
        public bool enabled { get; set; }
        public byte GroupID { get; set; }
    
        public virtual LoadType LoadType { get; set; }
        public virtual LoadType LoadType1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Queue> Queues { get; set; }
    }
}
