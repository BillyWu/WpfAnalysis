using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class vLiftRecord
    {
        public int card_no { get; set; }
        public string cust_name { get; set; }
        public string lift_name { get; set; }
        public int overnumber { get; set; }
        public System.DateTime cardtime { get; set; }
        public System.DateTime readtime { get; set; }
    }
}
