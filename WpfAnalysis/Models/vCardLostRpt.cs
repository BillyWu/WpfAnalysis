using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class vCardLostRpt
    {
        public string 姓名 { get; set; }
        public string 级别 { get; set; }
        public int 卡号 { get; set; }
        public string 操作类别 { get; set; }
        public Nullable<decimal> 卡上余额 { get; set; }
        public Nullable<System.DateTime> 有效期 { get; set; }
        public Nullable<System.DateTime> 操作日期 { get; set; }
        public string 备注 { get; set; }
    }
}
