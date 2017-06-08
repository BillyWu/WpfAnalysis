using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class M_ControlDefine
    {
        public int SN { get; set; }
        public Nullable<int> ControlNo { get; set; }
        public string ReadNo { get; set; }
        public string DoorName { get; set; }
        public string IP { get; set; }
        public string Port { get; set; }
        public string Watch { get; set; }
        public int xPos { get; set; }
        public int yPos { get; set; }
        public int IsKq { get; set; }
        public Nullable<int> StallNO { get; set; }
        public Nullable<int> Type { get; set; }
        public string Pwd { get; set; }
        public int id { get; set; }
    }
}
