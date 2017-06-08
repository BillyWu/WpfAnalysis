using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class out_park
    {
        public int card_no { get; set; }
        public long in_seq { get; set; }
        public Nullable<int> card_tid { get; set; }
        public Nullable<int> car_tid { get; set; }
        public string carno { get; set; }
        public Nullable<System.DateTime> out_time { get; set; }
        public string out_pic { get; set; }
        public Nullable<int> out_from { get; set; }
        public string ident_pic { get; set; }
        public Nullable<decimal> money1 { get; set; }
        public Nullable<decimal> money2 { get; set; }
        public Nullable<decimal> balance { get; set; }
        public Nullable<int> open_gate_mode { get; set; }
        public string @operator { get; set; }
        public Nullable<int> rectype { get; set; }
        public Nullable<int> isvalid { get; set; }
        public Nullable<int> park_no { get; set; }
        public Nullable<int> inside_park { get; set; }
        public string invoice { get; set; }
        public Nullable<System.DateTime> in_time { get; set; }
        public Nullable<System.DateTime> update_time { get; set; }
        public Nullable<int> isHandOver { get; set; }
        public string out_pic2 { get; set; }
        public Nullable<int> in_from { get; set; }
    }
}
