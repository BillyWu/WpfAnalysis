using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class vEateryCstDinRec
    {
        public string 用户姓名 { get; set; }
        public Nullable<int> 卡号 { get; set; }
        public string 卡号_姓名 { get; set; }
        public string 部门 { get; set; }
        public string 级别 { get; set; }
        public string 餐厅名 { get; set; }
        public string 设备名 { get; set; }
        public string 餐段 { get; set; }
        public Nullable<decimal> 原有金额 { get; set; }
        public Nullable<decimal> 应收金额 { get; set; }
        public Nullable<decimal> 补助金额 { get; set; }
        public Nullable<decimal> 实收金额 { get; set; }
        public Nullable<decimal> 剩余金额 { get; set; }
        public string 收费员 { get; set; }
        public Nullable<System.DateTime> 日期 { get; set; }
        public string 电脑名 { get; set; }
        public int ID { get; set; }
        public Nullable<int> DinNo { get; set; }
        public Nullable<int> CmpNo { get; set; }
        public Nullable<int> DevNo { get; set; }
        public string @operator { get; set; }
        public Nullable<int> DayAddNo { get; set; }
        public Nullable<int> CustNo { get; set; }
        public Nullable<int> CustLevel { get; set; }
        public Nullable<int> CardNo { get; set; }
        public Nullable<decimal> amt { get; set; }
        public Nullable<decimal> addAmt { get; set; }
        public Nullable<decimal> realAmt { get; set; }
        public Nullable<System.DateTime> CreateDT { get; set; }
        public Nullable<decimal> leftAmt { get; set; }
    }
}
