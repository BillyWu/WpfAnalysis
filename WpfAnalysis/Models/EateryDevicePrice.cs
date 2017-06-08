using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class EateryDevicePrice
    {
        public int DevNo { get; set; }
        public int MenuNo { get; set; }
        public string MenuName { get; set; }
        public Nullable<decimal> MenuPrice { get; set; }
    }
}
