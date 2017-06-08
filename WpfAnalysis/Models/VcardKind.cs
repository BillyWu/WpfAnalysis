using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class VcardKind
    {
        public int MonthCard { get; set; }
        public int RentCard { get; set; }
        public int TempCard { get; set; }
        public int FreeCard { get; set; }
        public int TempFreeCard { get; set; }
        public int VisCard { get; set; }
        public Nullable<int> RemainStall { get; set; }
    }
}
