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
    
    public partial class TakenBooks
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        public int ReaderID { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
    
        public virtual AllBooks AllBooks { get; set; }
        public virtual Reaaders Reaaders { get; set; }
    }
}