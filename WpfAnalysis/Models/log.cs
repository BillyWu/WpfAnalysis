using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class log
    {
        public int log_id { get; set; }
        public Nullable<System.DateTime> log_date { get; set; }
        public Nullable<int> log_type { get; set; }
        public string @operator { get; set; }
    }
}
