using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class EateryDinnerAdd
    {
        public int Id { get; set; }
        public Nullable<int> DinNo { get; set; }
        public string DayName { get; set; }
        public string Start1 { get; set; }
        public string End1 { get; set; }
        public string Start2 { get; set; }
        public string End2 { get; set; }
        public string Start3 { get; set; }
        public string End3 { get; set; }
        public Nullable<decimal> BreakfastAmt { get; set; }
        public Nullable<decimal> LunchAmt { get; set; }
        public Nullable<decimal> SupperAmt { get; set; }
        public string @operator { get; set; }
        public Nullable<System.DateTime> createdt { get; set; }
        public string Start4 { get; set; }
        public string End4 { get; set; }
        public Nullable<decimal> NightAmt { get; set; }
    }
}
