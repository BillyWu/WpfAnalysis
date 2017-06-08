using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class PA_tboDevice
    {
        public int SeqNO { get; set; }
        public Nullable<int> Region { get; set; }
        public Nullable<int> UpNO { get; set; }
        public string Display { get; set; }
        public Nullable<int> DevType { get; set; }
        public string Memo { get; set; }
    }
}
