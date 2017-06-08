using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class EateryCstDinRec
    {
        public int ID { get; set; }
        public Nullable<int> DinNo { get; set; }
        public Nullable<int> CmpNo { get; set; }
        public Nullable<int> DevNo { get; set; }
        public string @operator { get; set; }
        public Nullable<int> DayAddNo { get; set; }
        public Nullable<int> CustNo { get; set; }
        public Nullable<int> CustLevel { get; set; }
        public Nullable<int> CardNo { get; set; }
        public Nullable<decimal> amt { get; set; }
        public Nullable<decimal> addAmt { get; set; }
        public Nullable<decimal> realAmt { get; set; }
        public Nullable<System.DateTime> CreateDT { get; set; }
        public Nullable<decimal> leftAmt { get; set; }
    }
}
