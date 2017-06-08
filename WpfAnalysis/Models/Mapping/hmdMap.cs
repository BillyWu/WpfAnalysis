using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class hmdMap : EntityTypeConfiguration<hmd>
    {
        public hmdMap()
        {
            // Primary Key
            this.HasKey(t => t.bh);

            // Properties
            // Table & Column Mappings
            this.ToTable("hmd");
            this.Property(t => t.bh).HasColumnName("bh");
            this.Property(t => t.card_no).HasColumnName("card_no");
            this.Property(t => t.cust_no).HasColumnName("cust_no");
        }
    }
}
