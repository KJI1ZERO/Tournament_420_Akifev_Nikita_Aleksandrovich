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
    
    public partial class Players
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Players()
        {
            this.Matches = new HashSet<Matches>();
            this.Turnir_tables = new HashSet<Turnir_tables>();
        }
    
        public int Id_player { get; set; }
        public string Nickname { get; set; }
        public string Phone { get; set; }
        public string Rang { get; set; }
        public string Role { get; set; }
        public Nullable<int> kol_vo_matches { get; set; }
        public Nullable<int> kol_vo_win { get; set; }
        public Nullable<int> kol_vo_lose { get; set; }
        public Nullable<int> kol_vo_mvp { get; set; }
        public string NameCommand { get; set; }
        public string Game { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matches> Matches { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Turnir_tables> Turnir_tables { get; set; }
    }
}