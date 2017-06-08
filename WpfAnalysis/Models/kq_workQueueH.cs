using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class kq_workQueueH
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> wrkDate { get; set; }
        public Nullable<int> deptNo { get; set; }
        public Nullable<int> wrkNo { get; set; }
        public Nullable<int> wrkType { get; set; }
        public Nullable<int> IsHoliday { get; set; }
        public Nullable<System.DateTime> wrkStart1 { get; set; }
        public Nullable<System.DateTime> wrkEnd1 { get; set; }
        public Nullable<System.DateTime> wrkStart2 { get; set; }
        public Nullable<System.DateTime> wrkEnd2 { get; set; }
        public Nullable<System.DateTime> wrkStart3 { get; set; }
        public Nullable<System.DateTime> wrkEnd3 { get; set; }
    }
}
