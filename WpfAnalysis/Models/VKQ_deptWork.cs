using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class VKQ_deptWork
    {
        public int deptno { get; set; }
        public string deptName { get; set; }
        public int wrkNo { get; set; }
        public string wrkName { get; set; }
        public string wrkStart1 { get; set; }
        public string wrkStart2 { get; set; }
        public string wrkEnd1 { get; set; }
        public string wrkEnd2 { get; set; }
        public Nullable<int> wrkTime { get; set; }
        public Nullable<int> wrkType { get; set; }
    }
}
