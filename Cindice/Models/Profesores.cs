//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cindice.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profesores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Profesores()
        {
            this.Asignatura = new HashSet<Asignatura>();
        }
    
        public int ProfesoresId { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asignatura> Asignatura { get; set; }
    }
}
