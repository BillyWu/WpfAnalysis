using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class vcustomer
    {
        public int 编号 { get; set; }
        public string 姓名 { get; set; }
        public string 级别 { get; set; }
        public string 性别 { get; set; }
        public string 昵称 { get; set; }
        public string 电话 { get; set; }
        public string 手机 { get; set; }
        public string 卡号 { get; set; }
        public string 地址 { get; set; }
        public string 操作者 { get; set; }
        public Nullable<System.DateTime> 日期 { get; set; }
        public string 备注 { get; set; }
    }
}
