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
    
    public partial class tblCajero
    {
        public string idCajero { get; set; }
        public string NombreCajero { get; set; }
        public System.DateTime fechaCajero { get; set; }
        public long TelefonoCajero { get; set; }
        public string EmailCajero { get; set; }
        public int TipoDocumentoCajero { get; set; }
    
        public virtual tblTipoDocuman tblTipoDocuman { get; set; }
    }
}
