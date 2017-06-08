using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class V_DoorWhiteList
    {
        public Nullable<int> card_no { get; set; }
        public string cust_nick { get; set; }
        public string cust_name { get; set; }
        public string flag { get; set; }
        public Nullable<System.DateTime> bDate { get; set; }
        public Nullable<System.DateTime> eDate { get; set; }
        public Nullable<int> TimeNo { get; set; }
        public Nullable<int> devID { get; set; }
        public Nullable<int> status { get; set; }
        public int SN { get; set; }
        public string ReadNo { get; set; }
        public string DoorName { get; set; }
    }
}
