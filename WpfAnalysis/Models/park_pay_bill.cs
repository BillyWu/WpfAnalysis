using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class park_pay_bill
    {
        public long billNo { get; set; }
        public string carNo { get; set; }
        public long inSeq { get; set; }
        public Nullable<int> userType { get; set; }
        public Nullable<int> carType { get; set; }
        public Nullable<System.DateTime> inTime { get; set; }
        public Nullable<System.DateTime> outTime { get; set; }
        public Nullable<decimal> money { get; set; }
        public Nullable<decimal> discountM { get; set; }
        public Nullable<decimal> paidM { get; set; }
        public Nullable<int> payMode { get; set; }
        public Nullable<int> recStatus { get; set; }
        public Nullable<int> isVip { get; set; }
        public Nullable<System.DateTime> payTime { get; set; }
        public string @operator { get; set; }
        public Nullable<int> isHandOver { get; set; }
    }
}
