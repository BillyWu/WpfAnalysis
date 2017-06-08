using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class door_card_make
    {
        public int card_no { get; set; }
        public int cust_no { get; set; }
        public Nullable<int> CardState { get; set; }
        public Nullable<System.DateTime> bDate { get; set; }
        public Nullable<System.DateTime> eDate { get; set; }
        public string TimeNo { get; set; }
        public string MachNo { get; set; }
        public string DownMachNo { get; set; }
        public Nullable<System.DateTime> FxDate { get; set; }
    }
}
