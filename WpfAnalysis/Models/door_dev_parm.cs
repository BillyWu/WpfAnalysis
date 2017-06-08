using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class door_dev_parm
    {
        public int dev_id { get; set; }
        public Nullable<int> left_rec_alarm { get; set; }
        public Nullable<int> open_door_delay { get; set; }
        public Nullable<int> buzzer { get; set; }
        public Nullable<int> open_mode { get; set; }
        public Nullable<int> multi_interval { get; set; }
        public Nullable<int> multi_num { get; set; }
        public Nullable<int> fire_alarm { get; set; }
        public Nullable<int> fire_delay { get; set; }
        public Nullable<int> riot_alarm { get; set; }
        public Nullable<int> riot_delay { get; set; }
        public Nullable<int> riot_close { get; set; }
        public Nullable<int> riot_card { get; set; }
        public Nullable<int> magnet { get; set; }
        public Nullable<int> close_delay1 { get; set; }
        public Nullable<int> close_delay2 { get; set; }
        public Nullable<int> work_mode { get; set; }
        public Nullable<int> isdeleted { get; set; }
        public Nullable<int> doors { get; set; }
    }
}
