//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_USERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_USERS()
        {
            this.T_TASKS = new HashSet<T_TASKS>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public string EMAIL { get; set; }
        public string PASSWORD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TASKS> T_TASKS { get; set; }
        public virtual T_USERS T_USERS1 { get; set; }
        public virtual T_USERS T_USERS2 { get; set; }
    }
}
