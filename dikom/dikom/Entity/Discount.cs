//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dikom.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Discount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Discount()
        {
            this.Shipping_Specification = new HashSet<Shipping_Specification>();
        }
    
        public int discount_id { get; set; }
        public Nullable<System.DateTime> start_discounts_date { get; set; }
        public Nullable<System.DateTime> end_discounts_date { get; set; }
        public string discounts_name { get; set; }
        public float discount_value { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shipping_Specification> Shipping_Specification { get; set; }
    }
}