using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class lift_info
    {
        public int lift_no { get; set; }
        public string lift_name { get; set; }
        public int totalFloor { get; set; }
        public string lift_type { get; set; }
        public string startFloor { get; set; }
        public Nullable<int> bureau_no { get; set; }
        public string controlfloor { get; set; }
        public Nullable<int> flag { get; set; }
    }
}
