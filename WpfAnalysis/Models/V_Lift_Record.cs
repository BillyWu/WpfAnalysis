using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class V_Lift_Record
    {
        public string 姓名 { get; set; }
        public int 用户编号 { get; set; }
        public string 部门 { get; set; }
        public int 卡号 { get; set; }
        public string 电梯 { get; set; }
        public string 门牌号 { get; set; }
        public string 房间号 { get; set; }
        public System.DateTime 刷卡时间 { get; set; }
        public System.DateTime 读取时间 { get; set; }
        public int 剩余使用次数 { get; set; }
        public string 卡型 { get; set; }
    }
}
