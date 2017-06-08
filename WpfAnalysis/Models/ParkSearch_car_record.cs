using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class ParkSearch_car_record
    {
        public int devID { get; set; }
        public string devName { get; set; }
        public string plateName { get; set; }
        public string devIP { get; set; }
        public string smallPicPath { get; set; }
        public string picPath { get; set; }
        public int areaID { get; set; }
        public System.DateTime stamp { get; set; }
        public Nullable<bool> inPark { get; set; }
        public Nullable<bool> newFlag { get; set; }
        public string Remark { get; set; }
    }
}
