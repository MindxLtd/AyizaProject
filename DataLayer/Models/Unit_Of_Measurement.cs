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
    
    public partial class Unit_Of_Measurement
    {
        public int AY_Unit_Of_Measurement_Id { get; set; }
        public Nullable<int> AY_ENV_ID { get; set; }
        public string AY_UOM_CODE { get; set; }
        public Nullable<int> AY_F_LANG_ID { get; set; }
        public string AY_F_LANG_CODE { get; set; }
        public string AY_UOM_TEXT { get; set; }
        public string AY_F_UOM_DIM { get; set; }
        public string AY_F_UOM_ISO { get; set; }
        public Nullable<int> AY_F_UOM_COMV { get; set; }
        public Nullable<int> AY_F_UOM_TECV { get; set; }
        public Nullable<int> AY_F_CURR_DECP { get; set; }
        public string AY_F_CREATE_DATE { get; set; }
        public string AY_F_CREATE_TIME { get; set; }
        public Nullable<int> AY_F_CREATED_BY { get; set; }
        public string AY_F_LAST_CHG_DATE { get; set; }
        public string AY_F_LAST_CNG_TIME { get; set; }
        public Nullable<int> AY_F_LAST_CHG_BY { get; set; }
    
        public virtual Language Language { get; set; }
    }
}
