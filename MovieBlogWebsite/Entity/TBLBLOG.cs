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
    
    public partial class TBLBLOG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLBLOG()
        {
            this.TBLCOMMENT = new HashSet<TBLCOMMENT>();
        }
    
        public int BLOGID { get; set; }
        public string BLOGTITTLE { get; set; }
        public string BLOGCONTENT { get; set; }
        public Nullable<System.DateTime> BLOGDATE { get; set; }
        public string BLOGIMAGE { get; set; }
        public Nullable<byte> BLOGTYPE { get; set; }
        public Nullable<byte> BLOGCATEGORY { get; set; }
    
        public virtual TBLCATEGORY TBLCATEGORY { get; set; }
        public virtual TBLTYPE TBLTYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCOMMENT> TBLCOMMENT { get; set; }
    }
}
