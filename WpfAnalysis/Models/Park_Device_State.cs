using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class Park_Device_State
    {
        public int device_ID { get; set; }
        public string Printer { get; set; }
        public string scanner { get; set; }
        public string cashIn { get; set; }
        public string cashOut { get; set; }
        public string coinIn { get; set; }
        public string coinOut { get; set; }
        public string cardRead { get; set; }
    }
}
