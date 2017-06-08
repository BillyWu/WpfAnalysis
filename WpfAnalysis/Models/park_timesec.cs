using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class park_timesec
    {
        public int timeid { get; set; }
        public string timename { get; set; }
        public string timesec1 { get; set; }
        public string timesec2 { get; set; }
        public string timedate { get; set; }
        public Nullable<int> satrest { get; set; }
        public Nullable<int> sunrest { get; set; }
    }
}
