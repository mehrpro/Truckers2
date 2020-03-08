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
    
    public partial class Queue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Queue()
        {
            this.Cashes = new HashSet<Cash>();
        }
    
        public int ID { get; set; }
        public short Number { get; set; }
        public byte GroupCommission { get; set; }
        public byte Type_FK { get; set; }
        public System.DateTime DateTimeRegister { get; set; }
        public int DriverID_FK { get; set; }
        public byte Status_FK { get; set; }
        public short ComosiunID_FK { get; set; }
        public int SeriesID_FK { get; set; }
    
        public virtual Driver Driver { get; set; }
        public virtual LoadType LoadType { get; set; }
        public virtual LoadType LoadType1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cash> Cashes { get; set; }
        public virtual SeriesPrice SeriesPrice { get; set; }
        public virtual Commission Commission { get; set; }
    }
}
