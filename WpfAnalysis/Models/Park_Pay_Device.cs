using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class Park_Pay_Device
    {
        public int device_ID { get; set; }
        public string device_name { get; set; }
        public string device_title { get; set; }
        public string device_type { get; set; }
        public string device_IP { get; set; }
        public Nullable<int> income_money { get; set; }
        public Nullable<int> cash_count { get; set; }
        public Nullable<int> ten_count { get; set; }
        public Nullable<int> twenty_count { get; set; }
        public Nullable<int> coin_count { get; set; }
        public string remark { get; set; }
    }
}
