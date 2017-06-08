using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class card_delay
    {
        public int card_no { get; set; }
        public int cust_no { get; set; }
        public System.DateTime prevdate { get; set; }
        public Nullable<System.DateTime> currdate { get; set; }
        public Nullable<decimal> money { get; set; }
        public string remark { get; set; }
        public string @operator { get; set; }
        public Nullable<System.DateTime> createdt { get; set; }
    }
}
