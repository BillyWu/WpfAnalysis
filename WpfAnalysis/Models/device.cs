using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class device
    {
        public int dev_id { get; set; }
        public string dev_name { get; set; }
        public Nullable<int> dev_tid { get; set; }
        public Nullable<int> park_no { get; set; }
        public Nullable<int> inside_park { get; set; }
        public string computer { get; set; }
        public string location { get; set; }
        public Nullable<int> loopcheck { get; set; }
    }
}
