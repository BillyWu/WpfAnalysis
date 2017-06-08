using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class EateryCardPay
    {
        public int ID { get; set; }
        public int CardNO { get; set; }
        public int CustNO { get; set; }
        public Nullable<decimal> PrevAmt { get; set; }
        public Nullable<decimal> AddAmt { get; set; }
        public Nullable<System.DateTime> ValidTime { get; set; }
        public string Operator { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> CreateDT { get; set; }
    }
}
