using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class EateryComputer
    {
        public int CmpNo { get; set; }
        public string CmpName { get; set; }
        public Nullable<int> ComPort { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> CreateDT { get; set; }
        public string @operator { get; set; }
    }
}
