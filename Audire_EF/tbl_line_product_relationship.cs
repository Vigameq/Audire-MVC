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
    
    public partial class tbl_line_product_relationship
    {
        public int line_product_rel_id { get; set; }
        public Nullable<int> product_id { get; set; }
        public Nullable<int> line_id { get; set; }
        public Nullable<int> location_id { get; set; }
        public Nullable<int> country_id { get; set; }
        public Nullable<int> region_id { get; set; }
        public Nullable<int> no_of_shifts { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public string notification_sent_flag { get; set; }
    }
}
