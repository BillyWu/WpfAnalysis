using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class M_log
    {
        public int id { get; set; }
        public Nullable<int> Rstart { get; set; }
        public Nullable<int> Rend { get; set; }
        public Nullable<bool> IsClear { get; set; }
        public string Operator { get; set; }
        public Nullable<System.DateTime> opTime { get; set; }
    }
}
