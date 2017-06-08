using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class card_charge
    {
        public int ID { get; set; }
        public Nullable<int> SystemId { get; set; }
        public Nullable<int> CardNO { get; set; }
        public string CustName { get; set; }
        public Nullable<decimal> PrevAmt { get; set; }
        public Nullable<decimal> AddAmt { get; set; }
        public string Operator { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> CreateDT { get; set; }
    }
}
