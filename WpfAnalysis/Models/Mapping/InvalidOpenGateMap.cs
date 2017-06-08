using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFToolConvertYKTToCode.Models.Mapping
{
    public class InvalidOpenGateMap : EntityTypeConfiguration<InvalidOpenGate>
    {
        public InvalidOpenGateMap()
        {
            // Primary Key
            this.HasKey(t => t.gateopen_id);

            // Properties
            this.Property(t => t.gateopen_pic)
                .HasMaxLength(50);

            this.Property(t => t.@operator)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("InvalidOpenGate");
            this.Property(t => t.gateopen_id).HasColumnName("gateopen_id");
            this.Property(t => t.gateopen_time).HasColumnName("gateopen_time");
            this.Property(t => t.gateopen_address).HasColumnName("gateopen_address");
            this.Property(t => t.gateopen_pic).HasColumnName("gateopen_pic");
            this.Property(t => t.@operator).HasColumnName("operator");
        }
    }
}
