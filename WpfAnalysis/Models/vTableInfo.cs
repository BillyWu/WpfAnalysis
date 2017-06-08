using System;
using System.Collections.Generic;

namespace EFToolConvertYKTToCode.Models
{
    public partial class vTableInfo
    {
        public string TableName { get; set; }
        public short colid { get; set; }
        public string eFieldName { get; set; }
        public string type_name { get; set; }
        public short length { get; set; }
        public Nullable<int> isnullable { get; set; }
        public int scale { get; set; }
    }
}
