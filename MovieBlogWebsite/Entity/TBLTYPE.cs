//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieBlogWebsite.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLTYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLTYPE()
        {
            this.TBLBLOG = new HashSet<TBLBLOG>();
        }
    
        public byte TYPEID { get; set; }
        public string TYPENAME { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLBLOG> TBLBLOG { get; set; }
    }
}
