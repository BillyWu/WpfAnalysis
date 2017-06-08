using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class InvalidOpenGate
    {
        public int gateopen_id { get; set; }
        public Nullable<System.DateTime> gateopen_time { get; set; }
        public Nullable<int> gateopen_address { get; set; }
        public string gateopen_pic { get; set; }
        public string @operator { get; set; }
    }
}
