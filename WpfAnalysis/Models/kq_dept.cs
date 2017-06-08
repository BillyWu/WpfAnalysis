using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class kq_dept
    {
        public int deptNo { get; set; }
        public Nullable<int> parentNo { get; set; }
        public string deptName { get; set; }
    }
}
