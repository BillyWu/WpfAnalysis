using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class ParkSearch_car_log
    {
        public int devID { get; set; }
        public string devName { get; set; }
        public Nullable<System.DateTime> DevTime { get; set; }
        public Nullable<bool> devState { get; set; }
    }
}
