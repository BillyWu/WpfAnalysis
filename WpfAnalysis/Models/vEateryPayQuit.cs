using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class vEateryPayQuit
    {
        public int CardNO { get; set; }
        public Nullable<decimal> AddAmt { get; set; }
        public Nullable<decimal> PrevAmt { get; set; }
        public Nullable<System.DateTime> CreateDT { get; set; }
        public string Remark { get; set; }
        public string Operator { get; set; }
        public string cust_nick { get; set; }
        public string cust_name { get; set; }
        public string deptname { get; set; }
        public int deptno { get; set; }
    }
}
