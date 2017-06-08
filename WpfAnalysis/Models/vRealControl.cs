using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class vRealControl
    {
        public string 餐厅名称 { get; set; }
        public string 设备名称 { get; set; }
        public Nullable<int> 设备地址 { get; set; }
        public int 是否启用 { get; set; }
        public string 设备时间 { get; set; }
        public string 通迅状态 { get; set; }
        public string 当日补助 { get; set; }
        public int devno { get; set; }
        public int cmpno { get; set; }
        public int dinno { get; set; }
        public string cmpname { get; set; }
        public Nullable<int> devaddr { get; set; }
    }
}
