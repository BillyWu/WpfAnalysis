using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class custoper
    {
        public int cust_no { get; set; }
        public string cust_name { get; set; }
        public string cust_nick { get; set; }
        public int tid { get; set; }
        public string tname { get; set; }
        public int cardno { get; set; }
        public Nullable<int> deptno { get; set; }
    }
}
