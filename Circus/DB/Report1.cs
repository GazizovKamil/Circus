//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Circus.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Report1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Report1()
        {
            this.Perfomance_Report1 = new HashSet<Perfomance_Report1>();
        }
    
        public int ID { get; set; }
        public Nullable<decimal> Profit { get; set; }
        public Nullable<decimal> Expenses { get; set; }
        public string ID_Type { get; set; }
        public string Month { get; set; }
        public Nullable<int> Year { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Perfomance_Report1> Perfomance_Report1 { get; set; }
    }
}