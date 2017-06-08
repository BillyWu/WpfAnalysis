using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class kq_work
    {
        public int wrkNo { get; set; }
        public string wrkName { get; set; }
        public Nullable<int> wrkType { get; set; }
        public string wrkStart1 { get; set; }
        public string wrkEnd1 { get; set; }
        public string wrkStart2 { get; set; }
        public string wrkEnd2 { get; set; }
        public string wrkStart3 { get; set; }
        public string wrkEnd3 { get; set; }
        public Nullable<int> wrkTime { get; set; }
    }
}
