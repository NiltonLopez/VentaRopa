//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pApp_Serv_WEB.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblDepartamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDepartamento()
        {
            this.tblCiudads = new HashSet<tblCiudad>();
        }
    
        public int idDepartamento { get; set; }
        public string nombreDepartamento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCiudad> tblCiudads { get; set; }
    }
}
