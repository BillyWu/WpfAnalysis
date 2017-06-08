using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class card_lost
    {
        public int card_no { get; set; }
        public int cust_no { get; set; }
        public int optype { get; set; }
        public Nullable<System.DateTime> lostdt { get; set; }
        public string remark { get; set; }
        public string @operator { get; set; }
        public Nullable<System.DateTime> createdt { get; set; }
    }
}
