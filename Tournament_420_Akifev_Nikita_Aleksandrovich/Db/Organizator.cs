//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tournament_420_Akifev_Nikita_Aleksandrovich.Db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Organizator
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organizator()
        {
            this.Turnirs = new HashSet<Turnirs>();
        }
    
        public int Id_org { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string History_proved_matches { get; set; }
        public Nullable<int> Id_dostup { get; set; }
    
        public virtual Level_dostupa Level_dostupa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Turnirs> Turnirs { get; set; }
    }
}