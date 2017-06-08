using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class PayMethod
    {
        public string Name { get; set; }
        public bool Support { get; set; }
        public int TimeOut { get; set; }
        public string CloudRootAddress { get; set; }
        public string CloudInOperate { get; set; }
        public string CloudOutOperate { get; set; }
        public string CloudQueryPay { get; set; }
        public string CloudSyncData { get; set; }
        public Nullable<int> NetworkTO { get; set; }
        public Nullable<int> Priority { get; set; }
    }
}
