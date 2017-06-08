using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class vCardQuitRpt
    {
        public int 卡号 { get; set; }
        public string 姓名 { get; set; }
        public Nullable<decimal> 押金 { get; set; }
        public Nullable<decimal> 卡上余额 { get; set; }
        public Nullable<decimal> 退还金额 { get; set; }
        public string 退还方式 { get; set; }
        public Nullable<System.DateTime> 操作日期 { get; set; }
        public string 备注 { get; set; }
    }
}
