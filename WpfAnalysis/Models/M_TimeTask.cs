using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class M_TimeTask
    {
        public int id { get; set; }
        public string devID { get; set; }
        public string taskDT { get; set; }
        public string taskTime { get; set; }
        public Nullable<int> weekDy { get; set; }
        public Nullable<int> Type { get; set; }
    }
}
