//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Business_Type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Business_Type()
        {
            this.Company_Code = new HashSet<Company_Code>();
        }
    
        public int AY_Business_Type_Id { get; set; }
        public Nullable<int> AY_ENV_ID { get; set; }
        public string AY_F_BUST_TYPE { get; set; }
        public Nullable<int> AY_F_LANG_ID { get; set; }
        public string AY_F_LANG_CODE { get; set; }
        public string AY_F_BUST_TEXT { get; set; }
        public string AY_F_CREATE_DATE { get; set; }
        public string AY_F_CREATE_TIME { get; set; }
        public Nullable<int> AY_F_CREATED_BY { get; set; }
        public string AY_F_LAST_CHG_DATE { get; set; }
        public string AY_F_LAST_CNG_TIME { get; set; }
        public Nullable<int> AY_F_LAST_CHG_BY { get; set; }
    
        public virtual Language Language { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Company_Code> Company_Code { get; set; }
    }
}
