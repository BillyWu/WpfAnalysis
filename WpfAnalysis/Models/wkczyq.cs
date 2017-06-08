using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class wkczyq
    {
        public int cardno { get; set; }
        public Nullable<int> address { get; set; }
        public Nullable<int> card_type { get; set; }
        public Nullable<decimal> balance { get; set; }
        public Nullable<System.DateTime> startdate { get; set; }
        public Nullable<System.DateTime> enddate { get; set; }
        public Nullable<int> downloadflag { get; set; }
    }
}
