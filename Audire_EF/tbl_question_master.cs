//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Audire_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_question_master
    {
        public int id { get; set; }
        public int question_id { get; set; }
        public Nullable<int> section_id { get; set; }
        public string question { get; set; }
        public Nullable<int> module_id { get; set; }
        public Nullable<int> Audit_type_id { get; set; }
        public Nullable<int> sub_section_id { get; set; }
        public string section_name { get; set; }
        public string sub_section_name { get; set; }
        public string help_text { get; set; }
        public string clause { get; set; }
    }
}
