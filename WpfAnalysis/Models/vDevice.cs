using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class vDevice
    {
        public int 编号 { get; set; }
        public string 名称 { get; set; }
        public string 电脑 { get; set; }
        public string 餐厅 { get; set; }
        public string 设备类型 { get; set; }
        public Nullable<int> 设备地址 { get; set; }
        public string 操作者 { get; set; }
        public Nullable<System.DateTime> 操作时间 { get; set; }
        public string 备注 { get; set; }
    }
}
