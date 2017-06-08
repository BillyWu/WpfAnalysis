using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class white_list2
    {
        public int devID { get; set; }
        public int card_no { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<System.DateTime> bDate { get; set; }
        public Nullable<System.DateTime> eDate { get; set; }
        public Nullable<int> TimeNo { get; set; }
        public string Pwd { get; set; }
        public Nullable<System.DateTime> FxDate { get; set; }
    }
}
