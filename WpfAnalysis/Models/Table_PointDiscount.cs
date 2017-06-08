using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class Table_PointDiscount
    {
        public int id { get; set; }
        public string VipLevel { get; set; }
        public string VipName { get; set; }
        public Nullable<int> FreeTime { get; set; }
        public Nullable<int> Point { get; set; }
        public Nullable<decimal> Discount { get; set; }
    }
}
