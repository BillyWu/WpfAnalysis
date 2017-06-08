using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class M_Record
    {
        public int ID { get; set; }
        public string CardNo { get; set; }
        public string Cust_nick { get; set; }
        public string Cust_name { get; set; }
        public string State { get; set; }
        public string SN { get; set; }
        public string ControlNo { get; set; }
        public string ReadNo { get; set; }
        public string DoorName { get; set; }
        public System.DateTime KaiTime { get; set; }
    }
}
