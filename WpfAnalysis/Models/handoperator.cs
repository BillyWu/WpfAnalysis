using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class handoperator
    {
        public int id { get; set; }
        public string @operator { get; set; }
        public string computer { get; set; }
        public Nullable<System.DateTime> optime { get; set; }
    }
}
