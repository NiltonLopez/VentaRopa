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
    
    public partial class tblTalla
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTalla()
        {
            this.tblPrendas = new HashSet<tblPrenda>();
        }
    
        public int idTalla { get; set; }
        public string nombreTalla { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPrenda> tblPrendas { get; set; }
    }
}
