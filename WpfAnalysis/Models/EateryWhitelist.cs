using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class EateryWhitelist
    {
        public int devNo { get; set; }
        public string cust_name { get; set; }
        public Nullable<int> LevelNo { get; set; }
        public int card_no { get; set; }
        public Nullable<int> cust_no { get; set; }
        public Nullable<decimal> balance { get; set; }
        public Nullable<System.DateTime> validdt { get; set; }
        public Nullable<System.DateTime> createdt { get; set; }
        public int status { get; set; }
        public Nullable<int> flag { get; set; }
    }
}
