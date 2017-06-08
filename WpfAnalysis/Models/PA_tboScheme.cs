using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class PA_tboScheme
    {
        public int SeqNO { get; set; }
        public Nullable<int> Region { get; set; }
        public string IP { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }
        public string Led { get; set; }
        public string CaptureLayout { get; set; }
        public Nullable<int> SchemeTime { get; set; }
        public Nullable<int> RepeatTime { get; set; }
        public Nullable<bool> OneCarMultipleNo { get; set; }
        public Nullable<int> WaitTime { get; set; }
    }
}
