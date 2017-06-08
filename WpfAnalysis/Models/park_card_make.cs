using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class park_card_make
    {
        public int card_no { get; set; }
        public int cust_no { get; set; }
        public Nullable<int> card_type { get; set; }
        public Nullable<int> car_type { get; set; }
        public Nullable<int> car_color { get; set; }
        public string carno { get; set; }
        public Nullable<int> park { get; set; }
        public Nullable<int> park_stall { get; set; }
        public Nullable<int> park_stall1 { get; set; }
        public Nullable<int> park_stall2 { get; set; }
        public Nullable<int> timesec { get; set; }
        public string remark { get; set; }
        public string matchDevStr { get; set; }
    }
}
