using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class EateryLevelSet
    {
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
        public Nullable<int> nightTimes { get; set; }
        public Nullable<decimal> amt1 { get; set; }
        public Nullable<decimal> amt2 { get; set; }
        public Nullable<decimal> amt3 { get; set; }
        public Nullable<decimal> amt4 { get; set; }
        public Nullable<decimal> fee1 { get; set; }
        public Nullable<decimal> fee2 { get; set; }
        public Nullable<decimal> fee3 { get; set; }
        public Nullable<decimal> fee4 { get; set; }
    }
}
