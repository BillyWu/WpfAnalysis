using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class lift_record
    {
        public int card_no { get; set; }
        public int lift_no { get; set; }
        public int overnumber { get; set; }
        public System.DateTime cardtime { get; set; }
        public System.DateTime readtime { get; set; }
    }
}
