using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class EateryCustLevel
    {
        public int CustNo { get; set; }
        public int LevelNo { get; set; }
        public int AccessMode { get; set; }
        public string dinner { get; set; }
        public string MatchDevStr { get; set; }
    }
}
