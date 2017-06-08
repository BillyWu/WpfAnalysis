using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class M_Time
    {
        public int TimeNo { get; set; }
        public string TimeName { get; set; }
        public string bDate { get; set; }
        public string eDate { get; set; }
        public Nullable<int> NextTimeNo { get; set; }
        public string Week { get; set; }
        public string Time11 { get; set; }
        public string Time12 { get; set; }
        public string Time21 { get; set; }
        public string Time22 { get; set; }
        public string Time31 { get; set; }
        public string Time32 { get; set; }
    }
}
