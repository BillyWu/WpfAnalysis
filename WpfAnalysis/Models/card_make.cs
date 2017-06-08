using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class card_make
    {
        public int card_no { get; set; }
        public int cust_no { get; set; }
        public Nullable<decimal> foregift { get; set; }
        public Nullable<decimal> balance { get; set; }
        public Nullable<System.DateTime> validdt { get; set; }
        public Nullable<int> status { get; set; }
        public string @operator { get; set; }
        public Nullable<System.DateTime> createdt { get; set; }
        public Nullable<System.DateTime> parkStartDT { get; set; }
    }
}
