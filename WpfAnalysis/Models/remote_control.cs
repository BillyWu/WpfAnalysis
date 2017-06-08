using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class remote_control
    {
        public System.DateTime indt { get; set; }
        public string @operator { get; set; }
        public Nullable<int> comm_type { get; set; }
        public Nullable<int> address { get; set; }
        public Nullable<int> flag { get; set; }
        public string picture { get; set; }
        public Nullable<int> isHandOver { get; set; }
        public string allowFree { get; set; }
    }
}
