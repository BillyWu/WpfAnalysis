using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class subsystem
    {
        public int systemid { get; set; }
        public string sysflag { get; set; }
        public string commpass { get; set; }
        public string syspass { get; set; }
        public string userpass { get; set; }
        public Nullable<int> accesstype { get; set; }
        public Nullable<int> cardarea1 { get; set; }
        public Nullable<int> cardarea2 { get; set; }
    }
}
