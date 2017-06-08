using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class EateryDevice
    {
        public int DevNo { get; set; }
        public Nullable<int> CmpNo { get; set; }
        public Nullable<int> DinNo { get; set; }
        public string DevName { get; set; }
        public Nullable<int> DevType { get; set; }
        public Nullable<int> DevAddr { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> CreateDT { get; set; }
        public string @operator { get; set; }
        public string devIP { get; set; }
    }
}
