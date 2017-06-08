using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class vCardMake
    {
        public int card_no { get; set; }
        public int cust_no { get; set; }
        public Nullable<decimal> foregift { get; set; }
        public Nullable<decimal> balance { get; set; }
        public Nullable<System.DateTime> validdt { get; set; }
        public Nullable<int> status { get; set; }
        public string @operator { get; set; }
        public Nullable<System.DateTime> createdt { get; set; }
        public int LevelNo { get; set; }
        public string LevelName { get; set; }
        public Nullable<int> MaxCnt { get; set; }
        public Nullable<int> MaxAmt { get; set; }
        public Nullable<int> Percent { get; set; }
        public Nullable<int> ISOverMaxAmt { get; set; }
        public Nullable<int> state { get; set; }
        public Nullable<int> breakTimes { get; set; }
        public Nullable<int> lunchTimes { get; set; }
        public Nullable<int> supperTimes { get; set; }
        public Nullable<decimal> amt1 { get; set; }
        public Nullable<decimal> amt2 { get; set; }
        public Nullable<decimal> amt3 { get; set; }
        public Nullable<decimal> amt4 { get; set; }
    }
}
