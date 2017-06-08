using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class vComputer
    {
        public int 编号 { get; set; }
        public string 名称 { get; set; }
        public string 串口 { get; set; }
        public string 备注 { get; set; }
        public string 操作者 { get; set; }
        public Nullable<System.DateTime> 操作时间 { get; set; }
    }
}
