using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class kq_daKa
    {
        public int id { get; set; }
        public Nullable<int> custNo { get; set; }
        public Nullable<System.DateTime> daKaDT { get; set; }
        public Nullable<int> IsQianKa { get; set; }
        public string doorName { get; set; }
    }
}
