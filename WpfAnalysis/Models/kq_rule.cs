using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class kq_rule
    {
        public int id { get; set; }
        public int wrkNo { get; set; }
        public Nullable<int> wrkType { get; set; }
        public Nullable<int> ciDao { get; set; }
        public Nullable<int> zaoTui { get; set; }
        public Nullable<int> validSignTime { get; set; }
        public Nullable<int> weekHoliday { get; set; }
        public string JB_startTime { get; set; }
        public string JB_endTime { get; set; }
        public Nullable<int> IsJBDCalc { get; set; }
        public Nullable<int> IsHoliday { get; set; }
        public Nullable<int> dayTimes { get; set; }
    }
}
