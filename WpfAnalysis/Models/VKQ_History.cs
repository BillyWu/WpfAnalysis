using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class VKQ_History
    {
        public int ID { get; set; }
        public Nullable<int> RIQI { get; set; }
        public string RIQI2 { get; set; }
        public Nullable<System.DateTime> CREATEDT { get; set; }
        public Nullable<int> ISHISTORY { get; set; }
    }
}
