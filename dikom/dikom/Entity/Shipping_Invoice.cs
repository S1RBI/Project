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
    
    public partial class Shipping_Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shipping_Invoice()
        {
            this.Shipping_Specification = new HashSet<Shipping_Specification>();
            this.Shipping_Specification1 = new HashSet<Shipping_Specification>();
        }
    
        public int shipping_invoice_id { get; set; }
        public Nullable<int> vat_id { get; set; }
        public int delivery_contract_id { get; set; }
        public string login_id { get; set; }
        public System.DateTime departure_date { get; set; }
    
        public virtual Delivery_Contract Delivery_Contract { get; set; }
        public virtual Storekeeper Storekeeper { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shipping_Specification> Shipping_Specification { get; set; }
        public virtual VAT VAT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shipping_Specification> Shipping_Specification1 { get; set; }
    }
}