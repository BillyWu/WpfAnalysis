using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class parkingless520
    {
        public int card_no { get; set; }
        public long in_seq { get; set; }
        public Nullable<int> card_tid { get; set; }
        public Nullable<int> car_tid { get; set; }
        public string carno { get; set; }
        public Nullable<System.DateTime> in_time { get; set; }
        public string in_pic { get; set; }
        public Nullable<int> in_from { get; set; }
        public Nullable<int> stall_no { get; set; }
        public Nullable<int> inside_park { get; set; }
        public string @operator { get; set; }
        public string small_pic { get; set; }
        public Nullable<int> feesFlag { get; set; }
        public Nullable<System.DateTime> payTime { get; set; }
        public Nullable<decimal> central_pay_money { get; set; }
    }
}
