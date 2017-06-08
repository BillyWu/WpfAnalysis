using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class lift_price
    {
        public int id { get; set; }
        public int startfloor { get; set; }
        public int endfloor { get; set; }
        public decimal price { get; set; }
    }
}
