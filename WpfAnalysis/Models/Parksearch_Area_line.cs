using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class Parksearch_Area_line
    {
        public int areaID { get; set; }
        public int posID { get; set; }
        public int sequence { get; set; }
        public Nullable<int> xPos { get; set; }
        public Nullable<int> yPos { get; set; }
        public string Rermark { get; set; }
    }
}
