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
    
    public partial class tbl_local_question_master
    {
        public int local_question_id { get; set; }
        public Nullable<int> location_id { get; set; }
        public Nullable<int> section_id { get; set; }
        public string local_question { get; set; }
        public string local_help_text { get; set; }
        public Nullable<int> display_sequence { get; set; }
        public string how_to_check { get; set; }
        public string na_flag { get; set; }
        public Nullable<int> max_no_of_pics_allowed { get; set; }
    }
}
