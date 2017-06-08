using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class EateryDinner
    {
        public int DinNo { get; set; }
        public string DinName { get; set; }
        public string @operator { get; set; }
        public Nullable<System.DateTime> CreateDT { get; set; }
        public string remark { get; set; }
    }
}
