using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class VKQ_daka
    {
        public Nullable<int> custNo { get; set; }
        public string cust_name { get; set; }
        public Nullable<int> deptNo { get; set; }
        public Nullable<System.DateTime> daKaDT { get; set; }
        public string deptName { get; set; }
        public string IsQianka { get; set; }
        public string doorName { get; set; }
    }
}
