using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class vCardPayRpt
    {
        public string 姓名 { get; set; }
        public string 级别 { get; set; }
        public int 卡号 { get; set; }
        public Nullable<decimal> 充前金额 { get; set; }
        public Nullable<decimal> 充值金额 { get; set; }
        public Nullable<decimal> 充后金额 { get; set; }
        public Nullable<System.DateTime> 充值日期 { get; set; }
        public Nullable<System.DateTime> 有效期 { get; set; }
        public string 备注 { get; set; }
    }
}
