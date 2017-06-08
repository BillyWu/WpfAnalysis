using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class Parksearch_pos
    {
        public int posID { get; set; }
        public string posName { get; set; }
        public string posIP { get; set; }
        public Nullable<int> xPos { get; set; }
        public Nullable<int> yPos { get; set; }
        public string areaMapPath { get; set; }
        public string Rermark { get; set; }
    }
}
