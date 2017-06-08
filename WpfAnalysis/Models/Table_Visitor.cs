using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class Table_Visitor
    {
        public int card_no { get; set; }
        public int status { get; set; }
        public int card_type { get; set; }
        public string carno { get; set; }
        public int car_type { get; set; }
        public string cust_name { get; set; }
        public System.DateTime validdt { get; set; }
        public int park_stall { get; set; }
        public string matchDevStr { get; set; }
        public System.DateTime parkStartDT { get; set; }
        public string passcode { get; set; }
        public string visitor_desc { get; set; }
        public string cid { get; set; }
        public string block_name { get; set; }
        public string plate_number { get; set; }
        public string password { get; set; }
        public string arrive_at { get; set; }
        public string leave_at { get; set; }
    }
}
