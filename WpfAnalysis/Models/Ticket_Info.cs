using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class Ticket_Info
    {
        public Nullable<long> ID { get; set; }
        public string qp_Code { get; set; }
        public Nullable<System.DateTime> use_Time { get; set; }
        public string vip_Code { get; set; }
        public string merchant { get; set; }
        public string ticket_Number { get; set; }
        public Nullable<decimal> money { get; set; }
        public Nullable<int> point { get; set; }
        public Nullable<decimal> deductible_money { get; set; }
        public Nullable<int> deductible_mode { get; set; }
        public System.DateTime create_Time { get; set; }
    }
}
