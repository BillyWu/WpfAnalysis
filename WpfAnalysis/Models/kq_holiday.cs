using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class kq_holiday
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> Holiday { get; set; }
        public Nullable<int> IsHoliday { get; set; }
        public string Operator { get; set; }
        public Nullable<System.DateTime> createDT { get; set; }
        public string Remark { get; set; }
    }
}
