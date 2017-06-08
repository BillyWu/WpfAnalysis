using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class Table_MoneyDiscount
    {
        public int id { get; set; }
        public Nullable<int> Money { get; set; }
        public Nullable<decimal> Discount { get; set; }
    }
}
