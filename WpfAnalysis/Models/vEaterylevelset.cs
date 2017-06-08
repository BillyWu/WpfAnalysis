using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class vEaterylevelset
    {
        public int 编号 { get; set; }
        public string 等级 { get; set; }
        public Nullable<int> 次数 { get; set; }
        public Nullable<int> 金额 { get; set; }
        public Nullable<int> 折扣 { get; set; }
        public string 超额 { get; set; }
        public string 消费方式 { get; set; }
        public Nullable<int> 早餐免费次数 { get; set; }
        public Nullable<int> 午餐免费次数 { get; set; }
        public Nullable<int> 晚餐免费次数 { get; set; }
        public Nullable<decimal> 第一次金额 { get; set; }
        public Nullable<decimal> 第二次金额 { get; set; }
        public Nullable<decimal> 第三次金额 { get; set; }
        public Nullable<decimal> 三次以后金额 { get; set; }
    }
}
