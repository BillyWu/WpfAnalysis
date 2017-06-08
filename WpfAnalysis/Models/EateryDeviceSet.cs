using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class EateryDeviceSet
    {
        public int DevNo { get; set; }
        public Nullable<int> MaxAmt { get; set; }
        public Nullable<int> MinAmt { get; set; }
        public Nullable<int> DelayTime { get; set; }
        public Nullable<int> ISDevTime { get; set; }
        public Nullable<int> ISOpenDev { get; set; }
        public Nullable<int> ISOverMaxAmt { get; set; }
        public Nullable<int> ISOverBlance { get; set; }
    }
}
