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
    
    public partial class Turnirs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Turnirs()
        {
            this.Matches = new HashSet<Matches>();
            this.Turnir_tables = new HashSet<Turnir_tables>();
        }
    
        public int Id_turnir { get; set; }
        public string Name_turnir { get; set; }
        public string Name_Game { get; set; }
        public string Format_turnir { get; set; }
        public Nullable<System.DateTime> Date_Begin_turnirs { get; set; }
        public Nullable<int> Priz_fond { get; set; }
        public string kol_vo_player { get; set; }
        public int Id_status_turnir { get; set; }
        public Nullable<int> Id_org { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matches> Matches { get; set; }
        public virtual Organizator Organizator { get; set; }
        public virtual Status_turnir Status_turnir { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Turnir_tables> Turnir_tables { get; set; }
    }
}