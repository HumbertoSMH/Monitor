//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class dispositivo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dispositivo()
        {
            this.bitacora = new HashSet<bitacora>();
            this.zonaDispositivo = new HashSet<zonaDispositivo>();
        }
    
        public int id_dispositivo { get; set; }
        public string nombre_dispotivo { get; set; }
        public int id_tipo_dispositivo { get; set; }
        public System.DateTime fecha_alta { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bitacora> bitacora { get; set; }
        public virtual tipoDispositivo tipoDispositivo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zonaDispositivo> zonaDispositivo { get; set; }
    }
}
