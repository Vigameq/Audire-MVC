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
    
    public partial class tbl_user_master
    {
        public int user_id { get; set; }
        public string username { get; set; }
        public string passwd { get; set; }
        public string emp_full_name { get; set; }
        public string display_name_flag { get; set; }
        public string email_id { get; set; }
        public Nullable<int> location_id { get; set; }
        public string role { get; set; }
        public string global_admin_flag { get; set; }
        public string site_admin_flag { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public Nullable<int> role_id { get; set; }
        public Nullable<int> region_id { get; set; }
        public Nullable<int> country_id { get; set; }
        public string emp_first_name { get; set; }
        public string emp_last_name { get; set; }
        public string Admin_Type { get; set; }
        public string process_id { get; set; }
        public string module_id { get; set; }
        public Nullable<int> reporting_manager { get; set; }
        public string profile_pic { get; set; }
    }
}
