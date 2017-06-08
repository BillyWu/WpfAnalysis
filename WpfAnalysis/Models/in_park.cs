using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class in_park
    {
        public int card_no { get; set; }
        public long in_seq { get; set; }
        public Nullable<int> card_tid { get; set; }
        public string carno { get; set; }
        public Nullable<System.DateTime> in_time { get; set; }
        public string in_pic { get; set; }
        public Nullable<int> in_from { get; set; }
        public Nullable<int> open_gate_mode { get; set; }
        public Nullable<int> stall_in_use { get; set; }
        public string @operator { get; set; }
        public Nullable<int> rectype { get; set; }
        public Nullable<int> park_no { get; set; }
        public Nullable<int> inside_park { get; set; }
        public Nullable<System.DateTime> update_time { get; set; }
        public Nullable<int> isHandOver { get; set; }
    }
}
