//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PI_POCETAK.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class poslovni_partner
    {
        public poslovni_partner()
        {
            this.narudzbenica = new HashSet<narudzbenica>();
        }
    
        public int id_poslovni_partner { get; set; }
        public string naziv { get; set; }
        public string ziro_racun { get; set; }
        public string tel_broj { get; set; }
        public string email { get; set; }
    
        public virtual ICollection<narudzbenica> narudzbenica { get; set; }
    }
}
