using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class V_Lift_Card_Info
    {
        public int card_no { get; set; }
        public string cust_name { get; set; }
        public int card_tid { get; set; }
        public string door_no { get; set; }
        public string room_no { get; set; }
        public Nullable<int> calltype { get; set; }
        public string lift_name { get; set; }
        public string allowfloor { get; set; }
    }
}
