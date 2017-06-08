using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class vParkWhiteList
    {
        public int card_no { get; set; }
        public Nullable<int> card_type { get; set; }
        public Nullable<int> car_type { get; set; }
        public Nullable<int> park_stall { get; set; }
        public Nullable<int> timesec { get; set; }
        public Nullable<System.DateTime> validdt { get; set; }
        public string carno { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<decimal> balance { get; set; }
        public int cust_no { get; set; }
        public string matchDevStr { get; set; }
    }
}
