using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class lift_card_make
    {
        public int card_no { get; set; }
        public int cust_no { get; set; }
        public int card_tid { get; set; }
        public string door_no { get; set; }
        public string room_no { get; set; }
        public Nullable<int> calltype { get; set; }
        public string allowlift { get; set; }
        public string allowfloor { get; set; }
        public string allowlift2 { get; set; }
        public string allowfloor2 { get; set; }
        public string allowlift3 { get; set; }
        public string allowfloor3 { get; set; }
        public Nullable<decimal> floorPrice { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public Nullable<System.DateTime> startTime { get; set; }
        public Nullable<System.DateTime> endTime { get; set; }
        public string weekStr { get; set; }
    }
}
