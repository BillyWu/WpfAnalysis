using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class Park_Auto_Pay_Record
    {
        public string serial_number { get; set; }
        public Nullable<int> device_ID { get; set; }
        public Nullable<int> pay_teminal { get; set; }
        public string card_no { get; set; }
        public Nullable<System.DateTime> inPark_time { get; set; }
        public Nullable<System.DateTime> outPark_time { get; set; }
        public string pay_type { get; set; }
        public int deserve_money { get; set; }
        public int real_money { get; set; }
        public Nullable<int> dispense_money { get; set; }
        public Nullable<int> operate_flag { get; set; }
        public System.DateTime operate_time { get; set; }
        public string remark { get; set; }
    }
}
