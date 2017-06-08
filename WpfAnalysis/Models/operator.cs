using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFToolConvertYKTToCode.Models
{
    [Table("operator")]
    public partial class operator1
    {
        public int op_code { get; set; }
        public string op_name { get; set; }
        public string op_pass { get; set; }
        public Nullable<int> op_cardno { get; set; }
        public string remark { get; set; }
        public string creator { get; set; }
        public Nullable<System.DateTime> creatdt { get; set; }
        public Nullable<int> deptno { get; set; }
    }
}
