using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class park_central_pay
    {
        public string carNo { get; set; }
        public long inSeq { get; set; }
        public Nullable<int> userType { get; set; }
        public Nullable<int> carType { get; set; }
        public Nullable<int> in_from { get; set; }
        public Nullable<System.DateTime> inTime { get; set; }
        public string in_pic { get; set; }
        public Nullable<decimal> money { get; set; }
        public Nullable<decimal> discountM { get; set; }
        public Nullable<decimal> paidM { get; set; }
        public Nullable<System.DateTime> payTime { get; set; }
        public string @operator { get; set; }
        public string ComputerName { get; set; }
        public string PayMethod { get; set; }
        public Nullable<int> isHandOver { get; set; }
    }
}
