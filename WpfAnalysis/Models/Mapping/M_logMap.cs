using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class M_logMap : EntityTypeConfiguration<M_log>
    {
        public M_logMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Operator)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("M_log");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Rstart).HasColumnName("Rstart");
            this.Property(t => t.Rend).HasColumnName("Rend");
            this.Property(t => t.IsClear).HasColumnName("IsClear");
            this.Property(t => t.Operator).HasColumnName("Operator");
            this.Property(t => t.opTime).HasColumnName("opTime");
        }
    }
}
