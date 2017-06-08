using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class M_controlStallMap : EntityTypeConfiguration<M_controlStall>
    {
        public M_controlStallMap()
        {
            // Primary Key
            this.HasKey(t => t.stallNo);

            // Properties
            this.Property(t => t.sName)
                .HasMaxLength(40);

            this.Property(t => t.remark)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("M_controlStall");
            this.Property(t => t.stallNo).HasColumnName("stallNo");
            this.Property(t => t.sName).HasColumnName("sName");
            this.Property(t => t.remark).HasColumnName("remark");
        }
    }
}
