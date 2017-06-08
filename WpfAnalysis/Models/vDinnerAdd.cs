using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class vDinnerAdd
    {
        public Nullable<int> 编号 { get; set; }
        public string 名称 { get; set; }
        public string 星期 { get; set; }
        public string 早餐开始时间 { get; set; }
        public string 早餐结束时间 { get; set; }
        public string 午餐开始时间 { get; set; }
        public string 午餐结束时间 { get; set; }
        public string 晚餐开始时间 { get; set; }
        public string 晚餐结束时间 { get; set; }
        public Nullable<decimal> 早餐补助 { get; set; }
        public Nullable<decimal> 午餐补助 { get; set; }
        public Nullable<decimal> 晚餐补助 { get; set; }
        public string 操作者 { get; set; }
        public Nullable<System.DateTime> 操作时间 { get; set; }
        public int id { get; set; }
    }
}
