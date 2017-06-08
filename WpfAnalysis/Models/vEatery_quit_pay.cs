using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class vEatery_quit_pay
    {
        public int CardNO { get; set; }
        public int CustNO { get; set; }
        public Nullable<decimal> PrevAmt { get; set; }
        public Nullable<System.DateTime> ValidTime { get; set; }
        public Nullable<decimal> AddAmt { get; set; }
        public string Operator { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> CreateDT { get; set; }
        public string cust_name { get; set; }
        public Nullable<int> deptNo { get; set; }
        public string deptName { get; set; }
        public string cust_nick { get; set; }
    }
}
