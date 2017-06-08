using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class park
    {
        public int park_no { get; set; }
        public string park_name { get; set; }
        public Nullable<int> park_type { get; set; }
        public Nullable<int> belong_to { get; set; }
        public Nullable<int> all_stall { get; set; }
        public Nullable<int> free_stall { get; set; }
        public string remark { get; set; }
    }
}
