//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab7_VP
{
    using System;
    using System.Collections.Generic;
    
    public partial class AllBooks
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AllBooks()
        {
            this.TakenBooks = new HashSet<TakenBooks>();
        }
    
        public int ID { get; set; }
        public Nullable<int> NameID { get; set; }
        public Nullable<bool> Present { get; set; }
    
        public virtual BookNames BookNames { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TakenBooks> TakenBooks { get; set; }
    }
}
