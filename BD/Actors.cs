//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UchetProsmotrennichFilmov.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Actors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Actors()
        {
            this.Films = new HashSet<Films>();
        }
    
        public int IdActors { get; set; }
        public string FIO { get; set; }
        public byte[] ImageActor { get; set; }
        public System.DateTime DR { get; set; }
        public int StranaId { get; set; }
    
        public virtual Strany Strany { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Films> Films { get; set; }
    }
}
