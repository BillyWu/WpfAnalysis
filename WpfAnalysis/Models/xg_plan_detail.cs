using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class xg_plan_detail
    {
        public int plan_no { get; set; }
        public Nullable<int> line_no { get; set; }
        public Nullable<int> node_no { get; set; }
        public string door_sn { get; set; }
        public string node_name { get; set; }
        public string door_readno { get; set; }
        public Nullable<System.DateTime> Start_dt { get; set; }
        public Nullable<System.DateTime> End_dt { get; set; }
    }
}
