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
    
    public partial class VIEWDiscount
    {
        public int ID { get; set; }
        public string Наименование { get; set; }
        public float Значение_скидки { get; set; }
        public Nullable<System.DateTime> Начало_скидки { get; set; }
        public Nullable<System.DateTime> Окончание_скидки { get; set; }
    }
}
