using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class vEateryPay
    {
        public int 卡号 { get; set; }
        public Nullable<decimal> AddAmt { get; set; }
        public Nullable<decimal> PrevAmt { get; set; }
        public Nullable<decimal> leftAmt { get; set; }
        public Nullable<System.DateTime> CreateDT { get; set; }
        public string Remark { get; set; }
        public string Operator { get; set; }
        public string cust_nick { get; set; }
        public string 姓名 { get; set; }
        public string 部门 { get; set; }
        public int deptNo { get; set; }
        public string deptName { get; set; }
        public int CardNO { get; set; }
        public string cust_name { get; set; }
    }
}
