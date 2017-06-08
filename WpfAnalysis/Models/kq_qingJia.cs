using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class kq_qingJia
    {
        public int ID { get; set; }
        public Nullable<int> custNo { get; set; }
        public Nullable<System.DateTime> startDT { get; set; }
        public Nullable<System.DateTime> endDT { get; set; }
        public Nullable<int> howTime { get; set; }
        public Nullable<int> type { get; set; }
        public string Operator { get; set; }
        public Nullable<System.DateTime> createDT { get; set; }
        public string Remark { get; set; }
    }
}
