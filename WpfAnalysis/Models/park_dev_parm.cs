using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class park_dev_parm
    {
        public int dev_id { get; set; }
        public string sysflag { get; set; }
        public string commpass { get; set; }
        public string syspass { get; set; }
        public string userpass { get; set; }
        public Nullable<int> card_left { get; set; }
        public Nullable<int> stall_num { get; set; }
        public Nullable<int> user_info { get; set; }
        public Nullable<int> disp_delay { get; set; }
        public Nullable<int> temp_card { get; set; }
        public Nullable<int> currency { get; set; }
        public Nullable<int> in_overflow { get; set; }
        public Nullable<int> ext_dev { get; set; }
        public Nullable<int> allow_go { get; set; }
        public Nullable<int> dev_attr { get; set; }
        public Nullable<int> stall_in_use { get; set; }
        public Nullable<int> allow_card { get; set; }
        public Nullable<int> gate_select { get; set; }
        public Nullable<int> valid_days { get; set; }
        public Nullable<int> balance_left { get; set; }
        public Nullable<int> united_charge { get; set; }
        public Nullable<int> inout { get; set; }
        public Nullable<int> offline { get; set; }
        public string light { get; set; }
        public Nullable<int> reserve_num { get; set; }
    }
}
