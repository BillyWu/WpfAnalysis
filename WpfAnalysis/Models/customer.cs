using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class customer
    {
        public int cust_no { get; set; }
        public string cust_name { get; set; }
        public string cust_password { get; set; }
        public string cust_nick { get; set; }
        public Nullable<int> sex { get; set; }
        public string phone_no { get; set; }
        public string mobile { get; set; }
        public string idcard { get; set; }
        public string address { get; set; }
        public string remark { get; set; }
        public string @operator { get; set; }
        public Nullable<System.DateTime> createdt { get; set; }
        public Nullable<int> wrkNo { get; set; }
        public Nullable<int> deptNo { get; set; }
        public string photo { get; set; }
        public Nullable<int> cust_level { get; set; }
    }
}
