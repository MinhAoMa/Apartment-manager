//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apartment_manager_app
{
    using System;
    using System.Collections.Generic;
    
    public partial class canho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public canho()
        {
            this.dancus = new HashSet<dancu>();
        }
    
        public string Macanho { get; set; }
        public string dientich { get; set; }
        public string loaicanho { get; set; }
        public string gia { get; set; }
        public string trangthai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dancu> dancus { get; set; }
    }
}
