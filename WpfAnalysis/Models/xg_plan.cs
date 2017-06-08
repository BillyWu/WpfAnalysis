using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class xg_plan
    {
        public int plan_no { get; set; }
        public int line_no { get; set; }
        public Nullable<System.DateTime> Start_dt { get; set; }
        public Nullable<System.DateTime> End_dt { get; set; }
        public Nullable<int> IsSeq { get; set; }
    }
}
